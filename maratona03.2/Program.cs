using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona03._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar array com o nome de cidades 
            string[] cidades = { "São Paulo ", "Rio de Janeiro ", "Salvador", "João Pessoa", "São José dos Campos" };
            //Criar laço para exibir todas as cidades 
            foreach (string cidade in cidades)
            {
                Console.WriteLine(cidade);
            }
        }
    }
}
