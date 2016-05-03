using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Neuro_test
{
    class RecognitionViewModel
    {
        public string CurrentFile;
        public List<string> OperatingBox = new List<string>();
        public List<string> ResultBox = new List<string>();
        public int[,] Input = new int[3, 5];
        public string Path = "../../samples/" + "0.bmp";
        public Neuron[] Web = new Neuron[10];

        public void RecognizeWeb()
        {
            for (int i = 0; i < 10; i++)
            {
                Web[i].mul_w();
                Web[i].Sum();
            }
        }
        private void UpdateOperatingInfoBox()
        {
            var im = Image.FromFile(Path) as Bitmap;

            OperatingBox.Clear();
            for (var i = 0; i <= 5; i++)
                OperatingBox.Add(" ");
            for (var x = 0; x <= 2; x++)
            {
                for (var y = 0; y <= 4; y++)
                {
                    int n = (im.GetPixel(x, y).R);
                    if (n >= 250) n = 0;
                    else n = 1;
                    OperatingBox[y] = OperatingBox[y] + "  " + Convert.ToString(n);
                    Input[x, y] = n;
                }
            }
        }
        private void ReadFile(string fileName)
        {
            Path = fileName;
            UpdateOperatingInfoBox();
            for (int i = 0; i < 10; i++)
            {
                Web[i] = new Neuron(3, 5, Input, i.ToString());
            }
        }

        public void RecognizeSymbolFromFile(string fileName)
        {
            ReadFile(fileName);
            for (int count = 0; count < 10; count++)
            {
                var s = count + ".txt";
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
                            Web[count].weight[i, k] = Convert.ToInt32(s1[i]);
                        }
                    }
                    k++;
                }
                sr.Close();
                OperatingBox.Add("Загружен нейрон [" + count + "]");
            }
            RecognizeWeb();
            ResultBox.Clear();
            for (int i = 0; i < 10; i++)
            {
                if (Web[i].Result())
                    ResultBox.Add("Нейрон [" + i + "] - True");
                else
                    ResultBox.Add("Нейрон [" + i + "] - False");
            }
        }
    }
}
