namespace RedNeuronalBasica
{
    public class Neurona
    {
        public double[] EntradasNeurona { get; set; }
        public double Umbral { get; set; }

        private const double TASADEAPRENDIZAJE = 0.3;
        //Corresponde al valor que aprende cada vez que falla, valores mas altos
        //dan resultados más rápidos pero menos exactos.

        private double[] entradasAnteriores;
        double umbralAnterior;

        public Neurona(int nEntradas)
        {
            EntradasNeurona = new double[nEntradas];
            entradasAnteriores = new double[nEntradas];
            Aprender();
        }

        /// <summary>
        /// Se ejecuta al crear la neurona, la pone a aprender automáticamente.
        /// </summary>
        public void Aprender()
        {
            System.Random rnd = new System.Random();

            for (int i = 0; i < entradasAnteriores.Length; i++)
                entradasAnteriores[i] = rnd.NextDouble() - rnd.NextDouble();

            umbralAnterior = rnd.NextDouble() - rnd.NextDouble();

            EntradasNeurona = entradasAnteriores;
            Umbral = umbralAnterior;

        }

        /// <summary>
        /// En caso de error de la neurona se corrige con este método
        /// </summary>
        /// <param name="entradas">Las entradas que ha recibido la neurona</param>
        /// <param name="salidaEsperada">La salida que debería haber tenido la misma</param>
        public void Aprender(double[] entradas, double salidaEsperada)
        {
            //El error de nuestra neurona es: Lo que necesitamos - lo que tenemos
            double error = salidaEsperada - Salida(entradas);

            for (int i = 0; i < EntradasNeurona.Length; i++)
                EntradasNeurona[i] = entradasAnteriores[i] + TASADEAPRENDIZAJE * error * entradas[i];

            Umbral = umbralAnterior + TASADEAPRENDIZAJE * error;

            entradasAnteriores = EntradasNeurona;
            umbralAnterior = Umbral;

        }

        public double Salida(double[] entradas)
        {
            return FalsaSigmoide(neurona(entradas));
        }

        /// <summary>
        /// Método que calcula el valor total de las entradas de la neurona. 
        /// </summary>
        /// <param name="entradas">Los valores de entradas de la neurona</param>
        /// <returns>suma de las entradas multiplicadas por sus pesos, más el umbral</returns>
        double neurona(double[] entradas)
        {
            double sumaAux = 0;

            for (int i = 0; i < entradas.Length; i++)
                sumaAux += entradas[i] * EntradasNeurona[i];

            sumaAux += Umbral;

            return sumaAux;
        }

        /// <summary>
        /// Método que simula la formula matemática sigmoide. No está ajustado
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        double FalsaSigmoide(double d)
        {
            return d > 0 ? 1 : 0;
        }
    }
}
