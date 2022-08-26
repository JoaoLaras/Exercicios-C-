using System;

namespace Estrutura_Condicional___COMPOSTA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas Horas? ");
            int horas = int.Parse(Console.ReadLine());

            if (horas < 12) {
                Console.WriteLine("Bom dia! ");
            }
            else if ( horas < 18) { 
                Console.WriteLine("Boa tarde! ");
            }
            else { 
                Console.WriteLine("Boa Noite! ");
                
        }
            Console.ReadLine();
        }
    }
}
