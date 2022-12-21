using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i <= 10000; i++)
            {
                if ((i % 5 == 0) && (i % 9 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Múltiplo de 5 e 9: " + i);
                }
            }
            Console.ReadKey();
        }
    }
}