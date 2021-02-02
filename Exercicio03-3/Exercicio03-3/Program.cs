using System;

namespace Exercicio03_3 {
    class Program {
        static void Main(string[] args) {

            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            int C = int.Parse(Console.ReadLine());

            while (C != 4) {
                if (C == 1) {
                    Alcool++;
                }
                else if (C == 2) {
                    Gasolina++;
                }
                else if(C == 3) {
                    Diesel++;
                }
                C = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);
        }
    }
}
