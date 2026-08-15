using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace GestaoFinanceira {
    public class EntradaUsuario {

        private ContaBancaria minhaConta = new ContaBancaria();

   
        public void ExecutarMenu() {


            while (true) {

                Console.WriteLine("--- MENU PRINCIPAL ---\n");
                Console.WriteLine("SELECIONE UMA OPÇÃO: \n");
                Console.WriteLine("1 - ADICIONAR RECEITA\n2 - ADICIONAR DESPESA\n3 - EXTRATO BANCÁRIO\n0 - SAIR\n");
                string opcao = Console.ReadLine()!;


                if (opcao == "0") {
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar!");
                    break;
                }
                else if (string.IsNullOrWhiteSpace(opcao)) {
                    Console.Clear();
                    Console.WriteLine("Você não escolheu nenhuma opção!\nTente novamente...\n");

                }
                else if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "0") {
                    Console.Clear();
                    Console.WriteLine("Opção inválida!\n");
                    continue;
                
                }
               
                else if (opcao == "1") {

                    Console.Clear();

                    Console.Write("Digite o nome da receita: ");
                    string receitaDescricao = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(receitaDescricao)) {
                        Console.WriteLine("Por favor, informe um nome para sua receita!");
                        continue;
                    }

                    Console.Write("Digite o valor da receita: ");
                    string entrada = Console.ReadLine()!;

                   
                    if (double.TryParse(entrada, out double valorReceita)) {
                        Console.Clear();

                        minhaConta.AdicionarTransacao(new Receita(valorReceita, receitaDescricao));
                        Console.WriteLine("\n==================================\n");
                        Console.WriteLine("Receita cadastrada com sucesso!");
                        Console.WriteLine("\n==================================\n");
                    }
                   else {
                        Console.Clear();
                        Console.WriteLine("Por favor, digite algo válido!");
                        continue;
                    }
                    
                    
                }
                else if (opcao == "2") {
                    Console.Clear();
                    Console.Write("Digite o nome da despesa: ");
                    string despesaDescricao = Console.ReadLine()!;
                    if (string.IsNullOrWhiteSpace(despesaDescricao)) {
                        Console.WriteLine("Por favor, informe um nome para sua descrição!");
                        continue;
                    }

                    Console.Write("Digite o valor da despesa: ");
                    string entrada2 = Console.ReadLine()!;
                    if (double.TryParse(entrada2, out double valorDespesa)) {
                        Console.Clear();
                        Console.WriteLine("\n==================================\n");
                        Console.WriteLine("Despesa cadastrada com sucesso!");
                        Console.WriteLine("\n==================================\n");
                        minhaConta.AdicionarTransacao(new Despesa(valorDespesa, despesaDescricao));

                    }
                    else {
                        Console.Clear();
                        Console.WriteLine("Por favor, digite algo válido!");
                        continue;
                    }
                    
                }

                else if (opcao == "3") {
                    Console.Clear();
                    minhaConta.ExtratoBancário();
                }

            }
        }

    }
}
