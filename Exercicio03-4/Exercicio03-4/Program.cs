using System;
using System.Globalization;

namespace Exercicio03_4 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) { 

            string[] J = Console.ReadLine().Split(' ');
            double A = double.Parse(J[0], CultureInfo.InvariantCulture);
            double B = double.Parse(J[1], CultureInfo.InvariantCulture);
            double C = double.Parse(J[2], CultureInfo.InvariantCulture);

            double Media = (A * 2.0 + B * 3.0 + C * 5.0) / 10.0;
            Console.WriteLine(Media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
