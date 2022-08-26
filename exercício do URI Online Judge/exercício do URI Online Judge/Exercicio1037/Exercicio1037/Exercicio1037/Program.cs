using System;
using System.Globalization;

namespace Exercicio1037 {
    class Program {
        static void Main(string[] args) {

            double Entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            if (Entrada < 0 || Entrada > 100) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (Entrada <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (Entrada <= 50.0) {                
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (Entrada <= 75.0){
                 Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
