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
            int i, qtd;
            qtd = 0;

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("\nInforme os valores: ");
                int num = int.Parse(Console.ReadLine());

                if (num>=10 && num<=20)
                {
                    Console.WriteLine("Este número está entre 10 e 20");
                    qtd += 1;
                }
                else
                {
                    Console.WriteLine("Este número está fora do intervalo entre 10 e 20");
                }
            }

            Console.WriteLine("A quantidade de valores entre 10 e 20 é de: " + qtd);
            Console.ReadKey();
        }
    }
}
