using System;
using System.Globalization;

namespace Problema_Exemplo_while {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite um número: ");
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            

            while (N >= 0.0) {
                double raiz = Math.Sqrt(N);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número:");
                N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }  
            Console.WriteLine("Número negativo!");
        }
    }
}
