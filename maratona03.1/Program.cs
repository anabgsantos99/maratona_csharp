using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maratona03._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int i = 1;
            Console.WriteLine("Os números ímpares entre 1 e 100 são:"); //Título

            //Laço de 1 a 100
            while (i <= 100)
            {
                if (i % 2 != 0) //identificar números ímpares
                {
                    Console.WriteLine(i); //Exibir números
                }
                i++;
            }
        
        }
    }

}
