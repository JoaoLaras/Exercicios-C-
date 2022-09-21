using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];

            //LENDO VETOR A 
            string[] VetAux = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(VetAux[i]);
            }

            //LENDO VETOR B
            VetAux = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                B[i] = int.Parse(VetAux[i]);
            }

            //GERANDO VETOR C
            int[] C = new int[N];

            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
            }

            //LENDO VETOR C
            for (int i = 0; i < N; i++)
            {
                Console.Write(C[i] + " ");
            }

        }       
    }
}
