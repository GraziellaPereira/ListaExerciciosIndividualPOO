using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlunoMetodos;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.ReceberDados();
            aluno.CalcularMedia();
            aluno.ImprimirNotaFinal();
            bool aprovado = aluno.CalcularNotaFinal();

            if (aprovado) {
                Console.WriteLine("Status: Aprovado.");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Status: Reprovado.");
                Console.ReadKey();
            }
        }
    }
}
