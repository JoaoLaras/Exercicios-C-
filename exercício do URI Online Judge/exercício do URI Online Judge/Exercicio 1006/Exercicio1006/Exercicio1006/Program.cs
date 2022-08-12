using System;
using System.Globalization;
namespace Exercicio1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MedA, MedB, MedC, MedT, Notmax;
           A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Notmax = 10;
            MedA = A * 2;
            MedB = B * 3;
            MedC = C * 5;
            MedT = (MedA + MedB + MedC) / Notmax;
            Console.WriteLine("MEDIA = " + MedT.ToString("F1", CultureInfo.InvariantCulture));
                  
        }
    }
}

