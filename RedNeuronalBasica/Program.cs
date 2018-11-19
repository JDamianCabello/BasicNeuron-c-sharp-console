using System;

namespace RedNeuronalBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Neurona neurona = new Neurona(new double[2],0);


         

            Random rnd = new Random();

            //El error de nuestra neurona es: Lo que necesitamos - lo que tenemos
            bool bandera = false;

            while (!bandera)
            {
                bandera = true;
                neurona.Pesos[0] = rnd.NextDouble() - rnd.NextDouble();
                neurona.Pesos[1] = rnd.NextDouble() - rnd.NextDouble();
                neurona.Umbral = rnd.NextDouble() - rnd.NextDouble();

                Console.WriteLine("".PadRight(Console.BufferWidth, '-'));
                Console.WriteLine("Peso 1: {0}", neurona.Pesos[0]);
                Console.WriteLine("Peso 2: {0}", neurona.Pesos[1]);
                Console.WriteLine("Umbral: {0}", neurona.Umbral);


                Console.WriteLine("E1:1     E2:1   :   {0}", neurona.Salida(new double[2] { 1, 1 }));

                Console.WriteLine("E1:1     E2:0   :   {0}", neurona.Salida(new double[2] { 1, 0 }));

                Console.WriteLine("E1:0     E2:1   :   {0}", neurona.Salida(new double[2] { 0, 1 }));

                Console.WriteLine("E1:0     E2:0   :   {0}", neurona.Salida(new double[2] { 0, 0 }));


                if (neurona.Salida(new double[2] { 1, 1 }) != 1)
                {
                    bandera = false;
                }


                if (neurona.Salida(new double[2] { 1, 0 }) != 0)
                {
                    bandera = false;
                }

                if (neurona.Salida(new double[2] { 0, 1 }) != 0)
                {
                    bandera = false;
                }

                if (neurona.Salida(new double[2] { 0, 0 }) != 0)
                {
                    
                    bandera = false;
                }

            }

            Console.ReadLine();
        }

        double Neurona(double entrada1, double entrada2, double peso1, double peso2, double umbral)
        {
            return umbral + entrada1 * peso1 + entrada2 * peso2;
        }

        double funcionNeurona(double d)
        {
            return d > 0 ? 1 : 0;
        }
    }
}
