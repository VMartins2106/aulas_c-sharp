using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raio
{
    class Program
    {
        static void Main(string[] args)
        {
            float raio, pi = 3.14F, comprimento, area;

            Console.Write("Informe o valor do raio da circunferência: ");
            raio = float.Parse(Console.ReadLine());

            comprimento = 2 * pi * raio;
            area = pi * (raio*raio);

            Console.Clear();

            Console.Write("O valor do comprimento da circunferência é de " + comprimento);
            Console.Write("\nO valor da área da circunferência é de " + area);

            Console.ReadKey();
        }
    }
}
