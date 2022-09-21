using System;

namespace Exercicio2Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int liNhas, coluNas;

            int[,] Mat;

            String[] liNhasColunas = Console.ReadLine().Split(' ');
            liNhas = int.Parse(liNhasColunas[0]);
            coluNas = int.Parse(liNhasColunas[1]);

            Mat = new int[liNhas, coluNas];

            for (int i = 0; i < liNhas; i++)
            {
                String[] vetAux = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluNas; j++)
                {
                    Mat[i, j] = int.Parse(vetAux[j]);
                }
            }

            int[] vet = new int[liNhas];

            for (int i = 0; i < liNhas; i++)
            {
                int soma = 0;
                for (int j = 0; j < coluNas; j++)
                {
                    soma = soma + Mat[i, j];
                }
                vet[i] = soma;
            }

            for (int i = 0; i < liNhas; i++)
            {
                Console.WriteLine(vet[i]);
            }

        }
    }
}
