using System;

namespace Exemplo_base_csharp {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números: ");
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            int N3 = int.Parse(Console.ReadLine());

            double resultado = Maior(N1, N2, N3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int A, int B, int C) {
            int M;
            if (A > B && A > C) {
                M = A;
            }
            else if (B > C) {
                M = B;
            }
            else {
                M = C;
            }
            return M;
        }
    }
}
