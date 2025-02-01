


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
            //Declarar variáveis
            double valorCompra;
            double desconto;
            double valorFinal;

            //Solicitar valor da compra 
            Console.WriteLine("Digite o valor da compra:");
            valorCompra = double.Parse(Console.ReadLine());


            if (valorCompra < 100)
            {
                //Calcular o desconto de compras até 100R$
                desconto = 5;
                valorFinal = valorCompra - ((valorCompra * desconto) / 100);
                //Exibir desconto e valor final
                Console.WriteLine($"Foi aplicado um desconto de {desconto}% na sua compra e o valor final é: R${valorFinal}");
            }
            else if (valorCompra > 100 && valorCompra < 300)
            {
                //Calcular o desconto de compras entre 100,01 a 300R$
                desconto = 10;
                valorFinal = valorCompra - ((valorCompra * desconto) / 100);
                //Exibir desconto e valor final
                Console.WriteLine($"Foi aplicado um desconto de {desconto}% na sua compra e o valor final é: R${valorFinal}");
            }
            else
            {
                //Calcular desconto de compras acima de 300R$
                desconto = 15;
                valorFinal = valorCompra - ((valorCompra * desconto) / 100);
                //Exibir desconto e valor final
                Console.WriteLine($"Foi aplicado um desconto de {desconto}% na sua compra e o valor final é: R${valorFinal}");
            }







            }
    }
}
