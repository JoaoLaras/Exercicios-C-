using System;
using System.Globalization;
namespace Exercicio1012_Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet1 = Console.ReadLine().Split(' ');
            double A = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet1[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            double AreaTrianguloRet = (A * C) / 2.0; //A área de um triângulo retângulo, basta dividir por 2 o resultado da multiplicação da base (b) pela altura (h).
            Console.WriteLine("TRIANGULO: " + AreaTrianguloRet.ToString("F3", CultureInfo.InvariantCulture));

            double AreaCirculoRaio = Math.Pow(C , 2.0) * 3.14159; //A área de um círculo é pi vezes o raio elevado ao quadrado.
            Console.WriteLine("CIRCULO: " + AreaCirculoRaio.ToString("F3", CultureInfo.InvariantCulture));

            double AreaTrapezio = ((A + B) * C) / 2; //A área do trapézio é a soma das bases vezes a altura dividido por dois.
            Console.WriteLine("TRAPEZIO: " + AreaTrapezio.ToString("F3", CultureInfo.InvariantCulture));

            double AreaLado = Math.Pow(B, 2.0);// Para fazer o cálculo da área do quadrado é necessário realizar o produto entre dois lados. Como o quadrado tem lados iguais, basta pegar a medida de um dos lados e elevar ao quadrado. Para a realização usamos a fórmula da área A = b.
            Console.WriteLine("QUADRADO: " + AreaLado.ToString("F3", CultureInfo.InvariantCulture));
         
            double AreaRetangulo = A * B; // A área do quadrado e do retângulo é calculada multiplicando a medida do comprimento pela medida da largura.
            Console.WriteLine("RETANGULO: " + AreaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }   
    }
}
