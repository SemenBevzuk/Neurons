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
            this.PrevImage = new System.Windows.Forms.Button();
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
            // LoadNet
            // 
            this.LoadNet.Location = new System.Drawing.Point(501, 24);
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
            this.label1.Location = new System.Drawing.Point(1010, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ответ сети:";
            // 
            // NetAnswer
            // 
            this.NetAnswer.Location = new System.Drawing.Point(1113, 159);
            this.NetAnswer.Name = "NetAnswer";
            this.NetAnswer.Size = new System.Drawing.Size(55, 26);
            this.NetAnswer.TabIndex = 9;
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.Location = new System.Drawing.Point(1051, 260);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(59, 26);
            this.CurrentNumber.TabIndex = 8;
            // 
            // StartLearning
            // 
            this.StartLearning.Location = new System.Drawing.Point(283, 24);
            this.StartLearning.Name = "StartLearning";
            this.StartLearning.Size = new System.Drawing.Size(159, 55);
            this.StartLearning.TabIndex = 7;
            this.StartLearning.Text = "Обучить сеть";
            this.StartLearning.UseVisualStyleBackColor = true;
            this.StartLearning.Click += new System.EventHandler(this.StartLearning_Click);
            // 
            // SaveNetwork
            // 
            this.SaveNetwork.Location = new System.Drawing.Point(174, 349);
            this.SaveNetwork.Name = "SaveNetwork";
            this.SaveNetwork.Size = new System.Drawing.Size(137, 42);
            this.SaveNetwork.TabIndex = 6;
            this.SaveNetwork.Text = "Сохранить сеть";
            this.SaveNetwork.UseVisualStyleBackColor = true;
            this.SaveNetwork.Click += new System.EventHandler(this.SaveNetwork_Click);
            // 
            // NextImage
            // 
            this.NextImage.Location = new System.Drawing.Point(1152, 246);
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
            this.pictureBoxNumber.Location = new System.Drawing.Point(1186, 132);
            this.pictureBoxNumber.Name = "pictureBoxNumber";
            this.pictureBoxNumber.Size = new System.Drawing.Size(80, 83);
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
            this.downloadTests.Location = new System.Drawing.Point(1051, 15);
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
            // PrevImage
            // 
            this.PrevImage.Location = new System.Drawing.Point(1152, 320);
            this.PrevImage.Name = "PrevImage";
            this.PrevImage.Size = new System.Drawing.Size(114, 55);
            this.PrevImage.TabIndex = 12;
            this.PrevImage.Text = " Предыдущий";
            this.PrevImage.UseVisualStyleBackColor = false;
            this.PrevImage.Click += new System.EventHandler(this.PrevImage_Click);
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
    }
}

