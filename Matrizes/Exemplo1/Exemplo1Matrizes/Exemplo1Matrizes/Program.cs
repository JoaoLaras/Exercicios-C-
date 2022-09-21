using System;

namespace Exemplo1Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas;
            int[,] mAtriz;

            String[] vetAux = Console.ReadLine().Split(' ');
            linhas = int.Parse(vetAux[0]);
            colunas = int.Parse(vetAux[1]);
            mAtriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] auxLinhas = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    mAtriz[i, j] = int.Parse(auxLinhas[j]);
                }

            }
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(mAtriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
