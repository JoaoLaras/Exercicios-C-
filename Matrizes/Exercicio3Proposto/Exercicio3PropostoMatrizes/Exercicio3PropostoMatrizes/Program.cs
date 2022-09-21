using System;

namespace Exercicio3PropostoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mAt = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vetAux = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mAt[i, j] = int.Parse(vetAux[j]);
                }

            }

            for (int i = 0; i < N; i++)
            {
                int maior = mAt[i, 0];

                for (int j = 1; j < N; j++)
                {
                    if (mAt[i, j] > maior)
                    {
                        maior =  mAt[i, j];
                                               
                    }

                }
                Console.WriteLine(maior);
            }
        }
    }
}