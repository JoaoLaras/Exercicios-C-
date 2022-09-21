using System;

namespace ExemploVetoresForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            String[] Nomes = new string[N];

            for (int i = 0; i < N; i++)
            {
                Nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            foreach (string x in Nomes)
            {
                Console.WriteLine(x);
            }

        }   
    }
}
