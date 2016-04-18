using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Neuro_test;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly LearningViewModel learningViewModel;
        private readonly RecognitionViewModel recognitionViewModel;

        public Form1()
        {
            learningViewModel = new LearningViewModel();
            recognitionViewModel = new RecognitionViewModel();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            learningViewModel.Homer = new Neuron(3, 5, learningViewModel.Input, "5");
            for (int i = 0; i<10; i++)
            {
                recognitionViewModel.Web[i] = new Neuron(3, 5, learningViewModel.Input, i.ToString());
            }
            LearningViewModelBind();
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

            recognitionViewModel.ReadFile(openFileDialog1.FileName);
            recognitionViewModel.RecognizeSymbol();

            RecognitionViewModelBind();
        }
    }
}