using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFinanceira {
    public class ContaBancaria {
        public double Saldo { get; private set; }
        List<ITransacao> Historico = new List<ITransacao>();

        public void AdicionarTransacao(ITransacao transacao) {
            Historico.Add(transacao);

            if (transacao is Receita) {
                Saldo += transacao.Valor;
            }
            else if (transacao is Despesa) {
                Saldo -= transacao.Valor;
            }

        }
        public void ExtratoBancário() {

            Console.WriteLine($"\n=== EXTRATO BANCÁRIO ===\n");

            foreach (var item in Historico) {
                item.ExibirDetalhe();
            }
            if (Saldo < 0) {
                Console.WriteLine($"\n[ATENÇÃO] SALDO NEGATIVO! {Saldo:C}");
                Console.WriteLine("\n=========================\n");
            }
            else {
                Console.WriteLine($"\nSALDO ATUAL = {Saldo:C}");
                Console.WriteLine("\n=========================\n");
            }
           
        }

    }

}
