using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação: 1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite dois números:");
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    double soma = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {soma}");
                    break;
                case 2:
                    double subtracao = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {subtracao}");
                    break;
                case 3:
                    double multiplicacao = num1 * num2;
                    Console.WriteLine($"{num1} x {num2} = {multiplicacao}");
                    break;
                case 4:
                    double divisao = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {divisao}");
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }



            }
    }
}
