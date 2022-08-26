using System;
using System.Globalization;

namespace Exercicio1048AumentodeSal
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioAtt;
            int PercSal;

            if (Salario <= 400.00)
            {
                SalarioAtt = Salario / 100 * 15;
                PercSal = 15;
            }
            else if (Salario <= 800.00)
            {
                SalarioAtt = Salario / 100 * 12;
                PercSal = 12;
            }
            else if (Salario <= 1200.00)
            {
                SalarioAtt = Salario / 100 * 10;
                PercSal = 10;
            }
            else if (Salario <= 2000.00)
            {

                SalarioAtt = Salario / 100 * 7;
                PercSal = 7;
            }
            else
            {
                SalarioAtt = Salario / 100 * 4;
                PercSal = 4;

            }
            Console.WriteLine("Novo salario: " + (Salario + SalarioAtt).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste Ganho: " + SalarioAtt.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + PercSal + "%");

        }
    }
}
