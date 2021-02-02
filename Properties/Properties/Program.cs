using Course;
using System;
using System.Globalization;

namespace Properties {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00, 15);

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
