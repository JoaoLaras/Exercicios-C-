using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X;

            N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i = i + 1)
            { //OU i++

                X = int.Parse(Console.ReadLine());
                soma = soma + X;

            }
            Console.WriteLine(soma);
            Console.ReadLine();

            // for (int i = 10; i >= 1; i = i -1 )
            // {
            //  Console.WriteLine(i);
            // }

            // for (int i = 1; i <= 10; i = i + 1 )
            // {
            //  Console.WriteLine(i);
            // }
        }
    }
}
