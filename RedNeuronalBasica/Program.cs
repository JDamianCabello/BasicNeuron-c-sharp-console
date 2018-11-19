using System;

namespace RedNeuronalBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Neurona neurona = new Neurona(2);

            bool bandera = false;

            while (!bandera)
            {
                bandera = true;
                Console.WriteLine("".PadRight(Console.BufferWidth, '-'));
                Console.WriteLine("Peso 1: {0}", neurona.EntradasNeurona[0]);
                Console.WriteLine("Peso 2: {0}", neurona.EntradasNeurona[1]);
                Console.WriteLine("Umbral: {0}", neurona.Umbral);
                Console.WriteLine("E1:1     E2:1   :   {0}", neurona.Salida(new double[2] { 1, 1 }));
                Console.WriteLine("E1:1     E2:0   :   {0}", neurona.Salida(new double[2] { 1, 0 }));
                Console.WriteLine("E1:0     E2:1   :   {0}", neurona.Salida(new double[2] { 0, 1 }));
                Console.WriteLine("E1:0     E2:0   :   {0}", neurona.Salida(new double[2] { 0, 0 }));


                if (neurona.Salida(new double[2] { 1, 1 }) != 1)
                {
                    neurona.Aprender(new double[2] { 1, 1 }, 1);
                    bandera = false;
                }


                if (neurona.Salida(new double[2] { 1, 0 }) != 0)
                {
                    neurona.Aprender(new double[2] { 1, 0 }, 0);
                    bandera = false;
                }

                if (neurona.Salida(new double[2] { 0, 1 }) != 0)
                {
                    neurona.Aprender(new double[2] { 0, 1 }, 0);
                    bandera = false;
                }

                if (neurona.Salida(new double[2] { 0, 0 }) != 0)
                {
                    neurona.Aprender(new double[2] { 0, 0 }, 0);
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
