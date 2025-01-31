
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario = "ana_caetana";
            string senha = "12344321";

            Console.WriteLine("Digite o nome de usuário:");
            string usuarioDigitado = Console.ReadLine();

            Console.WriteLine("Digite a senha:");
            string senhaDigitada = Console.ReadLine();

           

            while (nomeUsuario != usuarioDigitado && senha != senhaDigitada)
            {
                
                Console.WriteLine("Digite o nome de usuário:");
                usuarioDigitado = Console.ReadLine();

                Console.WriteLine("Digite a senha:");
                senhaDigitada = Console.ReadLine();

                if (nomeUsuario != usuarioDigitado && senha != senhaDigitada)
                {
                Console.WriteLine("Credenciais incorretas");
                }
                else
                {
                Console.WriteLine("Login bem-sucedido");
                }
            }

            
        }
    }
}
