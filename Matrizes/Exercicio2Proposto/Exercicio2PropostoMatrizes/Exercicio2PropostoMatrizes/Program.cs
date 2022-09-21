using System;

namespace Exercicio1PropostoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mAt = new int[N, N];

            //LENDO DADOS
            for (int i = 0; i < N; i++)
            {
                String[] vetAux = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mAt[i, j] = int.Parse(vetAux[j]);
                }
            }

            //MOSTRANDO SOMA
            for (int i = 0; i < N; i++)
            {
                int soma = 0;
                for (int j = 0; j < N; j++)
                {
                    soma = soma + mAt[i, j];

                }

                int[] vetSoma = new int[N];
                vetSoma[i] = soma;

                Console.WriteLine(vetSoma[i]);
            }
        }
    }
}