using System;
using System.Globalization;
namespace Exercicio1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (Nota1 < 0 || Nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (Nota2 < 0 || Nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double media = (Nota1 + Nota2) / 2;
            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("novo calculo (1-sim 2-nao)");

            int Entrada = int.Parse(Console.ReadLine());

            while (Entrada == 1)
            {
                Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (Nota1 < 0 || Nota1 > 10)
                {
                    Console.WriteLine("nota invalida");
                    Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (Nota2 < 0 || Nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                media = (Nota1 + Nota2) / 2;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

            }
           
            {


            }



        }
    }
}
