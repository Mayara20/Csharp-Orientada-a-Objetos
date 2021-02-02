using System;
using System.Globalization;


namespace Exercicio02_4 {
    class Program {
        static void Main(string[] args) {

            int cont_in = 0;
            int cont_out = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                int M = int.Parse(Console.ReadLine());
                if (M >= 10 && M <= 20) {
                    cont_in++;
                }
                else {
                    cont_out++;
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }
}
