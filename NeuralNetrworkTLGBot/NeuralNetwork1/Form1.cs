using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;
using System.IO.Ports;
using AForge.Imaging;
using System.IO;
using System.Globalization;
using Accord.Math;

namespace AForge.WindowsForms
{

	public delegate void FormUpdater(double progress, double error, TimeSpan time, int epoch = 0);

    public delegate void UpdateTLGMessages(string msg);

    public partial class Form1 : Form
    {
        /// <summary>
        /// Чат-бот AIML
        /// </summary>
        AIMLBotik botik = new AIMLBotik();

        TLGBotik tlgBot;

        /// <summary>
        /// Генератор изображений (образов)
        /// </summary>
        //GenerateImage generator = new GenerateImage();
        
        /// <summary>
        /// Обёртка для ActivationNetwork из Accord.Net
        /// </summary>
        AccordNet AccordNet = null;

        /// <summary>
        /// Абстрактный базовый класс, псевдоним либо для CustomNet, либо для AccordNet
        /// </summary>
        BaseNetwork net = null;

        public Form1()
        {
            InitializeComponent();
            tlgBot = new TLGBotik(net, new UpdateTLGMessages(UpdateTLGInfo));
            netTypeBox.SelectedIndex = 1;
          //  generator.figure_count = (int)classCounter.Value;
            //button3_Click(this, null);
          //  pictureBox1.Image = Properties.Resources.Title;

        }

		public void UpdateLearningInfo(double progress, double error, TimeSpan elapsedTime, int epoch = 0)
		{
			if (progressBar1.InvokeRequired)
			{
				progressBar1.Invoke(new FormUpdater(UpdateLearningInfo),new Object[] {progress, error, elapsedTime, epoch});
				return;
			}
            status.Text = "Accuracy: " + error.ToString();
            int prgs = (int)System.Math.Round(progress*100);
			prgs = System.Math.Min(100, System.Math.Max(0,prgs));
            elapsedTimeLabel.Text = "Затраченное время : " + elapsedTime.Duration().ToString(@"hh\:mm\:ss\:ff");
            progressBar1.Value = prgs;
            if (epoch != 0)
                this.lblEpoch.Text = $"Эпоха №{epoch}";
        }

        public void UpdateTLGInfo(string message)
        {
            if (TLGUsersMessages.InvokeRequired)
            {
                TLGUsersMessages.Invoke(new UpdateTLGMessages(UpdateTLGInfo), new Object[] { message });
                return;
            }
            TLGUsersMessages.Text += message + Environment.NewLine;
        }

        private void set_result(Sample figure)
        {
            label1.Text = figure.ToString();

            if (figure.Correct())
                label1.ForeColor = Color.Green;
            else
                label1.ForeColor = Color.Red;

            label1.Text = "Распознано : " + figure.recognizedClass.ToString();

            label1.Text = String.Join("\n", net.getOutput().Select(d => d.ToString())); //было label8
           // pictureBox1.Image = generator.genBitmap();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
          //  Sample fig = generator.GenerateFigure();

          /*  net.Predict(fig);

            set_result(fig);*/

            /*var rnd = new Random();
            var fname = "pic" + (rnd.Next() % 100).ToString() + ".jpg";
            pictureBox1.Image.Save(fname);*/

        }

      /*  private async Task<double> train_networkAsync(int training_size, int epoches, double acceptable_error, bool parallel = true)
        {
            //  Выключаем всё ненужное
            label1.Text = "Выполняется обучение...";
            label1.ForeColor = Color.Red;
            groupBox1.Enabled = false;
            pictureBox1.Enabled = false;
            //trainOneButton.Enabled = false;

            //  Создаём новую обучающую выборку
            SamplesSet samples = new SamplesSet();

            for (int i = 0; i < training_size; i++)
                samples.AddSample(generator.GenerateFigure());

            //  Обучение запускаем асинхронно, чтобы не блокировать форму
            double f = await Task.Run(() => net.TrainOnDataSet(samples, epoches, acceptable_error, parallel));

            label1.Text = "Щелкните на картинку для теста нового образа";
            label1.ForeColor = Color.Green;
            groupBox1.Enabled = true;
            pictureBox1.Enabled = true;
            //trainOneButton.Enabled = true;
            status.Text = "Accuracy: " + f.ToString();
            status.ForeColor = Color.Green;
            return f;

        }*/

    /*    private void button1_Click(object sender, EventArgs e)
        {

            #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            train_networkAsync(10, (int)EpochesCounter.Value, (100 - AccuracyCounter.Value) / 100.0, parallelCheckBox.Checked);
            #pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }*/

      

       /* private void button3_Click(object sender, EventArgs e)
        {
            //  Проверяем корректность задания структуры сети
            int[] structure = netStructureBox.Text.Split(';').Select((c) => int.Parse(c)).ToArray<int>();
            if (structure.Length < 2 || structure[0] != 28*28 || structure[structure.Length - 1] != 10)
            {
                MessageBox.Show("А давайте вы структуру сети нормально запишите, ОК?", "Ошибка", MessageBoxButtons.OK);
                return;
            };

            
            AccordNet = new AccordNet(structure);
            AccordNet.updateDelegate = UpdateLearningInfo;

            net = AccordNet;

            tlgBot.SetNet(net);

        }*/

        /*private void classCounter_ValueChanged(object sender, EventArgs e)
        {
            //generator.figure_count = (int)classCounter.Value;
            var vals = netStructureBox.Text.Split(';');
            int outputNeurons;
            if (int.TryParse(vals.Last(),out outputNeurons))
            {
                vals[vals.Length - 1] = classCounter.Value.ToString();
                netStructureBox.Text = vals.Aggregate((partialPhrase, word) => $"{partialPhrase};{word}");
            }
        }*/


        private void netTrainButton_MouseEnter(object sender, EventArgs e)
        {
            infoStatusLabel.Text = "Обучить нейросеть с указанными параметрами";
        }

        private void testNetButton_MouseEnter(object sender, EventArgs e)
        {
            infoStatusLabel.Text = "Тестировать нейросеть на тестовой выборке такого же размера";
        }

        private void netTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            net = AccordNet;
        }

        private void recreateNetButton_MouseEnter(object sender, EventArgs e)
        {
            infoStatusLabel.Text = "Заново пересоздаёт сеть с указанными параметрами";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var phrase = AIMLInput.Text;
            if (phrase.Length > 0)
                AIMLOutput.Text += botik.Talk(phrase, 0) + Environment.NewLine;
        }

        private void TLGBotOnButton_Click(object sender, EventArgs e)
        {
            tlgBot.Act();
            TLGBotOnButton.Enabled = false;
        }
        // <summary>
        /// Самодельный персептрон – из массивов и палок
        /// </summary>
        NeuralNetwork CustomNet = null;
        private void recreateNetButton_Click(object sender, EventArgs e)
        {
            int[] structure = netStructureBox.Text.Split(';').Select((c) => int.Parse(c)).ToArray<int>();
            if (structure.Length < 2 || structure[0] != 28 * 28 || structure[structure.Length - 1] != 10)
            {
                MessageBox.Show("А давайте вы структуру сети нормально запишите, ОК?", "Ошибка", MessageBoxButtons.OK);
                return;
            };

            CustomNet = new NeuralNetwork(structure);
            CustomNet.updateDelegate = UpdateLearningInfo;

            AccordNet = new AccordNet(structure);
            AccordNet.updateDelegate = UpdateLearningInfo;
            if (netTypeBox.SelectedItem.ToString().StartsWith("Accord"))
                net = AccordNet;
            else
                net = CustomNet;

            tlgBot.SetNet(net);
        }
        private async Task<double> train_networkAsync(int epoches, double acceptable_error, bool parallel = true)
        {
            status.Text = "Тренировка...";

            //  Выключаем всё ненужное
         /*   label16.Text = "Выполняется обучение...";
            label16.ForeColor = Color.Red;*/
            groupBox1.Enabled = false;

            //  Обучение запускаем асинхронно, чтобы не блокировать форму
            double f = await Task.Run(() => net.TrainOnDataSet(samplesSetTrain, epoches, acceptable_error, parallel));

            status.Text = "Это цифра: ";
            /*label16.Text = "Обучение выполнено!";
            label16.ForeColor = Color.Green;*/
            groupBox1.Enabled = true;
            status.ForeColor = Color.Green;
            return f;

        }
        private void button_train_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = 0;
            lblEpoch.Text = "";
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            train_networkAsync((int)EpochesCounter.Value, (100 - AccuracyCounter.Value) / 100.0, parallelCheckBox.Checked);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = 0;
            lblEpoch.Text = "";
            this.Enabled = false;

            double accuracy = net.TestOnDataSet(samplesSetTest);

            status.Text = string.Format("Точность на тестовой выборке : {0,5:F2}%", accuracy * 100);
            if (accuracy * 100 >= AccuracyCounter.Value)
                status.ForeColor = Color.Green;
            else
                status.ForeColor = Color.Red;

            this.Enabled = true;
        }
        SamplesSet samplesSetTrain;
        SamplesSet samplesSetTest;


        private List<double[]> list_dataset;
        private List<double[]> list_labels;

        private List<double[]> list_dataset_test;
        private List<double[]> list_labels_test;

        private int classes = 10;
        public void createDatasetImages(string path, byte threshold)
        {
            var names = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\img");

            if (System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\img\\" + path))
            {
                System.IO.Directory.Delete(System.IO.Directory.GetCurrentDirectory() + "\\img\\" + path, true);
            }
            System.IO.Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory() + "\\img\\" + path);
            MagicEye processor = new MagicEye();

            for (var i = 0; i < names.Length; ++i)
            {
                this.progressBar1.Value = (i + 1) * 100 / names.Length;
                //   Загружаем изображение
                var uImg = AForge.Imaging.UnmanagedImage.FromManagedImage(new Bitmap(names[i]));

                processor.processSampleDataset(ref uImg, threshold);

                string newName = Path.GetDirectoryName(names[i]) + "\\" + path + "\\" + Path.GetFileName(names[i]);

                uImg.ToManagedImage().Save(newName);
            }
        }

        public double[] Preprocess(Bitmap bmp)
        {
            int w = bmp.Width;
            int h = bmp.Height;

            System.Drawing.Imaging.BitmapData imdata = bmp.LockBits(
                new Rectangle(0, 0, w, h),
                System.Drawing.Imaging.ImageLockMode.ReadWrite, bmp.PixelFormat);

            UnmanagedImage unmImg = new UnmanagedImage(imdata);


            double[] res = new double[w * h];
            for (int i = 0; i < w; ++i)
                for (int j = 0; j < h; ++j)
                {
                    float c = unmImg.GetPixel(i, j).GetBrightness();
                    res[i * w + j] = (c < 0.5 ? 1 : 0);
                }

            bmp.UnlockBits(imdata);

            return res;
        }

        /// <summary>
        /// Загружае предобработанные изображения
        /// </summary>
        private void loadDatasetFromFiles(string path)
        {
            var names = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\img\\" + path);
            names.Shuffle();

            list_dataset = new List<double[]>();
            list_labels = new List<double[]>();
            list_dataset_test = new List<double[]>();
            list_labels_test = new List<double[]>();

            for (int i = 0; i < names.Length; ++i)
            {
                //  с вероятностью 0.2 загнать образ в test, иначе в train
                if (i % 5 == 0)
                {
                    list_dataset_test.Add(Preprocess(new Bitmap(names[i])));
                    list_labels_test.Add(ToLabelArray(int.Parse(names[i][names[i].Length - 9].ToString())));
                }
                else
                {
                    list_dataset.Add(Preprocess(new Bitmap(names[i])));
                    list_labels.Add(ToLabelArray(int.Parse(names[i][names[i].Length - 9].ToString())));
                }

            }
        }

        private double[] ToLabelArray(int n)
        {
            double[] lbl = new double[classes];
            for (int i = 0; i < classes; ++i)
                lbl[i] = 0;
            lbl[n] = 1;
            return lbl;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            status.Text = "Выполняется обработка изображений";
            createDatasetImages("train", 200);
            createDatasetImages("train2", 220);
            status.Text = "Обработка выполнена";
        }
        /// <summary>
        /// Создаёт SampleSet для обучения и тестирования
        /// </summary>
        private void makeDataset()
        {
            samplesSetTrain = new SamplesSet();
            for (int i = 0; i < list_dataset.Count; i++)
                samplesSetTrain.AddSample(new Sample(list_dataset[i], 10, list_labels[i].IndexOf(1)));

            samplesSetTest = new SamplesSet();
            for (int i = 0; i < list_dataset_test.Count; i++)
                samplesSetTest.AddSample(new Sample(list_dataset_test[i], 10, list_labels_test[i].IndexOf(1)));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            status.Text = "Выполняеся загрузка датасета";
            loadDatasetFromFiles("train");
            loadDatasetFromFiles("train2");
            makeDataset();
            status.Text = "Файлы загружены";
        }
    }

  }
