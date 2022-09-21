using System;

namespace ExercicioURI1078tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for ( int i = 1; i <= 10; i=i + 1) {
                int valor = N * i;
                Console.WriteLine(i + " x " + N + " = " + valor);
                               
            }
        }
    }
}
