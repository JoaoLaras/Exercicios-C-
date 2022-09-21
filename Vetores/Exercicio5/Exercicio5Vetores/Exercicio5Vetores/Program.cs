using System;
using System.Globalization;
namespace Exercicio5Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] Numeros = new int[N];
            int Pares = 0;
            int QuantPares = 0;

            //LENDO DADOS
            string[] vetAux = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                Numeros[i] = int.Parse(vetAux[i]);
            }

            //LENDO NUMEROS PARES
            for (int i = 0; i < N; i++)
            {
                if (Numeros[i] % 2 == 0)
                {
                    Pares = Pares + Numeros[i];
                    QuantPares = QuantPares + 1;
                }
            }

            //MEDIA ARITIMETICA

            double Media = Pares / QuantPares;

            Console.WriteLine(Media.ToString("F1", CultureInfo.InvariantCulture));







        }
    }
}
