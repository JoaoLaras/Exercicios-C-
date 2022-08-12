using System;
using System.Globalization;
namespace Exercicio1013___ABS // MAIOR VALOR
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            int MaiorAB = (a + b + Math.Abs(a-b)) / 2;
            int MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;
            Console.WriteLine(MaiorABC + " eh o maior");
        }
    }
}
