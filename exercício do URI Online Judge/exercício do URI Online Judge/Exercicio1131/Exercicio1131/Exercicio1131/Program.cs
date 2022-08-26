using System;

namespace Exercicio1131
{
    class Program
    {
        static void Main(string[] args) {

            int NovaGrenal = 1;
            int InterVenc = 0;
            int ContadoradeJogos = 0;
            int GremioVenc = 0;
            int Empate = 0;
                       
            while (NovaGrenal == 1) {
                string[] vet = Console.ReadLine().Split(' ');
                int Inter = int.Parse(vet[0]);
                int Gremio = int.Parse(vet[1]);

                if (Inter > Gremio) {
                    InterVenc = InterVenc + 1;
                    ContadoradeJogos = ContadoradeJogos + 1;

                }
                else if (Gremio > Inter) {
                    GremioVenc = GremioVenc + 1;
                    ContadoradeJogos = ContadoradeJogos + 1;

                }
                else {
                    Empate = Empate + 1;

                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                NovaGrenal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(ContadoradeJogos + " grenais");
            Console.WriteLine("Inter: " + InterVenc);
            Console.WriteLine("Gremio: " + GremioVenc);
            Console.WriteLine("Empates:" + Empate);
            
            if (InterVenc > GremioVenc) {
                Console.WriteLine("Inter venceu mais");

            }
            else if (GremioVenc > InterVenc) {
                Console.WriteLine("Gremio venceu mais");

            }
            else {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}