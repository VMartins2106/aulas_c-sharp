using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escolha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //ENTRADA

            Console.Write("Calculadora");

            Console.WriteLine("Escolha uma das opções: ");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int op = int.Parse(Console.ReadLine());


            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int final;

            //PROCESSAMENTO

            switch (op){

                case 1:
                    final = n1 + n2;
                    break;

                case 2:
                    final = n1 - n2;
                    break;

                case 3:
                    final = n1 * n2;
                    break;

                case 4:
                    final = n1 / n2;
                    break;

                default:
                    final = 0;
                    Console.Write("Opção inválida! Escolha novamente");
                    break;
            }

            //SAÍDA

            Console.WriteLine("O resultado é de: " + final);

            Console.ReadKey();
        }
    }
}
