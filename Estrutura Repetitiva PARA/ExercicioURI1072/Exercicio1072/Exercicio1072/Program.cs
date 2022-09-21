using System;

namespace Exercicio1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dentro, Fora;

            int N = int.Parse(Console.ReadLine());

            Dentro = 0;
            Fora = 0;
            for (int i = 1; i <= N; i++)
            {
                int X = int.Parse(Console.ReadLine());


                if (X >= 10 && X <= 20)
                {
                    Dentro = Dentro + 1;
                }
                else
                {
                    Fora = Fora + 1;
                }

            }
            Console.WriteLine(Dentro + " in");
            Console.WriteLine(Fora + " out");
        }
    }
}
