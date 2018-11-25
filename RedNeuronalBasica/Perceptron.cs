namespace RedNeuronalBasica
{
    class Perceptron
    {
        public System.Collections.Generic.List<Capa> red = new System.Collections.Generic.List<Capa>();

        public Perceptron(int entradasExternas, int[] neuronasPorCapa)
        {
            System.Random rnd = new System.Random();

            //Las entradas externas son definidas por el usuario
            red.Add(new Capa(entradasExternas, neuronasPorCapa[0], rnd));

            for (int i = 1; i < neuronasPorCapa.Length; i++)
            {
                //Cada neurona tiene definidas sus entradas por el total de las neuronas de la capa anterior
                red.Add(new Capa(neuronasPorCapa[i - 1], neuronasPorCapa[i], rnd));
            }
        }
        
        public double[] Salidas(double[] entradasExternas)
        {
            red[0].Salidas(entradasExternas);//al igual que el método de antes, las externas son definidas por mí.

            for (int i = 1; i < red.Count; i++)
            {
                red[i].Salidas(red[i - 1].Salida);
            }

            return red[red.Count - 1].Salida;
        }
    }
}
