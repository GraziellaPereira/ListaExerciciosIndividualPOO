using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoMetodos
{
    public class Aluno
    {
        public int RA;
        public string nome;
        public double notaProva1, notaProva2, notaTrabaho1, notaTrabaho2, notaFinal;

        public void ReceberDados()
        {
            Console.WriteLine("Vamos descobrir a nota final do aluno: ");
            Console.WriteLine("Digite o RA do aluno: ");
            RA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a nota da prova do primeiro bimestre: ");
            notaProva1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da prova do segundo bimestre: ");
            notaProva2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do trabalho do primeiro bimestre: ");
            notaTrabaho1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do trabalho do segundo bimestre: ");
            notaTrabaho2 = double.Parse(Console.ReadLine());
        }
        public void CalcularMedia()
        {
            notaFinal = ((notaProva1 + notaTrabaho1) + (notaProva2 + notaTrabaho2)) / 2;
        }

        public bool CalcularNotaFinal()
        {
            if (notaFinal >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
                Console.ReadKey();
                return true;
            } else
            {
                double notaNecessaria = 12 - notaFinal;
                Console.WriteLine($"Aluno reprovado. Nota necessária para a prova final: {notaNecessaria:F2}");
                return false;
            }
        }
        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota final: {notaFinal:F2}");
            Console.ReadKey();
        }
    }
}
