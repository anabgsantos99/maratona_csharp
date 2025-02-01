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
            //Declarar double e atribuir valor desejado
            double valorCompra = 200.01D;

            //Condicional para sistema de desconto
            if (valorCompra > 200)
            {
                double desconto = (valorCompra * 10) / 100; // Calcular desconto
                double valorFinal = valorCompra - desconto; //Calcular valor final
                //Exibir desconto 
                Console.WriteLine($"Desconto de 10% aplicado! Sua compra de R${valorCompra:f2} foi para R${valorFinal:f2}");
            }
            else //Exibir mensagem caso o valor seja abaixo de 200 reais
            {
                Console.WriteLine("Adicione mais itens ao carrinho para ganhar um desconto de 10 %.");
            }
        }
    }
}
