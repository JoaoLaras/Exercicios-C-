using System;
using System.Globalization;
namespace Exercicio9Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            String[] nomesProd = new string[N];
            Double[] precoCompra = new double[N];
            Double[] precoVenda = new double[N];

            //LENDO DADOS
            for (int i = 0; i < N; i++)
            {
                string[] vetAux = Console.ReadLine().Split(' ');

                nomesProd[i] = vetAux[0];
                precoCompra[i] = double.Parse(vetAux[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(vetAux[2], CultureInfo.InvariantCulture);
            }

            //QUANTIDADE FAIXA DE LUCRO

            int contAbaixoDe10 = 0;
            int contEntre10E20 = 0;
            int contAcimaDe20 = 0;

            for (int i = 0; i < N; i++)
            {
                Double lucro = precoVenda[i] - precoCompra[i];

                double porcentagemDeLucro = lucro / precoCompra[i] * 100;

                if (porcentagemDeLucro < 10.0)
                {
                    contAbaixoDe10++;
                }
                else if (porcentagemDeLucro <= 20.0)
                {
                    contEntre10E20++;
                }
                else
                {
                    contAcimaDe20++;
                }
            }
            Console.WriteLine("Lucro abaixo de 10%: " + contAbaixoDe10);
            Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
            Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

            //TOTAL COMPRAS E VENDAS

            double totalCompra = 0.0;
            double totalVendas = 0.0;

            for (int i = 0; i < N; i++)
            {
                totalCompra = totalCompra + precoCompra[i];
                totalVendas = totalVendas + precoVenda[i];
            }

            double totalLucro = totalVendas - totalCompra;

            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVendas.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}