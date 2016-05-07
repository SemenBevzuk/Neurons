using System;
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
            learningViewModel.Homer = new Neuron(3, 5, learningViewModel.Input, "5");
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

        private void MultilayerNetworkViewModelBind()
        {
            InfoBoxLearningMultilayer.Items.Clear();
            InfoBoxLearningMultilayer.Items.AddRange(multilayerNetworkViewModel.InfoMultilayer.ToArray());
            pictureBoxNumber.Image = multilayerNetworkViewModel.CurrentBitmap;
            NetAnswer.Text = multilayerNetworkViewModel.NetAnswer.ToString();
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
            multilayerNetworkViewModel.SaveNetwork();
            MultilayerNetworkViewModelBind();
        }

        private void StartLearning_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.TrainNetwork();
            multilayerNetworkViewModel.SaveNetwork();
            MultilayerNetworkViewModelBind();
        }

        private void downloadTests_Click(object sender, EventArgs e)
        {
            //multilayerNetworkViewModel.LoadTestingData();
            multilayerNetworkViewModel.LoadLearningData();
            multilayerNetworkViewModel.LoadBitmap();
            multilayerNetworkViewModel.GetAnswer();
            MultilayerNetworkViewModelBind();
        }

        private void NextImage_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.NextBitmap();
            multilayerNetworkViewModel.GetAnswer();
            MultilayerNetworkViewModelBind();
        }

        private void LoadNet_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.LoadNetwork();
            MultilayerNetworkViewModelBind();
        }

        private void PrevImage_Click(object sender, EventArgs e)
        {
            multilayerNetworkViewModel.PrevBitmap();
            multilayerNetworkViewModel.GetAnswer();
            MultilayerNetworkViewModelBind();
        }
    }
}