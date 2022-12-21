using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, desconto = 0.86F, final;

            Console.Write("Informe seu salário: ");
            salario = float.Parse(Console.ReadLine());

            Console.Clear();

            final = salario * desconto;

            Console.Write("Seu salário líquido é de: " + final);

            Console.ReadKey();
        }
    }
}
