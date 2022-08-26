using System;

namespace Exercicio_1018___Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int CemReais = N / 100;
            int RestCem = N % 100;

            int CinqReais = RestCem / 50;
            int RestCinq = RestCem % 50;

            int VinteReais = RestCinq / 20;
            int RestVintR = RestCinq % 20;

            int DezReais = RestVintR / 10;
            int RestDezR = RestVintR % 10;

            int CincoReais = RestDezR / 5;
            int RestCincoR = RestDezR % 5;

            int DoisReais = RestCincoR / 2;
            int RestDoisR = RestCincoR % 2;

            int UmReal = RestDoisR / 1;
            int RestdeUmR = RestDoisR % 1;

            Console.WriteLine(N);
            Console.WriteLine(CemReais + " nota(s) de R$ 100,00");
            Console.WriteLine(CinqReais + " nota(s) de R$ 50,00");
            Console.WriteLine(VinteReais + " nota(s) de R$ 20,00");
            Console.WriteLine(DezReais + " nota(s) de R$ 10,00");
            Console.WriteLine(CincoReais + " nota(s) de R$ 5,00");
            Console.WriteLine(DoisReais + " nota(s) de R$ 2,00");
            Console.WriteLine( UmReal + " nota(s) de R$ 1,00");
        
        }
    }
}
