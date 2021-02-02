using System;
using System.Globalization;


namespace Problema_exemplo02_modelo {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();
            
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaX = x.Area();

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double AreaY = y.Area();

            Console.WriteLine("Área de X = " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + AreaY.ToString("F4", CultureInfo.InvariantCulture));

            if (AreaX > AreaY) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y"); 
            }
        }
    }
}
