using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o valor do raio do círculo que deseja calcular? ");
            int raio = int.Parse(Console.ReadLine());

            const double pi = 3.14159D;

            double diametro = Math.Pow(raio, 2);

            double area = pi * diametro;

            Console.WriteLine($"A área de um círculo de raio: {raio} é {area:f2}");
        }
    }
}
