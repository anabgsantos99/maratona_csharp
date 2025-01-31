


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 396.70D;
            double desconto = 0;
            double valorFinal = 0;

            if (valorCompra < 100)
            {
                desconto = 5;
                valorFinal = valorCompra - ((valorCompra * desconto) / 100);
                Console.WriteLine($"Foi aplicado um desconto de {desconto}% na sua compra de R${valorCompra:f2} e o valor final é: R${valorFinal:f2}");
            }
            else if (valorCompra > 100 && valorCompra < 300)
            {
                desconto = 10;
                valorFinal = valorCompra - ((valorCompra * desconto) / 100);
                Console.WriteLine($"Foi aplicado um desconto de {desconto}% na sua compra de R${valorCompra:f2} e o valor final é: R${valorFinal:f2}");
            }
            else
            {
                desconto = 15;
                valorFinal = valorCompra - ((valorCompra * desconto) / 100);
                Console.WriteLine($"Foi aplicado um desconto de {desconto}% na sua compra de R${valorCompra:f2} e o valor final é: R${valorFinal:f2}");
            }







            }
    }
}
