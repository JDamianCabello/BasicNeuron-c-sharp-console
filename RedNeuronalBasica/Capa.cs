namespace RedNeuronalBasica
{
    class Capa
    {
        //Total de neuronas que tendrá nuestra capa
        System.Collections.Generic.List<Neurona> neuronas = new System.Collections.Generic.List<Neurona>();
        System.Random rnd;
        public double[] Salida { get; set; }
        public Capa(int entradas, int numNeuronas, System.Random random)
        {
            rnd = random;

            for (int i = 0; i < numNeuronas; i++)
            {
                neuronas.Add(new Neurona(entradas, rnd));
            }
        }

        

        public void Salidas(double[] entradas)
        {
            //Aqui se guarda el número exacto que devuelve cada neurona (0 ó 1).
            double[] arrayAux = new double[neuronas.Count];
            for (int i = 0; i < neuronas.Count; i++)
            {
                arrayAux[i] = neuronas[i].Salida(entradas); //Se recorre el array y se llena con las salidas de las neuronas
            }

            Salida = arrayAux;
        }
    }
}
