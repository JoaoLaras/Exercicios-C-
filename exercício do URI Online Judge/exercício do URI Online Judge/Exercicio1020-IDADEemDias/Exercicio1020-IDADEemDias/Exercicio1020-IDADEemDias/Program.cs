using System;

namespace Exercicio1020_IDADEemDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int IdadeDias = int.Parse(Console.ReadLine());

            int Ano = IdadeDias / 365;
            int RestAno = IdadeDias % 365;

            int Mes = RestAno / 30;
            int RestMes = RestAno % 30;

            int dias = RestMes;

            Console.WriteLine(Ano + " ano(s)");
            Console.WriteLine(Mes + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
