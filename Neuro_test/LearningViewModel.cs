using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

// using System.Windows.Forms;

namespace Neuro_test
{
    public class LearningViewModel
    {
        public string CurrentFile;
        public Neuron Homer;
        public int ImageCounter = -1;
        public List<string> InfoBox = new List<string>();
        public List<string> FileBox = new List<string>();
        public int[,] Input = new int[3, 5];
        public string Path = "../../samples/" + "0.bmp";

        public void Recognize()
        {
            Homer.mul_w();
            Homer.Sum();
            if (Homer.Rez())
                InfoBox.Add(" - True, Sum = " + Convert.ToString(Homer.sum));
            else
                InfoBox.Add(" - False, Sum = " + Convert.ToString(Homer.sum));

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
            if (Homer.Rez() == false)
                Homer.incW(Input);
            else Homer.decW(Input);

            //Запись
            var s = "";
            var s1 = new string[5];
            File.Delete(CurrentFile);
            var FS = new FileStream(CurrentFile, FileMode.OpenOrCreate);
            var SW = new StreamWriter(FS);

            for (var y = 0; y <= 4; y++)
            {
                s = Convert.ToString(Homer.weight[0, y]) +
                    " " + Convert.ToString(Homer.weight[1, y]) +
                    " " + Convert.ToString(Homer.weight[2, y]);
                s1[y] = s;

                SW.WriteLine(s);
            }
            SW.Close();

            //ErrorButton.Enabled = true;
            UpdateInfoBox();
            UpdateFileBox();
        }

        public void CleanFile()
        {
            var s = "";
            var s1 = new string[5];
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

        public  void CurrentNeuronChanged(string new_name)
        {
            Homer = new Neuron(3, 5, Input, new_name);
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
                        Homer.weight[i, k] = Convert.ToInt32(s1[i]);
                    }
                }
                k++;
            }
            sr.Close();
            UpdateFileBox();
        }
    }
}