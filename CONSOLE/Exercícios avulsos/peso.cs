using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double massa, altura, imc;

            Console.Write("Informe seu peso: ");
            massa = double.Parse(Console.ReadLine());

            Console.Write("Informe sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = massa / (altura * altura);

            Console.Clear();

            Console.Write("Seu imc é: ");
            Console.WriteLine(imc);
        }
    }
}
