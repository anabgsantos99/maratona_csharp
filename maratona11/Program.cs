
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
            //Declarar nome de usuário e senha
            string nomeUsuario = "ana_caetana";
            string senha = "12344321";

            //Solicitar que o usuário digite o nome de usuário
            Console.WriteLine("Digite o nome de usuário:");
            string usuarioDigitado = Console.ReadLine();

            //Solicitar que inclua a senha
            Console.WriteLine("Digite a senha:");
            string senhaDigitada = Console.ReadLine();

            do
            {               
                if (nomeUsuario != usuarioDigitado && senha != senhaDigitada)
                {
                    //Exibir mensagem caso o login esteja incorreto
                    Console.WriteLine("Credenciais incorretas");
                    Console.WriteLine("Digite o nome de usuário:");
                    usuarioDigitado = Console.ReadLine();

                    Console.WriteLine("Digite a senha:");
                    senhaDigitada = Console.ReadLine();
                }
                else
                {
                    //Exibir mensagem caso o login esteja correto
                    Console.WriteLine("Login bem-sucedido");
                }

            } while (nomeUsuario != usuarioDigitado && senha != senhaDigitada);
            Console.WriteLine("Login bem-sucedido");



        }
    }
}
