using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;

// using System.Windows.Forms;

namespace Neuro_test
{
    public class LearningViewModel
    {
        public string CurrentFile = "0.txt";
        public Neuron Neuron;
        public int ImageCounter = -1;
        public List<string> InfoBox = new List<string>();
        public List<string> FileBox = new List<string>();
        public int[,] Input = new int[3, 5];
        public string Path = "../../samples/" + "0.bmp";
        public string IndicatorPath = "../../true.png";

        public void Recognize()
        {
            Neuron.mul_w();
            Neuron.Sum();
            if (Neuron.Result())
            {
                InfoBox.Add(" - True, Sum = " + Convert.ToString(Neuron.sum));
                IndicatorPath = "../../true.png";
            }
            else
            {
                InfoBox.Add(" - False, Sum = " + Convert.ToString(Neuron.sum));
                IndicatorPath = "../../false.png";
            }

            InfoBox.Add("ImageCounter = " + Convert.ToString(ImageCounter));
        }

        public void Next()
        {
            if (ImageCounter < 9)
            {
                ImageCounter++;
                UpdateInfoBox();
                UpdateFileBox();
            }
        }
        public void Previous()
        {
            if (ImageCounter > 0)
            {
                ImageCounter--;
                UpdateInfoBox();
                UpdateFileBox();
            }
        }

        private void UpdateInfoBox()
        {
            Path = "../../samples/" + Convert.ToString(ImageCounter) + ".bmp";
            var im = Image.FromFile(Path) as Bitmap;


            InfoBox.Clear();
            for (var i = 0; i <= 5; i++)
                InfoBox.Add(" ");
            for (var x = 0; x <= 2; x++)
            {
                for (var y = 0; y <= 4; y++)
                {
                    int n = (im.GetPixel(x, y).R);
                    if (n >= 250) n = 0;
                    else n = 1;
                    InfoBox[y] = InfoBox[y] + "  " + Convert.ToString(n);
                    Input[x, y] = n;
                }
            }
            Recognize();
        }
        private void UpdateFileBox()
        {
            FileBox.Clear();
            var sr = File.OpenText(CurrentFile);
            string line;
            string[] s1;
            var k = 0;
            while ((line = sr.ReadLine()) != null)
            {
                s1 = line.Split(' ');
                for (var i = 0; i < s1.Length; i++)
                {
                    FileBox.Add("");
                    if (k < 5)
                    {
                        FileBox[k] += s1[i] + " ";
                    }
                }
                k++;
            }
            sr.Close();
        }

        public void IncorrectRecognition()
        {
            if (Neuron.Result() == false)
                Neuron.incW(Input);
            else Neuron.decW(Input);

            //Запись
            SaveNeuron();

            //ErrorButton.Enabled = true;
            UpdateInfoBox();
            UpdateFileBox();
        }

        public void CleanFile()
        {
            var s = "";
            File.Delete(CurrentFile);
            var FS = new FileStream(CurrentFile, FileMode.OpenOrCreate);
            var SW = new StreamWriter(FS);
            for (var i = 0; i < 5; i++)
            {
                s = Convert.ToString(0) +
                    " " + Convert.ToString(0) +
                    " " + Convert.ToString(0);
                SW.WriteLine(s);
            }
            SW.Close();
            InfoBox.Clear();
            InfoBox.Add("Память очищена.");
            UpdateFileBox();
        }
        public void CleanAllFiles()
        {
            InfoBox.Clear();
            for (int j = 0; j<10; j++)
            {
                var s = "";
                string filename = j + ".txt";
                File.Delete(filename);
                var FS = new FileStream(filename, FileMode.OpenOrCreate);
                var SW = new StreamWriter(FS);
                for (var i = 0; i < 5; i++)
                {
                    s = Convert.ToString(0) +
                        " " + Convert.ToString(0) +
                        " " + Convert.ToString(0);
                    SW.WriteLine(s);
                }
                SW.Close();
                InfoBox.Add("Память ["+j+"] очищена.");
                UpdateFileBox();
            }
        }
        public  void CurrentNeuronChanged(string new_name)
        {
            Neuron = new Neuron(3, 5, Input, new_name);
            InfoBox.Clear();
            ImageCounter = -1;
            var s = new_name + ".txt";
            CurrentFile = s;
            var sr = File.OpenText(s);
            string line;
            string[] s1;
            var k = 0;
            while ((line = sr.ReadLine()) != null)
            {
                s1 = line.Split(' ');
                for (var i = 0; i < s1.Length; i++)
                {
                    InfoBox.Add("");
                    if (k < 5)
                    {
                        Neuron.weight[i, k] = Convert.ToInt32(s1[i]);
                    }
                }
                k++;
            }
            sr.Close();
            UpdateFileBox();
        }

        private void ReadFile(string filename)
        {
            var s = filename + ".txt";
            CurrentFile = s;
            var sr = File.OpenText(s);
            string line;
            string[] s1;
            var k = 0;
            while ((line = sr.ReadLine()) != null)
            {
                s1 = line.Split(' ');
                for (var i = 0; i < s1.Length; i++)
                {
                    if (k < 5)
                    {
                        Neuron.weight[i, k] = Convert.ToInt32(s1[i]);
                    }
                }
                k++;
            }
            sr.Close();
        }

        private void ReadSample(string filename)
        {
            Path = "../../samples/" + filename + ".bmp";
            var im = Image.FromFile(Path) as Bitmap;
            for (var x = 0; x <= 2; x++)
            {
                for (var y = 0; y <= 4; y++)
                {
                    int n = (im.GetPixel(x, y).R);
                    if (n >= 250) n = 0;
                    else n = 1;
                    Input[x, y] = n;
                }
            }
        }
        private void Learning()
        {
            if (Neuron.Result() == false)
                Neuron.incW(Input);
            else Neuron.decW(Input);
        }

        private void SaveNeuron()
        {
            var s = "";
            var s1 = new string[5];
            File.Delete(CurrentFile);

            using (var FS = new FileStream(CurrentFile, FileMode.Create))
            {
                using (var SW = new StreamWriter(FS))
                {
                    for (var y = 0; y <= 4; y++)
                    {
                        s = Convert.ToString(Neuron.weight[0, y]) +
                            " " + Convert.ToString(Neuron.weight[1, y]) +
                            " " + Convert.ToString(Neuron.weight[2, y]);
                        s1[y] = s;

                        SW.WriteLine(s);
                    }
                }
            }
        }

        private void NeuronTraining()
        {
            bool IsNeuronReady = false;
            while (IsNeuronReady != true)
            {
                bool IsErorrs = false;
                for (int count = 0; count<10; count++)
                {
                    ReadSample(count.ToString());
                    Neuron.input = Input;
                    Neuron.mul_w();
                    Neuron.Sum();
                    if (Neuron.Result() && (Neuron.name != count.ToString()))
                    {
                        IsErorrs = true;
                        Learning();
                    }
                    if (!Neuron.Result() && Neuron.name == count.ToString())
                    {
                        IsErorrs = true;
                        Learning();
                    }
                }
                if (IsErorrs == false)
                {
                    IsNeuronReady = true;
                    SaveNeuron();
                }
            }
            
        }

        public void AutoTraining(BackgroundWorker backgroundWorker)
        {
            for (int i = 0; i < 10; i++)
            {
                ReadFile(i.ToString());
                Neuron.name = i.ToString();
                NeuronTraining();
                backgroundWorker.ReportProgress((i+1)*10);
            }
            InfoBox.Clear();
            InfoBox.Add("Обучение завершено.");
        }
    }
}