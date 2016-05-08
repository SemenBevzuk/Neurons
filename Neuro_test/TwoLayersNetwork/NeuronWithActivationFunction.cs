using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Neuro_test.TwoLayersNetwork
{
    public class NeuronWithActivationFunction : ISignalProvider, IErrorProvider
    {
        private readonly IList<ISignalProvider> inputSignalFromNeuro;
        private double delta; //ошибка
        public IList<IErrorProvider> NextLayer;

        private double sum; //e = input_signal*weight + ...;
        private IList<double> weight; //веса в него входящих
        private static Random rnd = new Random(10);

        private double? signalOUT = null;

        //null-абельный ленивый тип
        public double? ValueSignalOUT
        {
            get
            {
                if (signalOUT == null)
                {
                    sum = GetSum;
                    signalOUT = Sigmoid(sum);
                }
                return signalOUT;
            }
        }

        public NeuronWithActivationFunction(IList<ISignalProvider> inputSignalFromNeuroOut)
        {
            this.inputSignalFromNeuro = inputSignalFromNeuroOut;
            weight = new List<double>();
            for (int i = 0; i<inputSignalFromNeuroOut.Count; i++)
            {
                weight.Add(rnd.NextDouble()-0.5);
            }
        }

        public NeuronWithActivationFunction(IList<ISignalProvider> inputSignalFromNeuro, IList<double> weight)
        {
            this.inputSignalFromNeuro = inputSignalFromNeuro;
            this.weight = weight;
        }

        private double GetSum
        {
            get
            {
                double sum = 0;
                for (var i = 0; i < inputSignalFromNeuro.Count; i++)
                {
                    sum += inputSignalFromNeuro[i].Signal*weight[i];
                }
                return sum;
            }
        }

        public double Signal
        {
            get
            {
                sum = GetSum;
                return Sigmoid(sum);
            }
        }

        public double GetWeightedError(NeuronWithActivationFunction neuron)
        {
            return delta*GetWeight(neuron);
        }
        //тестовая часть
        public void RecalculateDeltaOutput(double Error)
        {
            delta = Error * ValueSignalOUT.Value;
        }
        //public void RecalculateDeltaHidden()
        //{
        //    double newDelta = 0;
        //    foreach (var rightNeuron in NextLayer)
        //    {
        //        newDelta += rightNeuron.GetWeightedError(this);
        //    }
        //    delta = newDelta*SigmoidDerivative(sum);
        //}

        //public void RecalculateWeightsAnother(double speed)
        //{
        //    for (var i = 0; i < weight.Count; i++)
        //    {
        //        weight[i] = weight[i] + speed*delta * Sigmoid(sum);//speed
        //    }
        //}
        public void RecalculateWeightsAnotherOutput(double speed)
        {
            for (var i = 0; i < 20; i++)
            {
                weight[i] = weight[i] + speed * delta * ValueSignalOUT.Value;//speed
            }
            signalOUT = null;
        }
        public void RecalculateWeightsAnotherHidden(double speed)
        {
            for (var i = 0; i < 784; i++)
            {
                weight[i] = weight[i] + speed*delta*inputSignalFromNeuro[i].Signal; //ValueSignalOUT.Value;//speed
            }
            signalOUT = null;
        }
        public void RecalculateDeltaHidden()
        {
            double newDelta = 0;
            foreach (var rightNeuron in NextLayer)
            {
                newDelta += rightNeuron.GetWeightedError(this);
            }
            delta = newDelta*SigmoidDerivative(sum);
        }
        //тестовая часть
        public void RecalculateDelta()
        {
            double newDelta = 0;
            foreach (var rightNeuron in NextLayer)
            {
                newDelta += rightNeuron.GetWeightedError(this);
            }
            delta = newDelta;
        }

        public void RecalculateWeights(double speed)
        {
            for (var i = 0; i < weight.Count; i++)
            {
                weight[i] =weight[i] + speed*delta*SigmoidDerivative(sum)*inputSignalFromNeuro[i].Signal;
            }
            signalOUT = null;
        }

        public string SaveToJson()
        {
            return JsonConvert.SerializeObject(weight);
        }

        public void RestoreFromJson(string json)
        {
            weight = JsonConvert.DeserializeObject<IList<double>>(json);
        }

        private double Sigmoid(double x)
        {
            return 0.998*(1.0/(1 + Math.Exp(-x)))+0.001;
        }

        private double SigmoidDerivative(double x)
        {
            return Sigmoid(x)*(1 - Sigmoid(x));
        }

        private double GetWeight(NeuronWithActivationFunction neuron)
        {
            for (var i = 0; i < inputSignalFromNeuro.Count; i++)
            {
                if (neuron == inputSignalFromNeuro[i])
                {
                    return weight[i];
                }
            }
            throw new ArgumentException("Попытка вычисления ошибки для неизвестного нейрона");
        }
    }
}