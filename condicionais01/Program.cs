using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicionais01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 12)
            {
                Console.WriteLine("Criança");
            }
            else if (idade >= 12 && idade < 18)
            {
                Console.WriteLine("Adolescente");
            }
            else
            {
                Console.WriteLine("Adulto");
            }
                    
            
        }
    }
}
