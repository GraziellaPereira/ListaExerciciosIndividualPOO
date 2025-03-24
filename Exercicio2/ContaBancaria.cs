using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace contaBancariaMetodos 
{
    public class ContaBancaria
    {
        public string numeroConta, titular;
        public double saldo, valor;

        public void Depositar()
        {
            Console.WriteLine("Digite o valor que deseja depositar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            saldo += valor;
            Console.WriteLine($"Depósito de R${valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso. Para verificar o seu saldo atual, digite 3.");

        }
        public void Sacar()
        {
            Console.WriteLine("Digite o valor que deseja sacar: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            saldo -= valor;
            Console.WriteLine($"Saque de R${valor.ToString("F2", CultureInfo.InvariantCulture)} realizado com sucesso. Para verificar o seu saldo atual, digite 3.");
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R${saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }

    }
}

