﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Neuro_test;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly LearningViewModel learningViewModel;
        private readonly RecognitionViewModel recognitionViewModel;
        private readonly MultilayerNetworkViewModel multilayerNetworkViewModel;

        public Form1()
        {
            learningViewModel = new LearningViewModel();
            recognitionViewModel = new RecognitionViewModel();
            multilayerNetworkViewModel = new MultilayerNetworkViewModel();
            InitializeComponent();

            BackgroundWorker.DoWork += (o, args) =>
            {
                learningViewModel.AutoTraining(o as BackgroundWorker);
            };
            BackgroundWorker.ProgressChanged += (o, args) =>
            {
                LabelProgressBar.Text = args.ProgressPercentage.ToString()+"%";
                ProgressBar.Value = args.ProgressPercentage;
            };
            BackgroundWorker.RunWorkerCompleted += (o, args) =>
            {
                LearningViewModelBind();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            learningViewModel.Neuron = new Neuron(3, 5, learningViewModel.Input, "5");
            for (int i = 0; i < 10; i++)
            {
                recognitionViewModel.Web[i] = new Neuron(3, 5, learningViewModel.Input, i.ToString());
            }
            LearningViewModelBind();

            //загрузка многослойной сети
        }

        // отображение данных из вьюмодели
        private void RecognitionViewModelBind()
        {
            OperatingInfoBox.Items.Clear();
            OperatingInfoBox.Items.AddRange(recognitionViewModel.OperatingBox.ToArray());
            AnswerBox.Items.Clear();
            AnswerBox.Items.AddRange(recognitionViewModel.ResultBox.ToArray());
            OperatingImgBox.Image = Image.FromFile(recognitionViewModel.Path);
        }

        private void LearningViewModelBind()
        {
            InfoBox.Items.Clear();
            InfoBox.Items.AddRange(learningViewModel.InfoBox.ToArray());
            FileInfo.Items.Clear();
            FileInfo.Items.AddRange(learningViewModel.FileBox.ToArray());
            PictureBox.Image = Image.FromFile(learningViewModel.Path);
            IndicatorRecognition.Image = Image.FromFile(learningViewModel.IndicatorPath);
        }
        private void UpdateViewNetLable()
        {
            multilayerNetworkViewModel.UpdateViewNet();
            textBox1.Text = multilayerNetworkViewModel.Outputs[0].ToString();
            textBox2.Text = multilayerNetworkViewModel.Outputs[1].ToString();
            textBox3.Text = multilayerNetworkViewModel.Outputs[2].ToString();
            textBox4.Text = multilayerNetworkViewModel.Outputs[3].ToString();
            textBox5.Text = multilayerNetworkViewModel.Outputs[4].ToString();
            textBox6.Text = multilayerNetworkViewModel.Outputs[5].ToString();
            textBox7.Text = multilayerNetworkViewModel.Outputs[6].ToString();
            textBox8.Text = multilayerNetworkViewModel.Outputs[7].ToString();
            textBox9.Text = multilayerNetworkViewModel.Outputs[8].ToString();
            textBox10.Text = multilayerNetworkViewModel.Outputs[9].ToString();
            textBox11.Text = multilayerNetworkViewModel.Outputs[10].ToString();
            textBox12.Text = multilayerNetworkViewModel.Outputs[11].ToString();
            textBox13.Text = multilayerNetworkViewModel.Outputs[12].ToString();
            textBox14.Text = multilayerNetworkViewModel.Outputs[13].ToString();
            textBox15.Text = multilayerNetworkViewModel.Outputs[14].ToString();
            textBox16.Text = multilayerNetworkViewModel.Outputs[15].ToString();
            textBox17.Text = multilayerNetworkViewModel.Outputs[16].ToString();
            textBox18.Text = multilayerNetworkViewModel.Outputs[17].ToString();
            textBox19.Text = multilayerNetworkViewModel.Outputs[18].ToString();
            textBox20.Text = multilayerNetworkViewModel.Outputs[19].ToString();
            textBox21.Text = multilayerNetworkViewModel.Outputs[20].ToString();
            textBox22.Text = multilayerNetworkViewModel.Outputs[21].ToString();
            textBox23.Text = multilayerNetworkViewModel.Outputs[22].ToString();
            textBox24.Text = multilayerNetworkViewModel.Outputs[23].ToString();
            textBox25.Text = multilayerNetworkViewModel.Outputs[24].ToString();
            textBox26.Text = multilayerNetworkViewModel.Outputs[25].ToString();
            textBox27.Text = multilayerNetworkViewModel.Outputs[26].ToString();
            textBox28.Text = multilayerNetworkViewModel.Outputs[27].ToString();
            textBox29.Text = multilayerNetworkViewModel.Outputs[28].ToString();
            textBox30.Text = multilayerNetworkViewModel.Outputs[29].ToString();
        }

        private void MultilayerNetworkViewModelBind()
        {
            InfoBoxLearningMultilayer.Items.Clear();
            InfoBoxLearningMultilayer.Items.AddRange(multilayerNetworkViewModel.InfoMultilayer.ToArray());
            pictureBoxNumber.Image = multilayerNetworkViewModel.CurrentBitmap;
            NetAnswer.Text = multilayerNetworkViewModel.NetAnswer.ToString();
            MNISTanswer.Text = multilayerNetworkViewModel.MNISTAnswer.ToString();
            CurrentNumber.Text = multilayerNetworkViewModel.CurrentImage.ToString();
        }

        private void incorrect_Click(object sender, EventArgs e)
        {
            // ErrorButton.Enabled = false;
            learningViewModel.IncorrectRecognition();
            LearningViewModelBind();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //ErrorButton.Enabled = true;
            learningViewModel.Next();
            LearningViewModelBind();
        }


        private void PrevButton_Click(object sender, EventArgs e)
        {
            //ErrorButton.Enabled = true;
            learningViewModel.Previous();
            LearningViewModelBind();
        }
        private void CleanFile_Click(object sender, EventArgs e)
        {
            learningViewModel.CleanFile();
            LearningViewModelBind();
        }

        private void current_neuron_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            learningViewModel.CurrentNeuronChanged(current_neuron_box.Text);
            LearningViewModelBind();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Укажите тестируемый файл";
            openFileDialog1.ShowDialog();

            recognitionViewModel.RecognizeSymbolFromFile(openFileDialog1.FileName);

            RecognitionViewModelBind();
        }

        private void AutoTrainingButton_Click(object sender, EventArgs e)
        {
            BackgroundWorker.RunWorkerAsync(); //поток
        }

        private void CleanAllFiles_Click(object sender, EventArgs e)
        {
            learningViewModel.CleanAllFiles();
            LearningViewModelBind();
        }

        private void downloadLearning_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.LoadLearningData();
            MultilayerNetworkViewModelBind();
        }

        private void SaveNetwork_Click(object sender, EventArgs e)
        {
            var dialog_res = saveFileDialog1.ShowDialog();
            if (dialog_res == DialogResult.OK)
            {
                multilayerNetworkViewModel.SaveNetwork(saveFileDialog1.FileName);
            }
           
            MultilayerNetworkViewModelBind();
        }

        private void StartLearning_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.TrainNetwork();
            multilayerNetworkViewModel.SaveNetwork("autosave.txt");
            MultilayerNetworkViewModelBind();
        }

        private void downloadTests_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.LoadTestingData();
            multilayerNetworkViewModel.LoadBitmap();
            multilayerNetworkViewModel.GetAnswer();
            MultilayerNetworkViewModelBind();
        }

        private void NextImage_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.NextBitmap();
            multilayerNetworkViewModel.GetAnswer();
            MultilayerNetworkViewModelBind();
            UpdateViewNetLable();
        }

        private void LoadNet_Click(object sender, EventArgs e)
        {
            var dialog_res = openFileDialog1.ShowDialog();
            if (dialog_res == DialogResult.OK)
            {
                multilayerNetworkViewModel.LoadNetwork(openFileDialog1.FileName);
            }
            MultilayerNetworkViewModelBind();
        }

        private void PrevImage_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.PrevBitmap();
            multilayerNetworkViewModel.GetAnswer();
            MultilayerNetworkViewModelBind();
            UpdateViewNetLable();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonTestNet_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.TestNet(200);
            MultilayerNetworkViewModelBind();
        }

        private void buttonTestTrainNet_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.TestTrainNet(200);//1000
            MultilayerNetworkViewModelBind();
        }
    }
}