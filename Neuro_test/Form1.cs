using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Neuro_test;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private readonly ViewModel viewModel;

        public Form1()
        {
            viewModel = new ViewModel();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewModel.Homer = new Neuron(3, 5, viewModel.Input, "5");
            Bind();
        }

        // отображение данных из вьюмодели
        private void Bind()
        {
            InfoBox.Items.Clear();
            InfoBox.Items.AddRange(viewModel.InfoBox.ToArray());
            PictureBox.Image = Image.FromFile(viewModel.Path);
        }

        private void incorrect_Click(object sender, EventArgs e)
        {
            ErrorButton.Enabled = false;

            if (viewModel.Homer.Rez() == false)
                viewModel.Homer.incW(viewModel.Input);
            else viewModel.Homer.decW(viewModel.Input);

            //Запись
            var s = "";
            var s1 = new string[5];
            File.Delete(viewModel.CurrentFile);
            var FS = new FileStream(viewModel.CurrentFile, FileMode.OpenOrCreate);
            var SW = new StreamWriter(FS);

            for (var y = 0; y <= 4; y++)
            {
                s = Convert.ToString(viewModel.Homer.weight[0, y]) +
                    " " + Convert.ToString(viewModel.Homer.weight[1, y]) +
                    " " + Convert.ToString(viewModel.Homer.weight[2, y]);
                s1[y] = s;

                SW.WriteLine(s);
            }
            SW.Close();

            InfoBox.Items.Clear();
            ErrorButton.Enabled = true;
            var way = "../../samples/" + Convert.ToString(viewModel.ImageCounter) + ".bmp";
            PictureBox.Image = Image.FromFile(way);
            var im = PictureBox.Image as Bitmap;
            for (var i = 0; i <= 5; i++) InfoBox.Items.Add(" ");

            for (var x = 0; x <= 2; x++)
            {
                for (var y = 0; y <= 4; y++)
                {
                    int n = (im.GetPixel(x, y).R);
                    if (n >= 250) n = 0;
                    else n = 1;
                    InfoBox.Items[y] = InfoBox.Items[y] + "  " + Convert.ToString(n);
                    viewModel.Input[x, y] = n;
                }
            }
            ShowFileInfo(viewModel.CurrentFile);
            viewModel.Recognize();
            Bind();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ErrorButton.Enabled = true;
            viewModel.Next();
            ShowFileInfo(viewModel.CurrentFile);
            Bind();
        }


        private void PrevButton_Click(object sender, EventArgs e)
        {
            ErrorButton.Enabled = true;
            viewModel.Previous();
            ShowFileInfo(viewModel.CurrentFile);
            Bind();
        }

        private void ShowFileInfo(string s)
        {
            FileInfo.Items.Clear();
            var sr = File.OpenText(s);
            string line;
            string[] s1;
            var k = 0;
            while ((line = sr.ReadLine()) != null)
            {
                s1 = line.Split(' ');
                for (var i = 0; i < s1.Length; i++)
                {
                    FileInfo.Items.Add("");
                    if (k < 5)
                    {
                        FileInfo.Items[k] += s1[i] + " ";
                    }
                }
                k++;
            }
            sr.Close();
        }

        private void CleanFile_Click(object sender, EventArgs e)
        {
            var s = "";
            var s1 = new string[5];
            File.Delete(viewModel.CurrentFile);
            var FS = new FileStream(viewModel.CurrentFile, FileMode.OpenOrCreate);
            var SW = new StreamWriter(FS);
            for (var i = 0; i < 5; i++)
            {
                s = Convert.ToString(0) +
                    " " + Convert.ToString(0) +
                    " " + Convert.ToString(0);
                SW.WriteLine(s);
            }
            SW.Close();
            InfoBox.Items.Clear();
            InfoBox.Items.Add("Память очищена.");
            ShowFileInfo(viewModel.CurrentFile);
        }

        private void current_neuron_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            //current_neuron_box
            viewModel.Homer = new Neuron(3, 5, viewModel.Input, current_neuron_box.Text);
            InfoBox.Items.Clear();
            viewModel.ImageCounter = -1;
            var s = current_neuron_box.Text + ".txt";
            viewModel.CurrentFile = s;
            var sr = File.OpenText(s);
            string line;
            string[] s1;
            var k = 0;
            while ((line = sr.ReadLine()) != null)
            {
                s1 = line.Split(' ');
                for (var i = 0; i < s1.Length; i++)
                {
                    InfoBox.Items.Add("");
                    if (k < 5)
                    {
                        viewModel.Homer.weight[i, k] = Convert.ToInt32(s1[i]);
                    }
                }
                k++;
            }
            sr.Close();
            ShowFileInfo(s);
        }
    }
}