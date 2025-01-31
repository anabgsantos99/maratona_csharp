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
            int num = 7;
            Console.WriteLine("A tabuada do 7 é:");

            for (int i = 1; i <= 10; i++)
            {
                int tabuada = num * i;
                Console.WriteLine($"{i} x {num} = {tabuada}");
            }
        }
    }
}
