using System;
using System.Globalization;

namespace AreaPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double Base, Altura, Area, Perimetro, Diagonal;

            Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Base * Altura;
            Perimetro = 2 * Base + 2 * Altura; // ou 2 * ( Base + Altura) <---
            Diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(Altura, 2.0)); //Base² = Base * Base <---
                                                                               // Math.Sqrt = Raiz Quadrada< ---
                                                                               // Math.Pow = Elevado - Base, 2.0 <--- = Base elevado a 2.
            Console.WriteLine("AREA = " + Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Diagonal.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
