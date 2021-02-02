using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_2_do_exercicio_de_fixacao {
    class DadosBancarios {

        public int Conta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public DadosBancarios(int conta, string nome) {
            Conta = conta;
            Nome = nome;
        }

        public DadosBancarios(int conta, string nome, double depositoInicial): this(conta, nome) {
            deposito(depositoInicial);
        }
        public void deposito(double total) {
            Saldo += total;
        }
        public void saque(double total) {
            Saldo -= total + 5.00;
        }
        public override string ToString() {
            return " Conta " 
                + Conta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
