using System;
using System.Globalization;

namespace Exercicio1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int Peca1, Npeca1, Peca2, Npeca2;
            double VPeca1, VPeca2, ValorPagarPeca1, ValorPagarPeca2, TotalValorPecas;

            string[] PecasVet1 = (Console.ReadLine().Split(' '));
            Peca1 = int.Parse(PecasVet1[0]);
            Npeca1 = int.Parse(PecasVet1[1]);
            VPeca1 = double.Parse(PecasVet1[2], CultureInfo.InvariantCulture);
            ValorPagarPeca1 = Npeca1 * VPeca1;

            string[] PecasVet2 = (Console.ReadLine().Split(' '));
            Peca2 = int.Parse(PecasVet2[0]);
            Npeca2 = int.Parse(PecasVet2[1]);
            VPeca2 = double.Parse(PecasVet2[2], CultureInfo.InvariantCulture);
            ValorPagarPeca2 = Npeca2 * VPeca2;
            TotalValorPecas = ValorPagarPeca1 + ValorPagarPeca2;
            Console.WriteLine("VALOR A PAGAR: R$ " + TotalValorPecas.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
