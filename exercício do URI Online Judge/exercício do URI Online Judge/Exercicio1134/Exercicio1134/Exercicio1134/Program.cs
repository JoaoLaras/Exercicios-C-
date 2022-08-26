using System;

namespace Exercicio1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1)
                {
                    alcool = alcool + 1;

                }
                else if (tipo == 2)
                {
                    Gasolina = Gasolina + 1;

                }
                else if (tipo == 3)
                {
                    Diesel = Diesel + 1;

                }
             
            tipo = int.Parse(Console.ReadLine());
           
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);
        }
    }
}
