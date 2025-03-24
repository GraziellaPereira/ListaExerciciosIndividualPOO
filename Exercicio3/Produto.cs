using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3;
public class Produto
{
    public string nome;
    public double preco;
    public int quantidade, estoque;

    public void AdicionarEstoque()
    {
        Console.WriteLine($"Digite a quantidade de unidades de {nome} que serão adicionadas ao estoque: ");
        quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine($"{quantidade} unidades de {nome} adicionados(as) ao estoque.");
        estoque += quantidade;
    }
    public void Re
}
