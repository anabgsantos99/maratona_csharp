using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variáveis
            string produto = "";
            double preco = 0;
            int quantidade = 0;

            //Solicitar nome do produto
            Console.WriteLine("Digite o produto:");
            produto = Console.ReadLine();

            //Solicitar preço do produto
            Console.WriteLine("Digite o preço:");
            preco = double.Parse(Console.ReadLine());

            //Solicitar quantidade do produto
            Console.WriteLine("Digite o quantidade:");
            quantidade = int.Parse(Console.ReadLine());

            //Exibir produto e preço
            Console.WriteLine($"O Produto selecionado foi: {produto}.\nPreço: R${preco}");
            
            
            if (quantidade == 0)
            {
                //Exibir estoque caso a quantidade seja 0
                Console.WriteLine("Produto fora de estoque.");
            }
            else
            {
                //Exibir estoque caso a quantidade seja maior que zero
                Console.WriteLine($"Estoque: {quantidade}");
            }
               
           
        }
    }
}
