using System;
using System.Globalization;

namespace Exercicio1Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] valor = new double[N];

            string[] vetaux = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
               valor[i] = double.Parse(vetaux[i], CultureInfo.InvariantCulture);

            }

            double maior = valor[0];
            double posicao = 0;
            for (int i = 0; i < N; i++)
            {
                if (valor[i] > maior)
                {
                    maior = valor[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
