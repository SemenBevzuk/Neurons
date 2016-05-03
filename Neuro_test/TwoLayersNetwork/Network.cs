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

        private readonly double speed = 0.5; //коэффициент 
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
            for (var i = 0; i < Inputs.Count; i++)
            {
                Inputs[i] = new Pixel(0);
            }
            HiddenLayer = new List<NeuronWithActivationFunction>(20);
            for (var i = 0; i < HiddenLayer.Count; i++)
            {
                HiddenLayer[i] = new NeuronWithActivationFunction(Inputs.Select(_ => _ as ISignalProvider).ToList(),
                    new List<double>());
            }
            OutputLayer = new List<NeuronWithActivationFunction>(10);
            for (var i = 0; i < OutputLayer.Count; i++)
            {
                OutputLayer[i] = new NeuronWithActivationFunction(
                    HiddenLayer.Select(_ => _ as ISignalProvider).ToList(), new List<double>());
            }
            for (var i = 0; i < HiddenLayer.Count; i++)
            {
                HiddenLayer[i].NextLayer = OutputLayer.Select(_ => _ as IErrorProvider).ToList();
            }
            Errors = new List<ErrorProvider>(10);
            for (var i = 0; i < Errors.Count; i++)
            {
                Errors[i] = new ErrorProvider();
            }
            for (var i = 0; i < OutputLayer.Count; i++)
            {
                OutputLayer[i].NextLayer = Errors.Select(_ => _ as IErrorProvider).ToList();
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
                    Errors[i].Error = 0 - OutputLayer[result].Signal;
                }
                Errors[result].Error = 1 - OutputLayer[result].Signal;
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