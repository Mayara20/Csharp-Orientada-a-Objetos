using System;

namespace Tipos_Basicos_de_dados {
    class Program {
        static void Main(string[] args) {

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            byte N1 = 126;
            int N2 = 1000;
            int N3 = 2147483647;
            long N4 = 2147483648L;
            float N5 = 4.5f;
            double N6 = 4.5;
            string nome = "Manoel Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int A1 = int.MinValue;
            int A2 = int.MaxValue;
            SByte A3 = sbyte.MinValue;
            decimal A4 = decimal.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(N1);
            Console.WriteLine(N2);
            Console.WriteLine(N3);
            Console.WriteLine(N4);
            Console.WriteLine(N5);
            Console.WriteLine(N6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(A1);
            Console.WriteLine(A2);
            Console.WriteLine(A3);
            Console.WriteLine(A4);
        }
    }
}
