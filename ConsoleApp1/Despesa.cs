using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFinanceira {
    internal class Despesa : ITransacao {
        public double Valor { get; }
        public string Descricao { get; }

        public Despesa(double valor, string descricao) {
            Valor = valor;
            Descricao = descricao;
        }
        public void ExibirDetalhe() {
            Console.WriteLine($"[DESPESA] {Descricao} = {Valor:C}");
        }
    }
}
