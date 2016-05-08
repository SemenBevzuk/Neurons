namespace WindowsFormsApplication1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.ErrorButton = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.ListBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.CleanFile = new System.Windows.Forms.Button();
            this.FileInfo = new System.Windows.Forms.ListBox();
            this.LableFileInfo = new System.Windows.Forms.Label();
            this.current_neuron_box = new System.Windows.Forms.ComboBox();
            this.CurNeuroLable = new System.Windows.Forms.Label();
            this.ModeLable = new System.Windows.Forms.Label();
            this.ImgLable = new System.Windows.Forms.Label();
            this.TypeControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LabelProgressBar = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CleanAllFiles = new System.Windows.Forms.Button();
            this.AutoTrainingButton = new System.Windows.Forms.Button();
            this.IndicatorRecognition = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.ListBox();
            this.OperatingInfoBox = new System.Windows.Forms.ListBox();
            this.OperatingImgBox = new System.Windows.Forms.PictureBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PrevImage = new System.Windows.Forms.Button();
            this.LoadNet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NetAnswer = new System.Windows.Forms.TextBox();
            this.CurrentNumber = new System.Windows.Forms.TextBox();
            this.StartLearning = new System.Windows.Forms.Button();
            this.SaveNetwork = new System.Windows.Forms.Button();
            this.NextImage = new System.Windows.Forms.Button();
            this.InfoBoxLearningMultilayer = new System.Windows.Forms.ListBox();
            this.pictureBoxNumber = new System.Windows.Forms.PictureBox();
            this.downloadLearning = new System.Windows.Forms.Button();
            this.downloadTests = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TypeControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorRecognition)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperatingImgBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(74, 131);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(127, 138);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(270, 411);
            this.ErrorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(112, 35);
            this.ErrorButton.TabIndex = 2;
            this.ErrorButton.Text = "Не верно";
            this.ErrorButton.UseVisualStyleBackColor = true;
            this.ErrorButton.Click += new System.EventHandler(this.incorrect_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.FormattingEnabled = true;
            this.InfoBox.HorizontalScrollbar = true;
            this.InfoBox.ItemHeight = 20;
            this.InfoBox.Location = new System.Drawing.Point(237, 95);
            this.InfoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(178, 244);
            this.InfoBox.TabIndex = 5;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(337, 347);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(78, 43);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(237, 347);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(79, 43);
            this.PrevButton.TabIndex = 7;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // CleanFile
            // 
            this.CleanFile.ForeColor = System.Drawing.Color.Red;
            this.CleanFile.Location = new System.Drawing.Point(38, 368);
            this.CleanFile.Name = "CleanFile";
            this.CleanFile.Size = new System.Drawing.Size(193, 78);
            this.CleanFile.TabIndex = 8;
            this.CleanFile.Text = "Очистить память текущего нейрона";
            this.CleanFile.UseVisualStyleBackColor = true;
            this.CleanFile.Click += new System.EventHandler(this.CleanFile_Click);
            // 
            // FileInfo
            // 
            this.FileInfo.FormattingEnabled = true;
            this.FileInfo.HorizontalScrollbar = true;
            this.FileInfo.ItemHeight = 20;
            this.FileInfo.Location = new System.Drawing.Point(442, 95);
            this.FileInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileInfo.Name = "FileInfo";
            this.FileInfo.Size = new System.Drawing.Size(178, 244);
            this.FileInfo.TabIndex = 9;
            // 
            // LableFileInfo
            // 
            this.LableFileInfo.AutoSize = true;
            this.LableFileInfo.Location = new System.Drawing.Point(443, 70);
            this.LableFileInfo.Name = "LableFileInfo";
            this.LableFileInfo.Size = new System.Drawing.Size(165, 20);
            this.LableFileInfo.TabIndex = 10;
            this.LableFileInfo.Text = "Содержание памяти";
            this.LableFileInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // current_neuron_box
            // 
            this.current_neuron_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.current_neuron_box.FormattingEnabled = true;
            this.current_neuron_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.current_neuron_box.Location = new System.Drawing.Point(74, 95);
            this.current_neuron_box.Name = "current_neuron_box";
            this.current_neuron_box.Size = new System.Drawing.Size(127, 28);
            this.current_neuron_box.TabIndex = 11;
            this.current_neuron_box.SelectedIndexChanged += new System.EventHandler(this.current_neuron_box_SelectedIndexChanged);
            // 
            // CurNeuroLable
            // 
            this.CurNeuroLable.AutoSize = true;
            this.CurNeuroLable.Location = new System.Drawing.Point(79, 70);
            this.CurNeuroLable.Name = "CurNeuroLable";
            this.CurNeuroLable.Size = new System.Drawing.Size(131, 20);
            this.CurNeuroLable.TabIndex = 12;
            this.CurNeuroLable.Text = "Текущий нейрон";
            this.CurNeuroLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModeLable
            // 
            this.ModeLable.AutoSize = true;
            this.ModeLable.Location = new System.Drawing.Point(259, 18);
            this.ModeLable.Name = "ModeLable";
            this.ModeLable.Size = new System.Drawing.Size(137, 20);
            this.ModeLable.TabIndex = 13;
            this.ModeLable.Text = "Режим обучения.";
            // 
            // ImgLable
            // 
            this.ImgLable.AutoSize = true;
            this.ImgLable.Location = new System.Drawing.Point(259, 70);
            this.ImgLable.Name = "ImgLable";
            this.ImgLable.Size = new System.Drawing.Size(134, 20);
            this.ImgLable.TabIndex = 14;
            this.ImgLable.Text = "Данные образца";
            this.ImgLable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TypeControl
            // 
            this.TypeControl.Controls.Add(this.tabPage1);
            this.TypeControl.Controls.Add(this.tabPage2);
            this.TypeControl.Controls.Add(this.tabPage3);
            this.TypeControl.Location = new System.Drawing.Point(2, 3);
            this.TypeControl.Name = "TypeControl";
            this.TypeControl.SelectedIndex = 0;
            this.TypeControl.Size = new System.Drawing.Size(1470, 787);
            this.TypeControl.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LabelProgressBar);
            this.tabPage1.Controls.Add(this.ProgressBar);
            this.tabPage1.Controls.Add(this.CleanAllFiles);
            this.tabPage1.Controls.Add(this.AutoTrainingButton);
            this.tabPage1.Controls.Add(this.IndicatorRecognition);
            this.tabPage1.Controls.Add(this.FileInfo);
            this.tabPage1.Controls.Add(this.ModeLable);
            this.tabPage1.Controls.Add(this.ImgLable);
            this.tabPage1.Controls.Add(this.PictureBox);
            this.tabPage1.Controls.Add(this.ErrorButton);
            this.tabPage1.Controls.Add(this.CurNeuroLable);
            this.tabPage1.Controls.Add(this.InfoBox);
            this.tabPage1.Controls.Add(this.current_neuron_box);
            this.tabPage1.Controls.Add(this.NextButton);
            this.tabPage1.Controls.Add(this.LableFileInfo);
            this.tabPage1.Controls.Add(this.PrevButton);
            this.tabPage1.Controls.Add(this.CleanFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1462, 754);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Режим обучения однослойной сети";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LabelProgressBar
            // 
            this.LabelProgressBar.AutoSize = true;
            this.LabelProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.LabelProgressBar.Location = new System.Drawing.Point(321, 603);
            this.LabelProgressBar.Name = "LabelProgressBar";
            this.LabelProgressBar.Size = new System.Drawing.Size(0, 20);
            this.LabelProgressBar.TabIndex = 19;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(79, 588);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(540, 53);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 18;
            // 
            // CleanAllFiles
            // 
            this.CleanAllFiles.ForeColor = System.Drawing.Color.Red;
            this.CleanAllFiles.Location = new System.Drawing.Point(38, 456);
            this.CleanAllFiles.Name = "CleanAllFiles";
            this.CleanAllFiles.Size = new System.Drawing.Size(193, 78);
            this.CleanAllFiles.TabIndex = 17;
            this.CleanAllFiles.Text = "Очистить память текущей сети";
            this.CleanAllFiles.UseVisualStyleBackColor = true;
            this.CleanAllFiles.Click += new System.EventHandler(this.CleanAllFiles_Click);
            // 
            // AutoTrainingButton
            // 
            this.AutoTrainingButton.Location = new System.Drawing.Point(448, 364);
            this.AutoTrainingButton.Name = "AutoTrainingButton";
            this.AutoTrainingButton.Size = new System.Drawing.Size(171, 81);
            this.AutoTrainingButton.TabIndex = 16;
            this.AutoTrainingButton.Text = "Автоматическое обучение сети";
            this.AutoTrainingButton.UseVisualStyleBackColor = true;
            this.AutoTrainingButton.Click += new System.EventHandler(this.AutoTrainingButton_Click);
            // 
            // IndicatorRecognition
            // 
            this.IndicatorRecognition.Location = new System.Drawing.Point(83, 277);
            this.IndicatorRecognition.Name = "IndicatorRecognition";
            this.IndicatorRecognition.Size = new System.Drawing.Size(105, 85);
            this.IndicatorRecognition.TabIndex = 15;
            this.IndicatorRecognition.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TitleLabel);
            this.tabPage2.Controls.Add(this.AnswerBox);
            this.tabPage2.Controls.Add(this.OperatingInfoBox);
            this.tabPage2.Controls.Add(this.OperatingImgBox);
            this.tabPage2.Controls.Add(this.SelectButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1462, 754);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Режим распознавания однослойной сети";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(249, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(182, 20);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Режим распознавания.";
            // 
            // AnswerBox
            // 
            this.AnswerBox.FormattingEnabled = true;
            this.AnswerBox.ItemHeight = 20;
            this.AnswerBox.Location = new System.Drawing.Point(195, 298);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(430, 224);
            this.AnswerBox.TabIndex = 7;
            // 
            // OperatingInfoBox
            // 
            this.OperatingInfoBox.FormattingEnabled = true;
            this.OperatingInfoBox.HorizontalScrollbar = true;
            this.OperatingInfoBox.ItemHeight = 20;
            this.OperatingInfoBox.Location = new System.Drawing.Point(195, 66);
            this.OperatingInfoBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OperatingInfoBox.Name = "OperatingInfoBox";
            this.OperatingInfoBox.Size = new System.Drawing.Size(430, 224);
            this.OperatingInfoBox.TabIndex = 6;
            // 
            // OperatingImgBox
            // 
            this.OperatingImgBox.Location = new System.Drawing.Point(42, 234);
            this.OperatingImgBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OperatingImgBox.Name = "OperatingImgBox";
            this.OperatingImgBox.Size = new System.Drawing.Size(105, 138);
            this.OperatingImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OperatingImgBox.TabIndex = 1;
            this.OperatingImgBox.TabStop = false;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(42, 120);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(112, 55);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Выбрать файл";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox30);
            this.tabPage3.Controls.Add(this.textBox29);
            this.tabPage3.Controls.Add(this.textBox28);
            this.tabPage3.Controls.Add(this.textBox27);
            this.tabPage3.Controls.Add(this.textBox26);
            this.tabPage3.Controls.Add(this.textBox25);
            this.tabPage3.Controls.Add(this.textBox24);
            this.tabPage3.Controls.Add(this.textBox23);
            this.tabPage3.Controls.Add(this.textBox22);
            this.tabPage3.Controls.Add(this.textBox21);
            this.tabPage3.Controls.Add(this.textBox20);
            this.tabPage3.Controls.Add(this.textBox19);
            this.tabPage3.Controls.Add(this.textBox18);
            this.tabPage3.Controls.Add(this.textBox17);
            this.tabPage3.Controls.Add(this.textBox16);
            this.tabPage3.Controls.Add(this.textBox15);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.PrevImage);
            this.tabPage3.Controls.Add(this.LoadNet);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.NetAnswer);
            this.tabPage3.Controls.Add(this.CurrentNumber);
            this.tabPage3.Controls.Add(this.StartLearning);
            this.tabPage3.Controls.Add(this.SaveNetwork);
            this.tabPage3.Controls.Add(this.NextImage);
            this.tabPage3.Controls.Add(this.InfoBoxLearningMultilayer);
            this.tabPage3.Controls.Add(this.pictureBoxNumber);
            this.tabPage3.Controls.Add(this.downloadLearning);
            this.tabPage3.Controls.Add(this.downloadTests);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1462, 754);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Многослойная сеть";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1054, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Выходы выходного слоя";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Выходы скрытого слоя";
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(1086, 486);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(158, 26);
            this.textBox30.TabIndex = 42;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(1086, 454);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(158, 26);
            this.textBox29.TabIndex = 41;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(1086, 422);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(158, 26);
            this.textBox28.TabIndex = 40;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(1086, 390);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(158, 26);
            this.textBox27.TabIndex = 39;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(1086, 358);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(158, 26);
            this.textBox26.TabIndex = 38;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(1086, 326);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(158, 26);
            this.textBox25.TabIndex = 37;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(1086, 294);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(158, 26);
            this.textBox24.TabIndex = 36;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(1086, 262);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(158, 26);
            this.textBox23.TabIndex = 35;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(1086, 230);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(158, 26);
            this.textBox22.TabIndex = 34;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(1086, 198);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(158, 26);
            this.textBox21.TabIndex = 33;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(795, 646);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(179, 26);
            this.textBox20.TabIndex = 32;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(795, 614);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(179, 26);
            this.textBox19.TabIndex = 31;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(795, 582);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(179, 26);
            this.textBox18.TabIndex = 30;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(795, 550);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(179, 26);
            this.textBox17.TabIndex = 29;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(795, 518);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(179, 26);
            this.textBox16.TabIndex = 28;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(795, 486);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(179, 26);
            this.textBox15.TabIndex = 27;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(795, 454);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(179, 26);
            this.textBox14.TabIndex = 26;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(795, 422);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(179, 26);
            this.textBox13.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(795, 390);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(179, 26);
            this.textBox12.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(795, 358);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(179, 26);
            this.textBox11.TabIndex = 23;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(795, 326);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(179, 26);
            this.textBox10.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(795, 294);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(179, 26);
            this.textBox9.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(795, 262);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(179, 26);
            this.textBox8.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(795, 230);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(179, 26);
            this.textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(795, 198);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(179, 26);
            this.textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(795, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(179, 26);
            this.textBox5.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(795, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 26);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(795, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 26);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(795, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(795, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 26);
            this.textBox1.TabIndex = 13;
            // 
            // PrevImage
            // 
            this.PrevImage.Location = new System.Drawing.Point(145, 433);
            this.PrevImage.Name = "PrevImage";
            this.PrevImage.Size = new System.Drawing.Size(114, 55);
            this.PrevImage.TabIndex = 12;
            this.PrevImage.Text = " Предыдущий";
            this.PrevImage.UseVisualStyleBackColor = false;
            this.PrevImage.Click += new System.EventHandler(this.PrevImage_Click);
            // 
            // LoadNet
            // 
            this.LoadNet.Location = new System.Drawing.Point(516, 24);
            this.LoadNet.Name = "LoadNet";
            this.LoadNet.Size = new System.Drawing.Size(181, 54);
            this.LoadNet.TabIndex = 11;
            this.LoadNet.Text = "Загрузить сеть";
            this.LoadNet.UseVisualStyleBackColor = true;
            this.LoadNet.Click += new System.EventHandler(this.LoadNet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ответ сети:";
            // 
            // NetAnswer
            // 
            this.NetAnswer.Location = new System.Drawing.Point(407, 406);
            this.NetAnswer.Name = "NetAnswer";
            this.NetAnswer.Size = new System.Drawing.Size(55, 26);
            this.NetAnswer.TabIndex = 9;
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.Location = new System.Drawing.Point(72, 433);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(59, 26);
            this.CurrentNumber.TabIndex = 8;
            // 
            // StartLearning
            // 
            this.StartLearning.Location = new System.Drawing.Point(516, 205);
            this.StartLearning.Name = "StartLearning";
            this.StartLearning.Size = new System.Drawing.Size(181, 59);
            this.StartLearning.TabIndex = 7;
            this.StartLearning.Text = "Обучить сеть";
            this.StartLearning.UseVisualStyleBackColor = true;
            this.StartLearning.Click += new System.EventHandler(this.StartLearning_Click);
            // 
            // SaveNetwork
            // 
            this.SaveNetwork.Location = new System.Drawing.Point(516, 104);
            this.SaveNetwork.Name = "SaveNetwork";
            this.SaveNetwork.Size = new System.Drawing.Size(181, 65);
            this.SaveNetwork.TabIndex = 6;
            this.SaveNetwork.Text = "Сохранить сеть";
            this.SaveNetwork.UseVisualStyleBackColor = true;
            this.SaveNetwork.Click += new System.EventHandler(this.SaveNetwork_Click);
            // 
            // NextImage
            // 
            this.NextImage.Location = new System.Drawing.Point(145, 371);
            this.NextImage.Name = "NextImage";
            this.NextImage.Size = new System.Drawing.Size(114, 55);
            this.NextImage.TabIndex = 5;
            this.NextImage.Text = "Следующий";
            this.NextImage.UseVisualStyleBackColor = true;
            this.NextImage.Click += new System.EventHandler(this.NextImage_Click);
            // 
            // InfoBoxLearningMultilayer
            // 
            this.InfoBoxLearningMultilayer.FormattingEnabled = true;
            this.InfoBoxLearningMultilayer.ItemHeight = 20;
            this.InfoBoxLearningMultilayer.Location = new System.Drawing.Point(44, 117);
            this.InfoBoxLearningMultilayer.Name = "InfoBoxLearningMultilayer";
            this.InfoBoxLearningMultilayer.Size = new System.Drawing.Size(398, 184);
            this.InfoBoxLearningMultilayer.TabIndex = 3;
            // 
            // pictureBoxNumber
            // 
            this.pictureBoxNumber.Location = new System.Drawing.Point(72, 371);
            this.pictureBoxNumber.Name = "pictureBoxNumber";
            this.pictureBoxNumber.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxNumber.TabIndex = 2;
            this.pictureBoxNumber.TabStop = false;
            // 
            // downloadLearning
            // 
            this.downloadLearning.Location = new System.Drawing.Point(44, 24);
            this.downloadLearning.Name = "downloadLearning";
            this.downloadLearning.Size = new System.Drawing.Size(215, 55);
            this.downloadLearning.TabIndex = 1;
            this.downloadLearning.Text = "Загрузить базу для обучения";
            this.downloadLearning.UseVisualStyleBackColor = true;
            this.downloadLearning.Click += new System.EventHandler(this.downloadLearning_Click);
            // 
            // downloadTests
            // 
            this.downloadTests.Location = new System.Drawing.Point(265, 24);
            this.downloadTests.Name = "downloadTests";
            this.downloadTests.Size = new System.Drawing.Size(215, 55);
            this.downloadTests.TabIndex = 0;
            this.downloadTests.Text = "Загрузить тестовую базу";
            this.downloadTests.UseVisualStyleBackColor = true;
            this.downloadTests.Click += new System.EventHandler(this.downloadTests_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1054, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "[0]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1054, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "[1]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1054, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "[2]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1054, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "[3]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1054, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "[4]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1054, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 50;
            this.label9.Text = "[5]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1054, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 51;
            this.label10.Text = "[6]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1054, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "[7]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1054, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 53;
            this.label12.Text = "[8]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1054, 489);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 54;
            this.label13.Text = "[9]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 795);
            this.Controls.Add(this.TypeControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Neuro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.TypeControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorRecognition)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperatingImgBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.ListBox InfoBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button CleanFile;
        private System.Windows.Forms.ListBox FileInfo;
        private System.Windows.Forms.Label LableFileInfo;
        private System.Windows.Forms.ComboBox current_neuron_box;
        private System.Windows.Forms.Label CurNeuroLable;
        private System.Windows.Forms.Label ModeLable;
        private System.Windows.Forms.Label ImgLable;
        private System.Windows.Forms.TabControl TypeControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox OperatingInfoBox;
        private System.Windows.Forms.PictureBox OperatingImgBox;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox AnswerBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox IndicatorRecognition;
        private System.Windows.Forms.Button AutoTrainingButton;
        private System.Windows.Forms.Button CleanAllFiles;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label LabelProgressBar;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button NextImage;
        private System.Windows.Forms.ListBox InfoBoxLearningMultilayer;
        private System.Windows.Forms.PictureBox pictureBoxNumber;
        private System.Windows.Forms.Button downloadLearning;
        private System.Windows.Forms.Button downloadTests;
        private System.Windows.Forms.Button SaveNetwork;
        private System.Windows.Forms.Button StartLearning;
        private System.Windows.Forms.TextBox NetAnswer;
        private System.Windows.Forms.TextBox CurrentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadNet;
        private System.Windows.Forms.Button PrevImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

