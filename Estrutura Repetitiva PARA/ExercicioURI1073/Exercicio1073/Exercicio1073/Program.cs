using System;

namespace Exercicio1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double Quadrado;
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    Quadrado = Math.Pow(i, 2.0);
                    Console.WriteLine(i + "^2" + " = " + Quadrado);

                }

            }

        }
    }
}
