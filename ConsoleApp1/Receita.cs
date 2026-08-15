using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFinanceira {
    internal class Receita : ITransacao {

        public double Valor { get; }
        public string Descricao { get; }

        public Receita(double valor, string descricao) {
            Valor = valor;
            Descricao = descricao;

        }
        public void ExibirDetalhe() {
            Console.WriteLine($"[RECEITA] {Descricao} = {Valor:C}");
        }
    }
}
