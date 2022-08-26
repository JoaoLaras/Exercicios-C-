using System;
using System.Globalization;
namespace Exercicio1040NOTASPESO
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');

            double N1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double N2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double N3 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            double N4 = double.Parse(vet[3], CultureInfo.InvariantCulture);

            double Media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

            Console.WriteLine("Media: " + Media.ToString("F1", CultureInfo.InvariantCulture));
            if (Media >= 7.0)
            {
               Console.WriteLine("Aluno Aprovado");

            }
            else if (Media < 5.0)
            {
                Console.WriteLine("Aluno Reprovado");

            }
            else if (Media >= 5.0 && Media < 7)
            {
                Console.WriteLine("Aluno em Exame");
                double NotaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double MediaFinal = (Media + NotaExame) / 2;
                Console.WriteLine("Nota do Exame: " + NotaExame.ToString("F1", CultureInfo.InvariantCulture));

                if (MediaFinal >= 5)
                {
                    Console.WriteLine("Aluno Aprovado");
                    Console.WriteLine("Media Final: " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aluno Reprovado");
                    Console.WriteLine("Media Final: " + MediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
