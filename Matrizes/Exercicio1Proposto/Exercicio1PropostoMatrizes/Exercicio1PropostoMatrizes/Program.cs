using System;

namespace Exercicio1PropostoMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int liNhas, coluNas;

            int[,] mAt;

            String[] vetAux1 = Console.ReadLine().Split(' ');
            liNhas = int.Parse(vetAux1[0]);
            coluNas = int.Parse(vetAux1[1]);

            mAt = new int[liNhas, coluNas];


            //LENDO DADOS
            for (int i = 0; i < liNhas; i++)
            {
                string[] vetAux2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < coluNas; j++)
                {
                    mAt[i, j] = int.Parse(vetAux2[j]);
                }

            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < liNhas; i++)
            {
                for (int j = 0; j < coluNas; j++)
                {
                    if (mAt[i, j] < 0)
                    {
                        Console.WriteLine(mAt[i, j]);
                    }
                }
            }
        }
    }
}