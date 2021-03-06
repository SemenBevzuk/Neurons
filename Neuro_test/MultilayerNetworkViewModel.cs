﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neuro_test.TwoLayersNetwork;
using Newtonsoft.Json;

namespace Neuro_test
{
    public class DigitImage
    {
        public int width; // 28
        public int height; // 28
        //public byte[][] pixels; // 0(white) - 255(black)
        public byte[] pixels;
        public byte label; // '0' - '9'

        public DigitImage(int w, int h, byte[][] p, byte l)
        {
            width = w;
            height = h;
            pixels = new byte[width * height];

            int count = 0;
            for (int i = 0; i < height; ++i)
                for (int j = 0; j < width; ++j)
                {
                    pixels[count] = p[i][j];
                    count++;
                }
            label = l;
        }
    }
    class MultilayerNetworkViewModel
    {
        private string pixelFileTrain = "../../samples/MNIST/train-images.idx3-ubyte";
        private string labelFileTrain = "../../samples/MNIST/train-labels.idx1-ubyte";
        private string pixelFileTest = "../../samples/MNIST/t10k-images.idx3-ubyte";
        private string labelFileTest = "../../samples/MNIST/t10k-labels.idx1-ubyte";

        public IList<double> Outputs = new List<double>(30);
        public int CurrentImage = 0;
        public Bitmap CurrentBitmap = null;
        public DigitImage[] trainImages = null;
        public DigitImage[] testImages = null;
        public List<string> InfoMultilayer = new List<string>();
        public int NetAnswer = -1;
        public int MNISTAnswer = -1;
        public Network Network = new Network();



        private int ReverseBytes(int v)
        {
            byte[] intAsBytes = BitConverter.GetBytes(v);
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }

        public void LoadLearningData()
        {
            trainImages = LoadData(pixelFileTrain, labelFileTrain, 60000);
        }
        public void LoadTestingData()
        {
            testImages = LoadData(pixelFileTest, labelFileTest, 10000);
        }
        private DigitImage[] LoadData(string pixelFile, string lableFile, int size)
        {
            int numImages = size;
            DigitImage[] result = new DigitImage[numImages];

            byte[][] pixels = new byte[28][];
            for (int i = 0; i < pixels.Length; i++)
                pixels[i] = new byte[28];

            FileStream ifsPixels = new FileStream(pixelFile, FileMode.Open);
            FileStream ifsLabels = new FileStream(lableFile, FileMode.Open);

            BinaryReader brImages = new BinaryReader(ifsPixels);
            BinaryReader brLabels = new BinaryReader(ifsLabels);

            int magic1 = brImages.ReadInt32();
            magic1 = ReverseBytes(magic1);

            int imageCount = brImages.ReadInt32();
            imageCount = ReverseBytes(imageCount);

            int numRows = brImages.ReadInt32();
            numRows = ReverseBytes(numRows);
            int numCols = brImages.ReadInt32();
            numCols = ReverseBytes(numCols);

            int magic2 = brLabels.ReadInt32();
            magic2 = ReverseBytes(magic2);

            int numLabels = brLabels.ReadInt32();
            numLabels = ReverseBytes(numLabels);

            for (int di = 0; di < numImages; di++)
            {
                for (int i = 0; i < 28; i++)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        byte b = brImages.ReadByte();
                        pixels[i][j] = b;
                    }
                }

                byte lbl = brLabels.ReadByte();
                DigitImage dImage = new DigitImage(28, 28, pixels, lbl);
                result[di] = dImage;
            }

            ifsPixels.Close(); brImages.Close();
            ifsLabels.Close(); brLabels.Close();

            InfoMultilayer.Add("Данные помещены в память.");
            //trainImages = result;
            return result;
        }

        public Bitmap MakeBitmap(DigitImage dImage, int mag)
        {
            int width = dImage.width * mag;
            int height = dImage.height * mag;
            Bitmap result = new Bitmap(width, height);
            Graphics gr = Graphics.FromImage(result);

            byte[][] pixels_matrix = new byte[28][];
            for (int i = 0; i < pixels_matrix.Length; ++i)
                pixels_matrix[i] = new byte[28];
            int count = 0;
            for (int i = 0; i < height; ++i)
                for (int j = 0; j < width; ++j)
                {
                    pixels_matrix[i][j] = dImage.pixels[count];
                    count++;
                }

            for (int i = 0; i < dImage.height; ++i)
            {
                for (int j = 0; j < dImage.width; ++j)
                {
                    int pixelColor = 255 - pixels_matrix[i][j]; // white background, black digits
                    Color c = Color.FromArgb(pixelColor, pixelColor, pixelColor); // gray scale
                    SolidBrush sb = new SolidBrush(c);
                    gr.FillRectangle(sb, j * mag, i * mag, mag, mag); // fills bitmap via Graphics object
                }
            }
            return result;
        }

        public void SaveNetwork(string file_name)
        {
            string network_json = Network.SaveToJson(); ;

            //File.Delete(s);
            using (var FS = new FileStream(file_name, FileMode.Create))
            {
                using (var SW = new StreamWriter(FS))
                {
                    SW.WriteLine(network_json);
                }
            }
            InfoMultilayer.Add("Сохранил сеть.");
        }
        private void SaveNetworkFast()
        {
            var s = "network.txt";
            string network_json = Network.SaveToJson(); ;

            File.Delete(s);
            using (var FS = new FileStream(s, FileMode.Create))
            {
                using (var SW = new StreamWriter(FS))
                {
                    SW.WriteLine(network_json);
                }
            }
        }
        public void TrainNetwork()
        {
            
            InfoMultilayer.Add("Начинаю обучение: " + DateTime.Now);
            double ErrorLimit = 0.01;//0.2
            double CurrentError = 9223372036854775806.0;
            int count_itatration = 0;
            while (CurrentError > ErrorLimit)
            {
                CurrentError = 0;


                for (int i = 0; i < 800; i++)//trainImages.Length
                {
                    Network.SetInput(trainImages[i].pixels);
                    CurrentError += Network.Educate(trainImages[i].label);
                    count_itatration++;
                }
                SaveNetworkFast();
                //InfoMultilayer.Add("Ошибка выборки =  " + CurrentError);
            }
            InfoMultilayer.Add("Ошибка выборки =  " + CurrentError);

            //int count = 0;
            //int res = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    Network.SetInput(testImages[i].pixels);
            //    res = Network.GetAnswer();
            //    //InfoMultilayer.Add("Число = " + testImages[i].label + " Распознал = " + res);
            //    if (res == testImages[i].label)
            //    {
            //        count++;
            //    }
            //}
            //InfoMultilayer.Add("Узнал правильных = " + count);
            InfoMultilayer.Add("Всего итераций = " + count_itatration);
            InfoMultilayer.Add("Обучение закончил: " + DateTime.Now);
            InfoMultilayer.Add("Сеть готова к работе.");
        }

        public void LoadBitmap()
        {
            //CurrentBitmap = MakeBitmap(testImages[CurrentImage], 1); 
            CurrentBitmap = MakeBitmap(trainImages[CurrentImage], 1); 
        }

        public void NextBitmap()
        {
            CurrentImage++;
            LoadBitmap();
        }

        public void GetAnswer()
        {
            //Network.SetInput(testImages[CurrentImage].pixels);
            //NetAnswer = Network.GetAnswer();
            //MNISTAnswer = testImages[CurrentImage].label;
            Network.SetInput(trainImages[CurrentImage].pixels);
            NetAnswer = Network.GetAnswer();
            MNISTAnswer = trainImages[CurrentImage].label;
        }

        public void LoadNetwork(string file_name)
        {
            string text = System.IO.File.ReadAllText(file_name);
            Network.RestoreWeights(text);
            InfoMultilayer.Add("Память нейронов успешно принята.");
        }

        public void PrevBitmap()
        {
            if (CurrentImage > 0)
            {
                CurrentImage--;
                LoadBitmap();
            }
        }

        public void UpdateViewNet()
        {
            Outputs = Network.GetOutputs();
        }

        public void TestNet(int size)
        {
            int count = 0;
            int res;
            for (int i = 0; i < size; i++)
            {
                Network.SetInput(testImages[i].pixels);
                res = Network.GetAnswer();
                if (res == testImages[i].label)
                {
                    count++;
                }
            }
            InfoMultilayer.Add("Узнал в тестовой базе правильнo: " + count);
            InfoMultilayer.Add("В процентах: " + (count*100)/size);
        }

        public void TestTrainNet(int size)
        {
            int count = 0;
            int res;
            for (int i = 0; i < size; i++)
            {
                Network.SetInput(trainImages[i].pixels);
                res = Network.GetAnswer();
                if (res == trainImages[i].label)
                {
                    count++;
                }
            }
            InfoMultilayer.Add("Узнал в тренировочной правильнo базе: " + count);
            InfoMultilayer.Add("В процентах: " + (count * 100) / size);
        }
    }
}
