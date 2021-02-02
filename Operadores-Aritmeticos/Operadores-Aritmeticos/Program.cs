using System;

namespace Operadores_Aritmeticos {
    class Program {
        static void Main(string[] args) {

            int N1 = 3 + 4 * 2;
            int N2 = (3 + 4) * 2;
            int N3 = 17 % 3;
            double N4 = 10.0 / 8;

            double A = 1.0, B = -3.0, C = -4.0;

            double delta = (B * B) - 4 * A * C;

            double X1 = (-B + Math.Sqrt(delta)) / (2.0 * A);
            double X2 = (-B - Math.Sqrt(delta)) / (2.0 * A);

            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4);
            Console.WriteLine(delta);
            Console.WriteLine(X1);
            Console.WriteLine(X2);
        }
    }
}
