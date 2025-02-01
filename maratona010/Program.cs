using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solicitar dois números ao usuário
            Console.WriteLine("Digite dois números:");
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());

            //Solicitar que o usuário escolha a operação
            Console.WriteLine("Escolha uma operação:\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            int operacao = int.Parse(Console.ReadLine());

            //Exibir resultado de acordo com a escolha da operação
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