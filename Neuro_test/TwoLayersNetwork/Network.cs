using System;
using System.Collections.Generic;
using System.Linq;

namespace Neuro_test.TwoLayersNetwork
{
    internal class Network
    {
        private readonly IList<Pixel> Inputs;
        private readonly IList<NeuronWithActivationFunction> HiddenLayer;
        private readonly IList<NeuronWithActivationFunction> OutputLayer;
        private readonly IList<ErrorProvider> Errors;

        private readonly double speed = 1; //коэффициент  0.5
        private const int SIZE = 28;


        public int GetAnswer()
        {
            var max = OutputLayer[0].Signal;
            var pos = 0;
            for (var i = 0; i < OutputLayer.Count; i++)
            {
                if (OutputLayer[i].Signal > max) 
                {
                    max = OutputLayer[i].Signal;
                    pos = i;
                }
            }
            return pos;
        }

        public Network()
        {
            Inputs = new List<Pixel>(SIZE*SIZE);
            for (var i = 0; i < SIZE * SIZE; i++)
            {
                //Inputs[i] = new Pixel(0);
                Inputs.Add(new Pixel(0));
            }

            HiddenLayer = new List<NeuronWithActivationFunction>(20);
            for (var i = 0; i < 20; i++)
            {
                //HiddenLayer[i] = new NeuronWithActivationFunction(Inputs.Select(_ => _ as ISignalProvider).ToList(),
                //    new List<double>());
                HiddenLayer.Add(new NeuronWithActivationFunction(Inputs.Select(_ => _ as ISignalProvider).ToList()));
            }
            OutputLayer = new List<NeuronWithActivationFunction>(10);
            for (var i = 0; i < 10; i++)
            {
                //OutputLayer[i] = new NeuronWithActivationFunction(
                //    HiddenLayer.Select(_ => _ as ISignalProvider).ToList(), new List<double>());
                OutputLayer.Add(new NeuronWithActivationFunction(HiddenLayer.Select(_ => _ as ISignalProvider).ToList()));
            }
            for (var i = 0; i < HiddenLayer.Count; i++)
            {
                HiddenLayer[i].NextLayer = OutputLayer.Select(_ => _ as IErrorProvider).ToList();
            }

            Errors = new List<ErrorProvider>(10);
            for (var i = 0; i < 10; i++)
            {
                //Errors[i] = new ErrorProvider();
                Errors.Add(new ErrorProvider());
            }
            for (var i = 0; i < OutputLayer.Count; i++)
            {
                OutputLayer[i].NextLayer = new List<IErrorProvider>{Errors[i]}; 
            }
        }

        public void SetInput(IList<byte> input)
        {
            for (var i = 0; i < input.Count; i++)
            {
                Inputs[i].Signal = input[i];
            }
        }

        public void Educate(IList<byte> input, int result)
        {
            SetInput(input);
            if (GetAnswer() != result)
            {
                for (var i = 0; i < Errors.Count; i++)
                {
                    if (i == result)
                        Errors[result].Error = 1 - OutputLayer[result].Signal;
                    else
                        Errors[i].Error = 0 - OutputLayer[result].Signal;
                }
                
                foreach (var neuron in OutputLayer)
                {
                    neuron.RecalculateDelta();
                }
                foreach (var neuron in HiddenLayer)
                {
                    neuron.RecalculateDelta();
                }
                foreach (var neuron in HiddenLayer)
                {
                    neuron.RecalculateWeights(speed);
                }
                foreach (var neuron in OutputLayer)
                {
                    neuron.RecalculateWeights(speed);
                }
            }
        }
        public string SaveToJson()
        {
            var json = "";
            foreach (var neuron in HiddenLayer)
            {
                json += neuron.SaveToJson() + Environment.NewLine;
            }
            foreach (var neuron in OutputLayer)
            {
                json += neuron.SaveToJson() + Environment.NewLine;
            }
            return json;
        }

        public void RestoreWeights(string s)
        {
            var lines = s.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
            for (var i = 0; i < HiddenLayer.Count; i++)
            {
                HiddenLayer[i].RestoreFromJson(lines[i]);
            }
            for (var i = 0; i < OutputLayer.Count; i++)
            {
                OutputLayer[i].RestoreFromJson(lines[i]);
            }
        }
    }
}