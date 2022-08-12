using System;
using System.Globalization;

namespace Exercicio1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorPorLitro, Tempogasto, ValorGasto, VelocidadeM;

            Tempogasto = double.Parse(Console.ReadLine());
            VelocidadeM = double.Parse(Console.ReadLine());

            ValorPorLitro = VelocidadeM / 12;
            ValorGasto = ValorPorLitro * Tempogasto;
            Console.WriteLine(ValorGasto.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
