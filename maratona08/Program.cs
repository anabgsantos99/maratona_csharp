using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 200.01D;

            if (valorCompra > 200)
            {
                double desconto = (valorCompra * 10) / 100;
                Console.WriteLine("Desconto de 10% aplicado!");
            }
            else
            {
                Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10 %.");
            }
        }
    }
}
