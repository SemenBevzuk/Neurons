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
                Signals[i] = new Pixel(input[i]);
            }
        }
    }
}