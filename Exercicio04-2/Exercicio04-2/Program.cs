using System;

namespace Exercicio04_2 {
    class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(vet[0]);
            int horaFinal = int.Parse(vet[1]);

            int tempo;

            if (horaInicial < horaFinal) {
                tempo = horaFinal - horaInicial;
            }
            else {
                tempo = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU " + tempo + " HORA(S) ");
        }
    }
}
