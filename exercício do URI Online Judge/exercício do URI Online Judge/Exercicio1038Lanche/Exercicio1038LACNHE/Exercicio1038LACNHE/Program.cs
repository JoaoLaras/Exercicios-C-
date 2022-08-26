using System;
using System.Globalization;

namespace Exercicio1038LACNHE
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] vet = Console.ReadLine().Split(' ');

            int Codigo = int.Parse(vet[0], CultureInfo.InvariantCulture);
            int Quantidade = int.Parse(vet[1], CultureInfo.InvariantCulture);

            double total;

            if (Codigo == 1) {
                total = Quantidade * 4;
            }

            else if (Codigo == 2) {
                total = Quantidade * 4.5;
            }

            else if (Codigo == 3) {
                total = Quantidade * 5.0;
            }

            else if (Codigo == 4) {
                total = Quantidade * 2;
            }

            else {
                total = Quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
        }

    }
}


