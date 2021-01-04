using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace AForge.WindowsForms
{
    class TLGBotik
    {
        public Telegram.Bot.TelegramBotClient botik = null;

        private UpdateTLGMessages formUpdater;

        private BaseNetwork perseptron = null;

        /// <summary>
        /// Чат-бот AIML
        /// </summary>
        AIMLBotik AIMLbotik = new AIMLBotik();

        public TLGBotik(BaseNetwork net, UpdateTLGMessages updater)
        {
            var botKey = System.IO.File.ReadAllText("botkey.txt");
            botik = new Telegram.Bot.TelegramBotClient(botKey);
            botik.OnMessage += Botik_OnMessageAsync;
            formUpdater = updater;
            perseptron = net;
        }

        public void SetNet(BaseNetwork net)
        {
            perseptron = net;
            formUpdater("Net updated!");
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
        private void Botik_OnMessageAsync(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            //  Тут очень простое дело - банально отправляем назад сообщения
            var message = e.Message;
            formUpdater("Тип сообщения : " + message.Type.ToString());
            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                string ans = AIMLbotik.Talk(message.Text, message.From.Id);
                botik.SendTextMessageAsync(message.Chat.Id, ans);
            }
            //  Получение файла (картинки)
            if (message.Type == Telegram.Bot.Types.Enums.MessageType.Photo)
            {
                formUpdater("Picture loadining started");
                var photoId = message.Photo.Last().FileId;
                File fl = botik.GetFileAsync(photoId).Result;

                var img = System.Drawing.Image.FromStream(botik.DownloadFileAsync(fl.FilePath).Result);

                System.Drawing.Bitmap bm = new System.Drawing.Bitmap(img);
                var date = DateTime.Now.ToString().Replace('.', '_').Replace(':', '_');
                bm.Save($"res\\pic{date}.jpg");
                var uImg = AForge.Imaging.UnmanagedImage.FromManagedImage(bm);
                MagicEye processor = new MagicEye();
                bm = processor.ProcessImage(bm);
                bm.Save($"res\\pic{date}p.jpg");
                int n = perseptron.Predict(new Sample(Preprocess(bm/*uImg.ToManagedImage()*/), 10));
                botik.SendTextMessageAsync(message.Chat.Id, $"Это цифра {n}");

                formUpdater("Picture recognized!");
                return;
            }

            if (message == null || message.Type != Telegram.Bot.Types.Enums.MessageType.Text) return;
            //   botik.SendTextMessageAsync(message.Chat.Id, "Bot reply : " + message.Text);
            formUpdater(message.Text);
            return;
        }

        public bool Act()
        {
            try
            {
                botik.StartReceiving();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public void Stop()
        {
            botik.StopReceiving();
        }

    }
}
