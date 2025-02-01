using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona04._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar que o usuário digite a idade
            Console.WriteLine("Escreva sua idade");
            int idade = int.Parse(Console.ReadLine());

            //Exibir mensagem de acordo com a faixa etária do usuário
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
