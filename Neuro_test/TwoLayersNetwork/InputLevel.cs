using System;
using System.Collections.Generic;

namespace Neuro_test.TwoLayersNetwork
{
    public class InputLevel
    {
        public IList<ISignalProvider> Signals { get; private set; }

        public InputLevel(IList<byte> input)
        {
            Signals = new ISignalProvider[input.Count];
            for (var i = 0; i < input.Count; i++)
            {
                Signals[i] = new Pixel(Sigmoid(input[i]));
            }
        }
        //добавим функцию активации в входной слой
        private double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
    }
}