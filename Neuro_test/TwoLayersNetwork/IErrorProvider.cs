namespace Neuro_test.TwoLayersNetwork
{
    public interface IErrorProvider
    {
        double GetWeightedError(NeuronWithActivationFunction neuron);
    }
}