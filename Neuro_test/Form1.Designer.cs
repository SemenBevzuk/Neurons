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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.TypeControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(94, 152);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(105, 138);
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
            this.CleanFile.Location = new System.Drawing.Point(94, 312);
            this.CleanFile.Name = "CleanFile";
            this.CleanFile.Size = new System.Drawing.Size(105, 78);
            this.CleanFile.TabIndex = 8;
            this.CleanFile.Text = "Очистить память";
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
            this.current_neuron_box.Location = new System.Drawing.Point(83, 95);
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
            this.TypeControl.Location = new System.Drawing.Point(2, 3);
            this.TypeControl.Name = "TypeControl";
            this.TypeControl.SelectedIndex = 0;
            this.TypeControl.Size = new System.Drawing.Size(689, 573);
            this.TypeControl.TabIndex = 15;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(681, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обучение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 576);
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
    }
}

