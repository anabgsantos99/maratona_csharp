using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laco02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cidades = { "São Paulo ", "Rio de Janeiro ", "Salvador", "João Pessoa", "São José dos Campos" };

            foreach (string cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

        }
    }
}
