using System;

namespace Exercicio2Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] Numeros = new int[N];
            

            string[] VetAux = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                Numeros[i] = int.Parse(VetAux[i]);

            }

            //MOSTRANDO NUMEROS PARES
            foreach (int Numerospares in Numeros)
            {

                if (Numerospares % 2 == 0)
                {
                    Console.Write(Numerospares + " ");

                }
            }
            Console.WriteLine();

            // MOSTRANDO A QUANTIDADE DE PARES

            int cont = 0;
            foreach (int quantidadedepares in Numeros)
            {
                if (quantidadedepares % 2 == 0)
                {
                    cont++;
                }
            }

            Console.WriteLine(cont);

        }
    }
}
