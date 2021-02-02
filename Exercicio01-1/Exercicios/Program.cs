using System;
using System.Globalization;

namespace Exercicios {
    class Program {
        static void Main(string[] args) {

            int N, M;

            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());

            int soma = N + M;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
