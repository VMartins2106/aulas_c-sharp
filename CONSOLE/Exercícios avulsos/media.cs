using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, media;

            Console.Write("Informe o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());

            Console.Write("Informe o quarta valor: ");
            n4 = int.Parse(Console.ReadLine());

            Console.Write("Informe o quinto valor: ");
            n5 = int.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4 + n5) / 5;

            Console.Clear();

            Console.Write("Sua média é: " + media);

            Console.ReadKey();
        }
    }
}
