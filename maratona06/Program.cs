using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu primeiro nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = ($"{nome} {sobrenome}");

            Console.WriteLine(nomeCompleto);
        }
    }
}
