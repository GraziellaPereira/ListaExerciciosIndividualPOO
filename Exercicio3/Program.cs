using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ProdutoMetodos;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            Console.WriteLine("Bem vindo ao controle de estoques.");
            Console.WriteLine("Digite o nome do produto: ");
            produto.nome = Console.ReadLine();
            Console.WriteLine("Agora digite o seu preço: ");
            produto.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            bool executando = true;

            while (executando)
            {
                Console.WriteLine("Digite o número da operação que será realizada: ");
                Console.WriteLine("1 - Adicionar ao estoque");
                Console.WriteLine("2 - Remover do estoque");
                Console.WriteLine("3 - Exibir detalhes do produto");
                Console.WriteLine("4 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        produto.AdicionarEstoque();
                        break;

                    case 2:
                        produto.RemoverEstoque();
                        break;

                    case 3:
                        produto.ExibirDetalhes();
                        break;

                    case 4:
                        executando = false;
                        Console.WriteLine("Encerrando o programa.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Digite um número de 1 a 4.");
                        break;
                }
            }
        }
    }
}
