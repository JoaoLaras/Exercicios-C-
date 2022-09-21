using System;
using System.Globalization;
namespace Exercicio1079
{
    class Program
    {
        static void Main(string[] args)
        {
            //A média aritmética ponderada é calculada multiplicando cada valor do conjunto de dados pelo seu peso.
            //Depois, encontra-se a soma desses valores que será dividida pela soma dos pesos.

            double N, Resultado;

            N = double.Parse(Console.ReadLine());
                       
            for (int i = 1; i <= N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
                Resultado = (N1 * 2.0 + N2 * 3.0 + N3 * 5.0) / 10.0;
                Console.WriteLine(Resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}