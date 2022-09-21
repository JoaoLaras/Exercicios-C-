using System;
using System.Globalization;

namespace Exercicio4Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] NumerosReais = new double[N];

            //LENDO DADOS
            String[] VetAux = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                NumerosReais[i] = double.Parse(VetAux[i], CultureInfo.InvariantCulture);

            }

            double Soma = 0;
            // MEDIA ARITIMÉTICA
           // for (int i = 0; i < N; i++)
            foreach (double X in NumerosReais)
            {
                Soma = X + Soma;
            }
            double Media = Soma / N;

            Console.WriteLine(Media.ToString("F3", CultureInfo.InvariantCulture));
            

            //MOSTRANDO TODOS ELEMENTOS ABAIXO DA MEDIA
            //for (int i = 0; i < N; i++)
            foreach (double Y in NumerosReais)
            {
                if (Y < Media)
                {
                    Console.WriteLine(Y.ToString("F1", CultureInfo.InvariantCulture));
                }
            }


        }
    }
}
