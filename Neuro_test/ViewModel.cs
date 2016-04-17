using System;
using System.Collections.Generic;
using System.Drawing;
// using System.Windows.Forms;

namespace Neuro_test
{
    public class ViewModel
    {
        public string CurrentFile;
        public Neuron Homer;
        public int ImageCounter = -1;
        public List<string> InfoBox = new List<string>();
        public int[,] Input = new int[3, 5];
        public string Path = "../../samples/" + "0.bmp";

        public void Recognize()
        {
            Homer.mul_w();
            Homer.Sum();
            //InfoBox.Clear();
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
                UpdateInfo();
            }
        }

        public void Previous()
        {
            if (ImageCounter > 0)
            {
                ImageCounter--;
                UpdateInfo();
            }
        }

        private void UpdateInfo()
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
    }
}