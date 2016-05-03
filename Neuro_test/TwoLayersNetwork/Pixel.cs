namespace Neuro_test.TwoLayersNetwork
{
    public class Pixel : ISignalProvider
    {
        public Pixel(double color)
        {
            Signal = color;
        }

        public double Signal { get; set; }
    }
}