using System;
using System.Globalization;

namespace Exercicio1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MediaA, MediaB, SomaMedia;
            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            MediaA = A * 3.5;
            MediaB = B * 7.5;
            SomaMedia = (MediaA + MediaB) / 11;
            Console.WriteLine("MEDIA = " + SomaMedia.ToString("F5", CultureInfo.InvariantCulture));
            
        }
    }
}
