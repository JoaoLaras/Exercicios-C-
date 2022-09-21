using System;

namespace Exercicio6Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] Nomes = new string[N];
            int[] Idades = new int[N];

            //LENDO DADOS
            for (int i = 0; i < N; i++)
            {
                String[] VetAux = Console.ReadLine().Split(' ');
                Nomes[i] = VetAux[0];
                Idades[i] = int.Parse(VetAux[1]);
            }
            // PESSOA MAIS VELHA

            int idademaior = Idades[0];
            string pessoavelha = Nomes[0];
            for (int i = 0; i < N; i++)
            {
                if (Idades[i] > idademaior)
                {
                    idademaior = Idades[i];
                    pessoavelha = Nomes[i];
                }
            }
            Console.WriteLine("Pessoa mais velha: " + pessoavelha + ", " + "com a idade de: " + idademaior + " anos");

        }
    }
}
