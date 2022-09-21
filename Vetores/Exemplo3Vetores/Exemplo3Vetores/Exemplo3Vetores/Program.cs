using System;
using System.Globalization;
namespace Exemplo3Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] Vet;

            N = int.Parse(Console.ReadLine());
            Vet = new double[N];
            

            String[] Vet2 = Console.ReadLine().Split(' ');
            
            for (int i = 0; i < N; i++)
            {
                Vet[i] = double.Parse(Vet2[i], CultureInfo.InvariantCulture);

            }
            
            //int i = 0;
            // while (i < N)
            //{
            // i++;
            // }

            // foreach ( var a in Vet2)
            // {
            //    Console.WriteLine(a);
            // }

            for (int i = 0; i < N; i++)
            {
                Console.Write(Vet[i].ToString("F1", CultureInfo.InvariantCulture) +" ");

            }
            Console.WriteLine();

            double Soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                Soma = Vet[i] + Soma;

            }
            double MEDIA = Soma / N;

            Console.WriteLine(Soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(MEDIA.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
