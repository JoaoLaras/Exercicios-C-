using System;
using System.Globalization;
namespace Exercicio1009_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            String Vendedor = (Console.ReadLine());
            Double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Double Comissoes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Double ComissoesReceb = (Comissoes / 100) * 15;

            Double ValorFinal = ComissoesReceb + Salario;

            Console.WriteLine("TOTAL = R$ " + ValorFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
