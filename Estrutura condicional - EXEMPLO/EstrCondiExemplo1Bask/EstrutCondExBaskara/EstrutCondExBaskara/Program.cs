using System;
using System.Globalization;

namespace Exercicio1036BaskaraECondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0],CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double Delta = Math.Pow(B, 2.0) - 4 * A * C;
            if (A == 0 || Delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Double R1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
                Double R2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);
                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
