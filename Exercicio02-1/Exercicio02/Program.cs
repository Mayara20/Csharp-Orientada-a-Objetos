using System;
using System.Globalization;

namespace Exercicio02 {
    class Program {
        static void Main(string[] args) {

            double raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double P = 3.14159;
            
            area = P * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
