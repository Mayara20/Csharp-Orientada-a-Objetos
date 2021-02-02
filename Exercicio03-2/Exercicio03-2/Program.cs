using System;

namespace Exercicio03_2 {
    class Program {
        static void Main(string[] args) {

            int A, B;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);

            if (A % 2 ==0 && B % 2 == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
