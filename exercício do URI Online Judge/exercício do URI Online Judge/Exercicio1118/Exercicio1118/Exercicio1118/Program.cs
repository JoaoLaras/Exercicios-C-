using System;
using System.Globalization;
namespace Exercicio1117
{
    class Program
    {
        static void Main(string[] args)
        {

            int NovoCalculo = 1;

            while (NovoCalculo == 1)
            {
                double Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (Nota1 < 0.0 || Nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (Nota2 < 0.0 || Nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                double media = (Nota1 + Nota2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                NovoCalculo = int.Parse(Console.ReadLine());

                while (NovoCalculo != 1 && NovoCalculo != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    NovoCalculo = int.Parse(Console.ReadLine());
                }
            }


        }

    }
}