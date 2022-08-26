using System;

namespace Exemplo1046
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            int HoraInicial = int.Parse(vet[0]);
            int HoraFinal = int.Parse(vet[1]);

            int duracao;

            if (HoraInicial < HoraFinal) {
                duracao = HoraFinal - HoraInicial;

            }
            else {
                duracao = 24 - HoraInicial + HoraFinal;

            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
