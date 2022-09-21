using System;
using System.Globalization;

namespace Exemplo4Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            String[] nomes = new string[N];
            int[] idades = new int[N];
            double[] altura = new double[N];

            //LENDO OS DADOS
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }
            // CALCULO ALTURA MEDIA DAS PESSOAS

            Double Soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                Soma = altura[i] + Soma;
            }

            double Media = Soma / N;
            Console.WriteLine("Altura média: " + Media.ToString("F2", CultureInfo.InvariantCulture));

            //CONTADOR O NUMERO DE MENORES EM PORCENTAGEM
            int menores = 0;
            for (int i = 0; i < N; i++)
            {
                if (idades[i] < 16)
                {
                    menores++;
                }
            }
            double porcentagem = (double)menores / N * 100.0;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");
            Console.ReadLine();
        }
    }
}
