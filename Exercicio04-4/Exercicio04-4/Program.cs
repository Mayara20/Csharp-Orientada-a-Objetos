using System;
using System.Globalization;

namespace Exercicio04_4 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {

                string[] vet = Console.ReadLine().Split(' ');
                int A = int.Parse(vet[0]);
                int B = int.Parse(vet[1]);

                if (B == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double resp = (double)A / B;
                    Console.WriteLine(resp.ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
