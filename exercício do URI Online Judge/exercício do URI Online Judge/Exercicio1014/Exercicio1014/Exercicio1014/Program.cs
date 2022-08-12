using System;
using System.Globalization;

namespace Exercicio1014
{
    class Program
    {
        static void Main(string[] args)

        {   int X;
            double Y, valorMedio;

            X = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorMedio = X / Y;

            Console.WriteLine(valorMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l ");
        }
    }
}
