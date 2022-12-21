using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("Múltiplo de 10: " + i);
                }
                else {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
