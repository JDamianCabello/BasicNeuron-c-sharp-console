namespace RedNeuronalBasica
{
    public class Neurona
    {
        public double[] Pesos { get; set; }
        public double Umbral { get; set; }

        public Neurona(double[] pesos, double umbral)
        {
            Pesos = pesos;
            Umbral = umbral;
        }

        public double Salida(double[] entradas)
        {
            return FalsaSigmoide(neurona(entradas));
        }

        double neurona(double[] entradas)
        {
            double sumaAux = 0;

            for (int i = 0; i < entradas.Length; i++)
                sumaAux += entradas[i] * Pesos[i];

            sumaAux += Umbral;

            return sumaAux;
        }

        double FalsaSigmoide(double d)
        {
            return d > 0 ? 1 : 0;
        }
    }
}
