using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
           

            Console.WriteLine("Cronograma escolar\n");
            Console.WriteLine("Informe o dia da semana\n");
            Console.WriteLine("1 - Domingo");
            Console.WriteLine("2 - Segunda-Feira");
            Console.WriteLine("3 - Terça-Feira");
            Console.WriteLine("4 - Quarta-Feira");
            Console.WriteLine("5 - Quinta-Feira");
            Console.WriteLine("6 - Sexta-Feira");
            Console.WriteLine("7 - Sábado");
            string op = Console.ReadLine();

            Console.Clear();

            switch (op){

                case "1":
                case "7":
                    Console.WriteLine("Não temos aula neste dia!");
                    break;

                case "2":
                    Console.WriteLine("Hoje temos aula de\n\nBanco de dados II - Professor Anderson\nPlanejamento de TCC - Professora Débora");
                    break;

                case "3":
                    Console.WriteLine("Hoje temos aula de\n\nInglês instrumental - Professor Charles\nInternet e Protocolos - Professor Edvaldo");
                    break;

                case "4":
                    Console.WriteLine("Hoje temos aula de\n\nProgramação de aplicativos mobile I - Professor Rafael");
                    break;

                case "5":
                    Console.WriteLine("Hoje temos aula de\n\nDesenvolvimento de Sistemas - Professores Rodrigo e Anderson");
                    break;

                case "6":
                    Console.WriteLine("Hoje temos aula de\n\nProgramação Web - Professor Rovilson");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
