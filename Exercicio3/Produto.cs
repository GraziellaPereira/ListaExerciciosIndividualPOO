using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProdutoMetodos;
public class Produto
{
    public string nome;
    public double preco;
    public int quantidade, estoque;

    public void AdicionarEstoque()
    {
        Console.WriteLine($"Digite a quantidade de unidades de {nome} que serão adicionadas ao estoque: ");
        quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"{quantidade} unidade(s) de {nome} adicionados(as) ao estoque.");
        estoque += quantidade;
    }
    public void RemoverEstoque()
    {
        Console.WriteLine($"Digite a quantidade de unidades de {nome} que serão removidas do estoque: ");
        quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine($"{quantidade} unidade(s) de {nome} removidos(as) do estoque.");
        estoque -= quantidade;
        Console.ReadKey();
    }
    public void ExibirDetalhes()
    { double precoTotal = preco * estoque;
        Console.WriteLine($"Nome do produto: {nome}");
        Console.WriteLine($"Quantidade total do produto em estoque: {estoque}");
        Console.WriteLine($"Preço do estoque total do produto: {precoTotal:F2}");
        Console.ReadKey();
    }
}
