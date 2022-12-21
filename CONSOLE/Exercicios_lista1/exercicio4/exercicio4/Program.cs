using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, par, impar;
            par = 0;
            impar = 0;
            
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("\nInforme os valores: ");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Este número é par (" + num + ")");
                    par += 1;
                }
                else
                {
                    Console.WriteLine("Este número ímpar (" + num + ")");
                    impar += 1;
                }
            }

            Console.WriteLine("Você digitou " + par + " números pares e " + impar + " números ímpares");

            Console.ReadKey();
        }
    }
}
