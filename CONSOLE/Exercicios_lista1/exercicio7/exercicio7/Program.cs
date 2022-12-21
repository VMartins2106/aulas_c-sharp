using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("\nInforme um valor entre 12 e 20: ");
                int num = int.Parse(Console.ReadLine());

                if (num >=12 && num <= 20)
                {
                    Console.WriteLine("Este número está entre 12 e 20");
                }
                else if (num <12 && num >20)
                {
                    Console.WriteLine("Entrada inválida");
                }
                else if (num == 0)
                {
                    Console.WriteLine("Programa finalizado!");
                }
            }

            Console.ReadKey();
        }
    }
}
