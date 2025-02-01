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
            //Solicite que o usuário digite o raio
            Console.WriteLine("Escreva o valor do raio do círculo que deseja calcular? ");
            int raio = int.Parse(Console.ReadLine());

            //Declare a constante pi
            const double pi = 3.14159D;

            //Calcular o diametro 
            double diametro = Math.Pow(raio, 2);

            //Calcular a área
            double area = pi * diametro;

            //Exibir a área
            Console.WriteLine($"A área de um círculo de raio: {raio} é {area:f2}");
        }
    }
}
