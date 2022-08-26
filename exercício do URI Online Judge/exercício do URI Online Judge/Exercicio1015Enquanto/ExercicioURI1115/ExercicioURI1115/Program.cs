using System;

namespace ExercicioURI1115 {
    class Program {
        static void Main(string[] args) {

            String[] vet = Console.ReadLine().Split(' ');
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            while (X != 0 && Y != 0) {
                if (X > 0 && Y > 0) {
                    Console.WriteLine("Primeiro");
                }
                else if (X < 0 && Y > 0) {
                    Console.WriteLine("Segundo");
                }
                else if (X < 0 && Y < 0) {
                    Console.WriteLine("Terceiro");
                }
                else {
                    Console.WriteLine("Quarto");
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}