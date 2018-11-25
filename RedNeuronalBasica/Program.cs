using System;

namespace RedNeuronalBasica
{
    class Program
    {
        static void Main(string[] args)
        {

            bool bandera = false;
            int iteraciones = 0;
            //El perceptron llega al resultado de la XOR pero no es ni mucho menos optimo
            //Ni siquiera llega de la mejor forma es decir, siendo optimo.
            //Arroja verdad a veces en 200 y otras por 9000, esto necesita ser optimizado.
            Console.WriteLine("Probando la XOR");
            while (!bandera)
            {
                bandera = true;
                Perceptron perceptron = new Perceptron(2, new int[] { 2, 1 });
                Console.WriteLine("".PadRight(Console.BufferWidth, '-'));
                Console.WriteLine("E1:1     E2:1   :   {0}", perceptron.Salidas(new double[] { 1, 1 })[0]);
                Console.WriteLine("E1:1     E2:0   :   {0}", perceptron.Salidas(new double[] { 1, 0 })[0]);
                Console.WriteLine("E1:0     E2:1   :   {0}", perceptron.Salidas(new double[] { 0, 1 })[0]);
                Console.WriteLine("E1:0     E2:0   :   {0}", perceptron.Salidas(new double[] { 0, 0 })[0]);


                if (perceptron.Salidas(new double[] { 1, 1 })[0] != 1)
                {
                    bandera = false;
                }


                if (perceptron.Salidas(new double[] { 1, 0 })[0] != 0)
                {
                    bandera = false;
                }

                if (perceptron.Salidas(new double[] { 0, 1 })[0] != 0)
                {
                    bandera = false;
                }

                if (perceptron.Salidas(new double[] { 0, 0 })[0] != 1)
                {
                    bandera = false;
                }
                iteraciones++;

            }
            Console.WriteLine("Resultado encontrado en {0} iteraciones.", iteraciones);
            Console.ReadKey();
        }
    }
}
