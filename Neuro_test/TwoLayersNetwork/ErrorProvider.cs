namespace Neuro_test.TwoLayersNetwork
{
    public class ErrorProvider : IErrorProvider
    {
        public double Error { get; set; }

        public double GetWeightedError(NeuronWithActivationFunction neuron)
        {
            return Error;
        }
    }
}