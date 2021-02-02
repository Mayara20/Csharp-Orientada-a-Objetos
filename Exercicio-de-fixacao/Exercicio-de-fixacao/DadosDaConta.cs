using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_de_fixacao {
    class DadosDaConta {

        public int Conta { get; private set; }
        public string NomeTitular { get; set; }

        public double ValorInicial { get; private set; }

        public DadosDaConta(int conta, string nomeTitular) {
            Conta = conta;
            NomeTitular = nomeTitular;
        }
        public DadosDaConta(int conta, string nomeTitular, double valorInicial) : this(conta, nomeTitular) {
            ValorInicial = valorInicial;
        }
        public void deposito(double total) {
            ValorInicial += total;
        }
        public void saque(double total) {
            ValorInicial -= total + 5.0;
        }
        public override string ToString() {
            return " Conta "
                + Conta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: $ "
                + ValorInicial.ToString("F2", CultureInfo.InvariantCulture)
                ; 
        }




    }
}
