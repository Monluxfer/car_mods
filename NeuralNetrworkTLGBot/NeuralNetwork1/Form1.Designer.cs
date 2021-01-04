namespace AForge.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label15;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.infoStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.вапрвапрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AIMLOutput = new System.Windows.Forms.TextBox();
            this.AIMLInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TLGBotOnButton = new System.Windows.Forms.Button();
            this.TLGUsersMessages = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEpoch = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.elapsedTimeLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.netTypeBox = new System.Windows.Forms.ComboBox();
            this.parallelCheckBox = new System.Windows.Forms.CheckBox();
            this.netStructureBox = new System.Windows.Forms.TextBox();
            this.recreateNetButton = new System.Windows.Forms.Button();
            this.AccuracyCounter = new System.Windows.Forms.TrackBar();
            this.EpochesCounter = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button_train = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochesCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(669, 470);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 17);
            label7.TabIndex = 63;
            label7.Text = "Status:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(29, 188);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(145, 17);
            label12.TabIndex = 9;
            label12.Text = "Требуемая точность";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(39, 91);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(185, 17);
            label13.TabIndex = 7;
            label13.Text = "Максимальное кол-во эпох";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(115, 57);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(110, 17);
            label15.TabIndex = 2;
            label15.Text = "Структура сети";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 614);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Какой-то текст";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1576, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // infoStatusLabel
            // 
            this.infoStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoStatusLabel.Name = "infoStatusLabel";
            this.infoStatusLabel.Size = new System.Drawing.Size(100, 20);
            this.infoStatusLabel.Text = "Обучите сеть";
            this.infoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // вапрвапрToolStripMenuItem
            // 
            this.вапрвапрToolStripMenuItem.Name = "вапрвапрToolStripMenuItem";
            this.вапрвапрToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вапрвапрToolStripMenuItem.Text = "вапрвапр";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.AIMLOutput);
            this.groupBox2.Controls.Add(this.AIMLInput);
            this.groupBox2.Location = new System.Drawing.Point(147, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(475, 226);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AIML чат-бот";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Обработать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AIMLOutput
            // 
            this.AIMLOutput.Location = new System.Drawing.Point(17, 124);
            this.AIMLOutput.Margin = new System.Windows.Forms.Padding(4);
            this.AIMLOutput.Multiline = true;
            this.AIMLOutput.Name = "AIMLOutput";
            this.AIMLOutput.Size = new System.Drawing.Size(436, 94);
            this.AIMLOutput.TabIndex = 1;
            // 
            // AIMLInput
            // 
            this.AIMLInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AIMLInput.Location = new System.Drawing.Point(15, 28);
            this.AIMLInput.Margin = new System.Windows.Forms.Padding(4);
            this.AIMLInput.Name = "AIMLInput";
            this.AIMLInput.Size = new System.Drawing.Size(439, 34);
            this.AIMLInput.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TLGBotOnButton);
            this.groupBox3.Controls.Add(this.TLGUsersMessages);
            this.groupBox3.Location = new System.Drawing.Point(1085, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(475, 586);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Telegram";
            // 
            // TLGBotOnButton
            // 
            this.TLGBotOnButton.Location = new System.Drawing.Point(292, 23);
            this.TLGBotOnButton.Margin = new System.Windows.Forms.Padding(4);
            this.TLGBotOnButton.Name = "TLGBotOnButton";
            this.TLGBotOnButton.Size = new System.Drawing.Size(163, 42);
            this.TLGBotOnButton.TabIndex = 1;
            this.TLGBotOnButton.Text = "BotOn";
            this.TLGBotOnButton.UseVisualStyleBackColor = true;
            this.TLGBotOnButton.Click += new System.EventHandler(this.TLGBotOnButton_Click);
            // 
            // TLGUsersMessages
            // 
            this.TLGUsersMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TLGUsersMessages.Location = new System.Drawing.Point(8, 81);
            this.TLGUsersMessages.Margin = new System.Windows.Forms.Padding(4);
            this.TLGUsersMessages.Multiline = true;
            this.TLGUsersMessages.Name = "TLGUsersMessages";
            this.TLGUsersMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TLGUsersMessages.Size = new System.Drawing.Size(457, 497);
            this.TLGUsersMessages.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 413);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(392, 28);
            this.button3.TabIndex = 67;
            this.button3.Text = "Загрузить датасет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(392, 28);
            this.button2.TabIndex = 66;
            this.button2.Text = "Создать датасет (обработанные изображения)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblEpoch
            // 
            this.lblEpoch.AutoSize = true;
            this.lblEpoch.Location = new System.Drawing.Point(973, 544);
            this.lblEpoch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpoch.Name = "lblEpoch";
            this.lblEpoch.Size = new System.Drawing.Size(47, 17);
            this.lblEpoch.TabIndex = 65;
            this.lblEpoch.Text = "Эпоха";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(726, 470);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(46, 17);
            this.status.TabIndex = 64;
            this.status.Text = "status";
            // 
            // elapsedTimeLabel
            // 
            this.elapsedTimeLabel.AutoSize = true;
            this.elapsedTimeLabel.Location = new System.Drawing.Point(665, 544);
            this.elapsedTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elapsedTimeLabel.Name = "elapsedTimeLabel";
            this.elapsedTimeLabel.Size = new System.Drawing.Size(54, 17);
            this.elapsedTimeLabel.TabIndex = 62;
            this.elapsedTimeLabel.Text = "Время:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(666, 513);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(388, 27);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.netTypeBox);
            this.groupBox1.Controls.Add(this.parallelCheckBox);
            this.groupBox1.Controls.Add(this.netStructureBox);
            this.groupBox1.Controls.Add(this.recreateNetButton);
            this.groupBox1.Controls.Add(this.AccuracyCounter);
            this.groupBox1.Controls.Add(label12);
            this.groupBox1.Controls.Add(this.EpochesCounter);
            this.groupBox1.Controls.Add(label13);
            this.groupBox1.Controls.Add(label15);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button_train);
            this.groupBox1.Location = new System.Drawing.Point(658, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(409, 327);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сети";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 27);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Сеть";
            // 
            // netTypeBox
            // 
            this.netTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.netTypeBox.FormattingEnabled = true;
            this.netTypeBox.Items.AddRange(new object[] {
            "Hand Crafted Perseptron",
            "Accord.Net Perseptron"});
            this.netTypeBox.Location = new System.Drawing.Point(240, 23);
            this.netTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.netTypeBox.Name = "netTypeBox";
            this.netTypeBox.Size = new System.Drawing.Size(160, 24);
            this.netTypeBox.TabIndex = 20;
            // 
            // parallelCheckBox
            // 
            this.parallelCheckBox.AutoSize = true;
            this.parallelCheckBox.Checked = true;
            this.parallelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.parallelCheckBox.Location = new System.Drawing.Point(13, 244);
            this.parallelCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.parallelCheckBox.Name = "parallelCheckBox";
            this.parallelCheckBox.Size = new System.Drawing.Size(179, 21);
            this.parallelCheckBox.TabIndex = 19;
            this.parallelCheckBox.Text = "Параллельный расчёт";
            this.parallelCheckBox.UseVisualStyleBackColor = true;
            // 
            // netStructureBox
            // 
            this.netStructureBox.Location = new System.Drawing.Point(241, 54);
            this.netStructureBox.Margin = new System.Windows.Forms.Padding(4);
            this.netStructureBox.Name = "netStructureBox";
            this.netStructureBox.Size = new System.Drawing.Size(159, 22);
            this.netStructureBox.TabIndex = 18;
            this.netStructureBox.Text = "784;256;512;128;10";
            // 
            // recreateNetButton
            // 
            this.recreateNetButton.Location = new System.Drawing.Point(117, 130);
            this.recreateNetButton.Margin = new System.Windows.Forms.Padding(4);
            this.recreateNetButton.Name = "recreateNetButton";
            this.recreateNetButton.Size = new System.Drawing.Size(187, 37);
            this.recreateNetButton.TabIndex = 17;
            this.recreateNetButton.Text = "Пересоздать сеть";
            this.recreateNetButton.UseVisualStyleBackColor = true;
            this.recreateNetButton.Click += new System.EventHandler(this.recreateNetButton_Click);
            // 
            // AccuracyCounter
            // 
            this.AccuracyCounter.Location = new System.Drawing.Point(8, 209);
            this.AccuracyCounter.Margin = new System.Windows.Forms.Padding(4);
            this.AccuracyCounter.Maximum = 100;
            this.AccuracyCounter.Name = "AccuracyCounter";
            this.AccuracyCounter.Size = new System.Drawing.Size(368, 56);
            this.AccuracyCounter.TabIndex = 10;
            this.AccuracyCounter.TickFrequency = 10;
            this.AccuracyCounter.Value = 100;
            // 
            // EpochesCounter
            // 
            this.EpochesCounter.Location = new System.Drawing.Point(240, 91);
            this.EpochesCounter.Margin = new System.Windows.Forms.Padding(4);
            this.EpochesCounter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.EpochesCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EpochesCounter.Name = "EpochesCounter";
            this.EpochesCounter.Size = new System.Drawing.Size(160, 22);
            this.EpochesCounter.TabIndex = 8;
            this.EpochesCounter.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 286);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 34);
            this.button4.TabIndex = 37;
            this.button4.Text = "Тестировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_train
            // 
            this.button_train.Location = new System.Drawing.Point(32, 286);
            this.button_train.Margin = new System.Windows.Forms.Padding(4);
            this.button_train.Name = "button_train";
            this.button_train.Size = new System.Drawing.Size(133, 34);
            this.button_train.TabIndex = 36;
            this.button_train.Text = "Тренировать";
            this.button_train.UseVisualStyleBackColor = true;
            this.button_train.Click += new System.EventHandler(this.button_train_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 666);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblEpoch);
            this.Controls.Add(this.status);
            this.Controls.Add(label7);
            this.Controls.Add(this.elapsedTimeLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Банальный студенческий перспетрон";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochesCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel infoStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem вапрвапрToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AIMLOutput;
        private System.Windows.Forms.TextBox AIMLInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button TLGBotOnButton;
        private System.Windows.Forms.TextBox TLGUsersMessages;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEpoch;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label elapsedTimeLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox netTypeBox;
        private System.Windows.Forms.CheckBox parallelCheckBox;
        private System.Windows.Forms.TextBox netStructureBox;
        private System.Windows.Forms.Button recreateNetButton;
        private System.Windows.Forms.TrackBar AccuracyCounter;
        private System.Windows.Forms.NumericUpDown EpochesCounter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_train;
    }
}

