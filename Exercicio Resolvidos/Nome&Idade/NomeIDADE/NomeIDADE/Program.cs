using System;
using System.Globalization;

namespace NomeIDADE
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] vet1 = Console.ReadLine().Split(' ');

            String Nome1 = vet1[0];
            double Idade1 = int.Parse(vet1[1]);

            String[] vet2 = Console.ReadLine().Split(' ');

            String Nome2 = vet2[0];
            double Idade2 = int.Parse(vet2[1]);
            double Media = (Idade1 + Idade2) / 2.0;
            
            Console.WriteLine("A idade média de " + Nome1 + " e " + Nome2 + " é de " 
                + Media.ToString("F1", CultureInfo.InvariantCulture) + " anos");
            Console.ReadLine();
        }
    }
}
// using System;
//using System.Globalization;
//namespace Curso
//{
    //class Program
    //{
     //   static void Main(string[] args)
    //   {
     //       string nome1, nome2;
    //        int idade1, idade2;
    //        double media;
    //        string[] vet;
    //        vet = Console.ReadLine().Split(' ');
    //        nome1 = vet[0];
    //        idade1 = int.Parse(vet[1]);
     //       vet = Console.ReadLine().Split(' ');
//            nome2 = vet[0];
//            idade2 = int.Parse(vet[1]);
//           media = (double)(idade1 + idade2) / 2.0; <- casting //
//            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de "
//            + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");
//            Console.ReadLine();
//        }
//    }
//}

