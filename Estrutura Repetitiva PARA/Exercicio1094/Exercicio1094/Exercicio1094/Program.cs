using System;
using System.Globalization;

namespace Exercicio1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int Testes = int.Parse(Console.ReadLine()); 

            int Coelhos = 0;
            int Rato = 0;
            int Sapo = 0;
            
            for (int i = 1; i <= Testes; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int Cobaias = int.Parse(vet[0]);
                char Tipos = char.Parse(vet[1]);
               
                if (Tipos == 'C' ) //|| Tipos == 'c')
                {
                    Coelhos = Coelhos + Cobaias;

                }
                else if (Tipos == 'R')
                {
                    Rato =  Rato + Cobaias;

                }
                else
                {
                    Sapo = Sapo + Cobaias;

                }
            }

            int total = Coelhos + Rato + Sapo;
            double PorcentagemCoelhos = (double)Coelhos / total * 100.0;
            double PorcentagemRatos = (double)Rato / total * 100.0;
            double PorcentagemSapos = (double)Sapo / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + Coelhos);
            Console.WriteLine("Total de ratos: " + Rato);
            Console.WriteLine("Total de sapos: " + Sapo);
            Console.WriteLine("Percentual de coelhos: " + PorcentagemCoelhos.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + PorcentagemRatos.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + PorcentagemSapos.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
