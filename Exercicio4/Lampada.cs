using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampadaMetodos
{
    public class Lampada
    {
        public bool ligada;
        public string estado;

        public void Ligar()
        {
            Console.WriteLine("Ligando a lâmpada...");
            ligada = true;
            estado = "ligada";
            Console.ReadKey();
            Console.WriteLine("Lâmpada ligada!");
        }
        public void Desligar()
        {
            Console.WriteLine("Desligando a lâmpada...");
            ligada = false;
            estado = "desligada";
            Console.ReadKey();
            Console.WriteLine("Lâmpada desligada!");
        }
        public void MostrarEstado()
        {
            Console.WriteLine($"A lâmpada está {estado}.");
            Console.ReadKey();
        }
    }
}
