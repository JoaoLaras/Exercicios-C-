using System;
using System.Globalization;
namespace Exercicio1041
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = (Console.ReadLine().Split(' '));
            double X= double.Parse(vet[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if ( X == 0.0 && Y == 0.0) {
                Console.WriteLine("Origem");

            }

            else if ( X > 0.0 && Y > 0.0) {
                Console.WriteLine("Q1");
            }

            else if (X < 0.0 && Y > 0.0) {
                Console.WriteLine("Q2");
            }

            else if (X < 0.0 && Y < 0.0) {
                Console.WriteLine("Q3");

            }
            else {
                Console.WriteLine("Q4");

            }   
        }   
    }
}
