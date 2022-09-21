using System;
using System.Globalization;
namespace Exercicio8Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            char[] sexo = new char[N];

            // LENDO DADOS
            for (int i = 0; i < N; i++)
            {
                string[] vetAux = Console.ReadLine().Split(' ');

                altura[i] = double.Parse(vetAux[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(vetAux[1]);
            }
            //MENOR ALTURA
            double menorAltura = altura[0];
            for (int i = 0; i < N; i++)
            {
                if (altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
            }

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));

            //MAIOR ALTURA
            double maiorAltura = altura[0];
            for (int i = 0; i < N; i++)
            {
                if (altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));

            //MEDIA DAS ALTURAS DAS MULHERES

            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'F' || sexo[i] == 'f')
                {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + altura[i];
                    contMulheres++;
                }
            }

            if (contMulheres == 0)
            {
                Console.WriteLine("Nao ha nenhuma mulher dentre as pessoas");
            }
            else
            {
                double media = somaDasAlturasDasMulheres / contMulheres;
                Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            //NUMEROS DE HOMENS
            int contHomens = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'M' || sexo[i] == 'm')
                {
                    contHomens++;
                }
            }
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}
