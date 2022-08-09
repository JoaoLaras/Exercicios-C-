using System;
using System.Globalization;

namespace ExerciciodeFixação
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Entre com seu nome Completo: ");
            string nome =Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um preço de um produto: ");
            double  preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade, e altura (mesma linha): ");
            String[] nia = Console.ReadLine().Split(' ');
            String sn = nia[0];
            int idade = int.Parse(nia[1]);
            double alt = double.Parse(nia[2],CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(sn);
            Console.WriteLine(idade);
            Console.WriteLine(alt.ToString(CultureInfo.InvariantCulture));

            
        }
    }
}
