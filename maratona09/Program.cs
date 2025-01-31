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

            string produto = "Playstation 5";
            double preco = 3099.90D;
            int quantidade = 0;

            Console.WriteLine($"O Produto selecionado foi: {produto}.\nPreço: R${preco}");
            if (quantidade == 0)
            {
                Console.WriteLine("Produto fora de estoque.");
            }
            else
            {
                Console.WriteLine($"Estoque: {quantidade}");
            }
               
           
        }
    }
}
