using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite dois números para realizar cálculos matemáticos: ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            int sub = num1 - num2;
            int multi = num1 * num2;
            int div = num1 / num2;

            Console.WriteLine($"{num1} + {num2} = {soma}");
            Console.WriteLine($"{num1} - {num2} = {sub}");
            Console.WriteLine($"{num1} * {num2} = {multi}");
            Console.WriteLine($"{num1} / {num2} = {div}");





        }

    }
}
