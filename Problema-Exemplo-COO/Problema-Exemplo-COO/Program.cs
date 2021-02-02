using System;
using System.Globalization;

namespace Problema_Exemplo_COO {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double P = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(P * (P - x.A) * (P - x.B) * (P - x.C));

            P = (y.A + y.B + y.C) / 2.0;
            double areay = Math.Sqrt(P * (P - y.A) * (P - y.B) * (P - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4" , CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areay.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areay) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
