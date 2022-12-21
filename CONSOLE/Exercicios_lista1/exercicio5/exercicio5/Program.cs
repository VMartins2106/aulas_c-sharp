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
            int i = 1, qtd, soma;
            qtd = 0;
            soma = 0;

            while (i != 0)
            {
                Console.WriteLine("Digite um valor: ");
                i = int.Parse(Console.ReadLine());
                qtd += 1;
                soma += i;
            }

            Console.WriteLine("A quantidade de valores digitados é de: " + qtd);
            Console.WriteLine("A soma de valores digitados é de: " + soma);

            Console.WriteLine("Programa finalizado!");
            Console.ReadKey();
        }
    }
}
