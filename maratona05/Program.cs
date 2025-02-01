using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sistema de Segurança com bool 
            //Declare um variável bool
            bool usuarioLogado = false;

            
            if (usuarioLogado) //Exibir mensagem caso usuário esteja logado
            {
                Console.WriteLine("O usuário está logado");
            }
            else //Exibir mensagem caso usuário não esteja logado
            {
                Console.WriteLine("O usuário não está logado");
            }
        }
    }
}
