using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 32;
            string z = "Joao";
            char w = 'M';

            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até Mais");

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Resultado=" + x + " Reais");
            Console.WriteLine("O valor do troco é " + x + " Reais");
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " Reais");

            Console.WriteLine();
            Console.WriteLine(" A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
            Console.ReadLine();
        }

    }





    }