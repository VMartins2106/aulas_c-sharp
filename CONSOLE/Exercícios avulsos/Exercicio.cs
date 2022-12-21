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
            Console.WriteLine("Escolha um exercicio: ");
            Console.WriteLine("Opção 1: Exercício de escolhas");
            Console.WriteLine("Opção 2: Exercício das aulas");
            Console.WriteLine("Opção 3: Exercicio de conversão");
            Console.WriteLine("Opção 4: Exercicio de natalidade e mortalidade");
            Console.WriteLine("Opção 5: Exercício de ano bissexto");
            Console.WriteLine("Opção 6: Exercício da pizzaria");
            int exe = int.Parse(Console.ReadLine());

            switch (exe)
            {

                case 1:
                    Console.Clear();
                    //ENTRADA

                    Console.Write("Calculadora");

                    int op;

                    Console.WriteLine("Escolha uma das opções: ");

                    Console.WriteLine("1 - Soma");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");
                    op = int.Parse(Console.ReadLine());


                    Console.Clear();
                    Console.Write("Digite o primeiro número: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    int n2 = int.Parse(Console.ReadLine());

                    int final;

                    //PROCESSAMENTO

                    switch (op)
                    {

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
                            Console.Clear();
                            final = 0;
                            Console.Write("Opção inválida! Escolha novamente");
                            break;
                    }

                    //SAÍDA

                    Console.WriteLine("O resultado é de: " + final);

                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
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
                    string op1 = Console.ReadLine();

                    Console.Clear();

                    switch (op1)
                    {

                        case "1":
                        case "7":
                            Console.Clear();
                            Console.WriteLine("Não temos aula neste dia!");
                            break;

                        case "2":
                            Console.Clear();
                            Console.WriteLine("Hoje temos aula de\n\nBanco de dados II - Professor Anderson\nPlanejamento de TCC - Professora Débora");
                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("Hoje temos aula de\n\nInglês instrumental - Professor Charles\nInternet e Protocolos - Professor Edvaldo");
                            break;

                        case "4":
                            Console.Clear();
                            Console.WriteLine("Hoje temos aula de\n\nProgramação de aplicativos mobile I - Professor Rafael");
                            break;

                        case "5":
                            Console.Clear();
                            Console.WriteLine("Hoje temos aula de\n\nDesenvolvimento de Sistemas - Professores Rodrigo e Anderson");
                            break;

                        case "6":
                            Console.Clear();
                            Console.WriteLine("Hoje temos aula de\n\nProgramação Web - Professor Rovilson");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            break;
                    }

                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Conversão de tempo");

                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine("1 - dias para horas");
                    Console.WriteLine("2 - horas para minutos");
                    Console.WriteLine("3 - minutos para segundos");
                    int op2 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (op2)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("Informe a quantidade de dias: ");
                            int dia = int.Parse(Console.ReadLine());
                            int horas = dia * 24;
                            Console.WriteLine("O número" + " " + dia + " " + "dá" + " " + horas + " " + "horas.");
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Informe a quantidade de horas: ");
                            horas = int.Parse(Console.ReadLine());
                            int min = horas * 60;
                            Console.WriteLine("O número" + " " + horas + " " + "dá" + " " + min + " " + "minutos.");
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Informe a quantidade de minutos: ");
                            min = int.Parse(Console.ReadLine());
                            int seg = min * 60;
                            Console.WriteLine("O número" + " " + min + " " + "dá" + " " + seg + " " + "segundos.");
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            break;
                    }

                    break;

                case 4:
                    Console.Clear();

                    string op3;

                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine("A - taxa de natalidade");
                    Console.WriteLine("B - taxa de mortalidade");
                    op3 = Console.ReadLine();

                    switch (op3)
                    {

                        case "A":
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Informe o número de nascimentos: ");
                            int nasc = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o número de habitantes: ");
                            int hab1 = int.Parse(Console.ReadLine());

                            int nat = (nasc * 1000) / hab1;
                            Console.WriteLine("A taxa de natalidade é de:" + " " + nat);
                            break;

                        case "B":
                        case "b":
                            Console.Clear();
                            Console.WriteLine("Informe o número de óbitos: ");
                            int obt = int.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o número de habitantes: ");
                            int hab2 = int.Parse(Console.ReadLine());

                            int mort = (obt * 1000) / hab2;
                            Console.WriteLine("A taxa de mortalidade é de:" + " " + mort);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                    break;

                case 5:
                    Console.Clear();

                    Console.WriteLine("Dias do mês");
                    Console.WriteLine("Informe um número respectivo a um mês (1-12): ");
                    int d = int.Parse(Console.ReadLine());

                    switch (d)
                    {

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Informe o ano atual: ");
                            int ano = int.Parse(Console.ReadLine());

                            if (ano % 4 == 0)
                            {
                                Console.WriteLine("Este mês tem 29 dias");
                            }
                            else
                            {
                                Console.WriteLine("Este mês tem 28 dias");
                            }
                            break;

                        case 9:
                        case 4:
                        case 6:
                        case 11:
                            Console.Clear();
                            Console.WriteLine("Este mês tem 30 dias!");
                            break;

                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            Console.Clear();
                            Console.WriteLine("Este mês tem 31 dias!");
                            break;
                    }
                    break;

                case 6:
                    Console.Clear();

                    Console.WriteLine("!Pizzaria dos cria!");
                    Console.WriteLine("Escolha uma das nossas opções: ");
                    Console.WriteLine("100 - pizza de Frango com Catupiry");
                    Console.WriteLine("101 - pizza de Calabaresa");
                    Console.WriteLine("102 - pizza Portuguesa");
                    Console.WriteLine("103 - pizza de Mussarela");
                    int op4 = int.Parse(Console.ReadLine());

                    switch (op4)
                    {

                        case 100:
                            Console.Clear();
                            Console.WriteLine("Informe quantas unidades desejas: ");
                            int uni1 = int.Parse(Console.ReadLine());
                            float preco1 = uni1 * 35.00F;
                            if (preco1 > 60.00F)
                            {
                                float final1 = preco1 * 0.95F;
                                Console.WriteLine("Seu valor é de: " + final1);
                            }
                            else
                            {
                                Console.WriteLine("Seu valor é de: " + preco1);
                            }
                            break;

                        case 101:
                            Console.Clear();
                            Console.WriteLine("Informe quantas unidades desejas: ");
                            int uni2 = int.Parse(Console.ReadLine());
                            float preco2 = uni2 * 32.00F;
                            if (preco2 > 60.00F)
                            {
                                float final2 = preco2 * 0.95F;
                                Console.WriteLine("Seu valor é de: " + final2);
                            }
                            else
                            {
                                Console.WriteLine("Seu valor é de: " + preco2);
                            }
                            break;

                        case 102:
                            Console.Clear();
                            Console.WriteLine("Informe quantas unidades desejas: ");
                            int uni3 = int.Parse(Console.ReadLine());
                            float preco3 = uni3 * 37.00F;
                            if (preco3 > 60.00F)
                            {
                                float final3 = preco3 * 0.95F;
                                Console.WriteLine("Seu valor é de: " + final3);
                            }
                            else
                            {
                                Console.WriteLine("Seu valor é de: " + preco3);
                            }
                            break;

                        case 103:
                            Console.Clear();
                            Console.WriteLine("Informe quantas unidades desejas: ");
                            int uni4 = int.Parse(Console.ReadLine());
                            float preco4 = uni4 * 30.00F;
                            if (preco4 > 60.00F)
                            {
                                float final4 = preco4 * 0.95F;
                                Console.WriteLine("Seu valor é de: " + final4);
                            }
                            else
                            {
                                Console.WriteLine("Seu valor é de: " + preco4);
                            }
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                            break;

                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
