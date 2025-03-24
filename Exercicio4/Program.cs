using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LampadaMetodos;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lampada = new Lampada();
            Console.WriteLine("Interaja com a lâmpada!");
            bool executando = true;
            while (executando) {
                Console.WriteLine("Digite a alternativa correspondente: ");
                Console.WriteLine("1 - Ligar");
                Console.WriteLine("2 - Desligar");
                Console.WriteLine("3 - Status da lâmpada");
                Console.WriteLine("4 - Sair");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        lampada.Ligar();
                        break;

                    case 2:
                        lampada.Desligar(); 
                        break;

                    case 3:
                        lampada.MostrarEstado();
                        break;

                    case 4:
                        Console.WriteLine("Sistema encerrado.");
                        executando = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Digite entre 1 a 4.");
                        break;
                }

            }

        }
    }
}
