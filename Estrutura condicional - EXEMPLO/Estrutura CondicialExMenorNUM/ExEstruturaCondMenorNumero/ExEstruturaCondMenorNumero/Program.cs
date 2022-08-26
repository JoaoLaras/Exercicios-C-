using System;

namespace ExEstruturaCondMenorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);

            if (A < B && A < C)
            {
                Console.WriteLine("MENOR = " + A);
            }

            else if (B < C)
            {
                Console.WriteLine("MENOR = " + B);
            }

            else
            {
                Console.WriteLine("MENOR = " + C);
            }

            Console.ReadLine();
        }

    }
}

