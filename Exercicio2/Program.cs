using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using contaBancariaMetodos;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            Console.WriteLine("Bem vindo ao caixa eletrônico!");
            Console.WriteLine("Digite o número da conta bancária: ");
            conta.numeroConta = Console.ReadLine();
            Console.WriteLine("Digite o nome do titular: ");
            conta.titular = Console.ReadLine();

            bool executando = true;
            while (executando) { 
                Console.WriteLine("Digite o número da operação que será realizada: ");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Exibir saldo");
                Console.WriteLine("4 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        conta.Depositar();
                        break;

                    case 2:
                        conta.Sacar();
                        break;

                    case 3:
                        conta.ExibirSaldo();
                        break;

                    case 4:
                        executando = false;
                        Console.WriteLine("Sistema encerrado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Digite um número de 1 a 4!");
                        break;
                }

            }
        }
    }
}
