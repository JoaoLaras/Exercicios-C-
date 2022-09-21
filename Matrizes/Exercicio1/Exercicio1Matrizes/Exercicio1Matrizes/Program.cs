using System;

namespace Exercicio1Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] A;

            N = int.Parse(Console.ReadLine());
            A = new int[N, N];

            //LENDO VALOR
            for (int i = 0; i < N; i++)
            {
                string[] vetAux = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(vetAux[j]);
                }
            }
            // MOSTRANDO DIAGONAL PRINCIPAL
            Console.WriteLine("DIAGONAL PRINCIPAL");

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i] + " ");

            }
            Console.WriteLine();

            //MOSTRANDO QUANTIDADE NEGATIVA
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADES DE NEGATIVOS " + cont);

            Console.ReadLine();
        }
    }
}