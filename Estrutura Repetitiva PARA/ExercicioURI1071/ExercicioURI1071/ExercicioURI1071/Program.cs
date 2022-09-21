using System;

namespace ExercicioURI1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, min, max;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y) {
                min = X;
                max = Y;

            }
            else {
                min = Y;
                max = X;

            }

            int soma = 0;
            for (int i=min+1; i<max; i=i+1) {
                if ( i % 2 != 0) {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}