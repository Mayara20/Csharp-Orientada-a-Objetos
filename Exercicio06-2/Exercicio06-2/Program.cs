using System;
using System.Globalization;

namespace Exercicio06_2 {
    class Program {
        static void Main(string[] args) {

            double M = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (M >= 0.0 && M <= 25.00) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (M >= 25.01 && M <= 50.00) {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (M >= 50.01 && M <= 75.00) {
                Console.WriteLine("Intevalo [50,75]");
            }
            else if (M >= 75.01 && M <= 100.00) {
                Console.WriteLine("Intervalo [75,100]");
            }
            else {
                Console.WriteLine("Fora do intervalo");
            }
        }
    }
}
