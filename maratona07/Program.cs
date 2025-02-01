using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar um int com valor 7
            int num = 7;
            Console.WriteLine("A tabuada do 7 é:");

            //Loop for para gerar tabuada de multiplicação do valor previamente atribuido
            for (int i = 1; i <= 10; i++)
            {
                int tabuada = num * i;
                //Exibir tabuada
                Console.WriteLine($"{i} x {num} = {tabuada}");
            }
        }
    }
}
