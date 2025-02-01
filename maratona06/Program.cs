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
           //Solicite que o usuário digite o primeiro nome
            Console.WriteLine("Digite seu primeiro nome");
            string nome = Console.ReadLine();

            //Solicite que o usuário digite o sobrenome
            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();

            //Junte as variáveis
            string nomeCompleto = ($"{nome} {sobrenome}");

            //Exiba o nome concatenado
            Console.WriteLine(nomeCompleto);
        }
    }
}
