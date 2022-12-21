using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int i = 1;

            while (i != 0)
            {
                Console.WriteLine("Digite um valor: ");
                i = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }
    }
}
