using System;
using System.Globalization;
namespace Exercicio7Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            String[] nomes = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];


            //LENDO DADOS
            for (int i = 0; i < N; i++)
            {
                string[] vetAux = Console.ReadLine().Split(' ');
                nomes[i] = vetAux[0];
                nota1[i] = double.Parse(vetAux[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(vetAux[2], CultureInfo.InvariantCulture);

            }

            //CALCULO MEDIA
            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++)
            {
                double media = (nota1[i] + nota2[i]) / 2;

                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}