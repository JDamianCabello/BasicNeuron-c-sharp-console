using System;

namespace RedNeuronalBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            double peso1, peso2; //Esto es la cantidad de entradas de nuestra neurona, en nuestro caso 2.

            double umbral;   //El umbral define la diferencia de 0

            /*
             *  Neurona creada a través de un AND lógico y dos entradas
             *  
             *  
             *       E1   E2   AND
             *       0     0    0
             *       0     1    0
             *       1     0    0
             *       1     1    1
             *      
             */

            Random rnd = new Random();
            bool bandera = false;

            while (!bandera)
            {
                bandera = true;
                peso1 = rnd.NextDouble() - rnd.NextDouble();
                peso2 = rnd.NextDouble() - rnd.NextDouble();
                umbral = rnd.NextDouble() - rnd.NextDouble();

                Console.WriteLine("".PadRight(Console.BufferWidth, '-'));
                Console.WriteLine("Peso 1: {0}", peso1);
                Console.WriteLine("Peso 2: {0}", peso2);
                Console.WriteLine("Umbral: {0}", umbral);


                Console.WriteLine("E1:1     E2:1   :   {0}", program.funcionNeurona(program.Neurona(1, 1, peso1, peso2, umbral)));

                Console.WriteLine("E1:1     E2:0   :   {0}", program.funcionNeurona(program.Neurona(1, 0, peso1, peso2, umbral)));

                Console.WriteLine("E1:0     E2:1   :   {0}", program.funcionNeurona(program.Neurona(0, 1, peso1, peso2, umbral)));

                Console.WriteLine("E1:0     E2:0   :   {0}", program.funcionNeurona(program.Neurona(0, 0, peso1, peso2, umbral)));


                if (program.funcionNeurona(program.Neurona(1, 1, peso1, peso2, umbral)) != 1)
                {
                    bandera = false;
                }


                if (program.funcionNeurona(program.Neurona(1, 0, peso1, peso2, umbral)) != 0)
                {
                    bandera = false;
                }

                if (program.funcionNeurona(program.Neurona(0, 1, peso1, peso2, umbral)) != 0)
                {
                    bandera = false;
                }

                if (program.funcionNeurona(program.Neurona(0, 0, peso1, peso2, umbral)) != 0)
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
