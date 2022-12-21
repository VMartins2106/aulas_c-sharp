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
        inicio:
            Console.Clear();
            Console.WriteLine("Escolha um exercicio: ");
            Console.WriteLine("Opção 01: Exercício de escolhas");
            Console.WriteLine("Opção 02: Exercício das aulas");
            Console.WriteLine("Opção 03: Exercicio de conversão");
            Console.WriteLine("Opção 04: Exercicio de natalidade e mortalidade");
            Console.WriteLine("Opção 05: Exercício de ano bissexto");
            Console.WriteLine("Opção 06: Exercício da pizzaria");
            Console.WriteLine("Opção 07: Exercicio de desconto");
            Console.WriteLine("Opção 08: Exercício de média (5 valores)");
            Console.WriteLine("Opção 09: Exercício de IMC");
            Console.WriteLine("Opção 10: Exercício de raio de uma circunferência");
            Console.WriteLine("Opção 11: Atividade 17/03/2022");
            Console.WriteLine("Opção 12: Atividade 24/03/2022");
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

                case 7:
                    Console.Clear();
                    float salario, desconto = 0.86F;
                    float fim;

                    Console.Write("Informe seu salário: ");
                    salario = float.Parse(Console.ReadLine());

                    Console.Clear();

                    fim = salario * desconto;

                    Console.Write("Seu salário líquido é de: " + fim);

                    Console.ReadKey();
                    break;

                case 8:
                    Console.Clear();
                    int num1, num2, n3, n4, n5, media;

                    Console.Write("Informe o primeiro valor: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Informe o segundo valor: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.Write("Informe o terceiro valor: ");
                    n3 = int.Parse(Console.ReadLine());

                    Console.Write("Informe o quarta valor: ");
                    n4 = int.Parse(Console.ReadLine());

                    Console.Write("Informe o quinto valor: ");
                    n5 = int.Parse(Console.ReadLine());

                    media = (num1 + num2 + n3 + n4 + n5) / 5;

                    Console.Clear();

                    Console.Write("Sua média é: " + media);

                    Console.ReadKey();
                    break;

                case 9:
                    Console.Clear();
                    float massa, altura, imc;

                    Console.WriteLine("Uitlize virgulas e não pontos.");

                    Console.Write("Informe seu peso: ");
                    massa = float.Parse(Console.ReadLine());

                    Console.Write("Informe sua altura: ");
                    altura = float.Parse(Console.ReadLine());

                    imc = massa / (altura * altura);

                    Console.Clear();

                    Console.Write("Seu imc é: " + imc);
                    break;

                case 10:
                    Console.Clear();
                    float raio, pi = 3.14F, comprimento, area;

                    Console.Write("Informe o valor do raio da circunferência: ");
                    raio = float.Parse(Console.ReadLine());

                    comprimento = 2 * pi * raio;
                    area = pi * (raio * raio);

                    Console.Clear();

                    Console.Write("O valor do comprimento da circunferência é de " + comprimento);
                    Console.Write("\nO valor da área da circunferência é de " + area);

                    Console.ReadKey();
                    break;

                case 11:

                    Console.Clear();

                    Console.WriteLine("Atividade com laços de repetição!\n");

                    Console.WriteLine("Opção 1: Múltiplos de 5 E 9 entre mil e dez mil!");
                    Console.WriteLine("Opção 2: Múltiplos de 10 até cem!");
                    Console.WriteLine("Opção 3: Programa que só fecha quando informado 0!");
                    Console.WriteLine("Opção 4: 10 valores informados, quantos são pares e quantos são ímpares!");
                    Console.WriteLine("Opção 5: Soma e contagem de valores até que se digite 0!");
                    Console.WriteLine("Opção 6: 10 valores e quantos deles estão no intervalor entre 10 e 20!");
                    Console.WriteLine("Opção 7: 10 valores e quantos deles estão no intervalor entre 12 e 20!");
                    int op11 = int.Parse(Console.ReadLine());

                    switch (op11)
                    {

                        case 1:
                            Console.Clear();
                            for (int i1 = 1000; i1 <= 10000; i1++)
                            {
                                if ((i1 % 5 == 0) && (i1 % 9 == 0))
                                {
                                    Console.WriteLine("Múltiplo de 5 e 9: " + i1);
                                }
                            }
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            for (int i2 = 1; i2 <= 100; i2++)
                            {
                                if (i2 % 10 == 0)
                                {
                                    Console.WriteLine("Múltiplo de 10: " + i2);
                                }
                                else
                                {
                                    Console.WriteLine(i2);
                                }
                            }
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            int i3 = 1;

                            while (i3 != 0)
                            {
                                Console.WriteLine("Digite um valor: ");
                                i3 = int.Parse(Console.ReadLine());

                            }

                            Console.WriteLine("Programa finalizado!");
                            Console.ReadKey();
                            break;

                        case 4:
                            Console.Clear();
                            int i4, par, impar;
                            par = 0;
                            impar = 0;

                            for (i4 = 0; i4 <= 10; i4++)
                            {
                                Console.WriteLine("\nInforme os valores: ");
                                int num4 = int.Parse(Console.ReadLine());

                                if (num4 % 2 == 0)
                                {
                                    Console.WriteLine("Este número é par (" + num4 + ")");
                                    par += 1;
                                }
                                else
                                {
                                    Console.WriteLine("Este número é ímpar (" + num4 + ")");
                                    impar += 1;
                                }
                            }

                            Console.WriteLine("Você digitou " + par + " números pares e " + impar + " números ímpares");

                            Console.ReadKey();
                            break;

                        case 5:
                            Console.Clear();
                            int i5 = 1, qtd, soma;
                            qtd = 0;
                            soma = 0;

                            while (i5 != 0)
                            {
                                Console.WriteLine("Digite um valor: ");
                                i5 = int.Parse(Console.ReadLine());
                                qtd += 1;
                                soma += i5;
                            }

                            Console.WriteLine("A quantidade de valores digitados é de: " + qtd);
                            Console.WriteLine("A soma de valores digitados é de: " + soma);

                            Console.WriteLine("Programa finalizado!");
                            Console.ReadKey();
                            break;

                        case 6:
                            Console.Clear();
                            int i6;

                            for (i6 = 0; i6 <= 10; i6++)
                            {
                                Console.WriteLine("\nInforme os valores: ");
                                int num6 = int.Parse(Console.ReadLine());

                                if (num6 >= 10 && num6 <= 20)
                                {
                                    Console.WriteLine("Este número está entre 10 e 20");
                                }
                                else
                                {
                                    Console.WriteLine("Este número está fora do intervalo entre 10 e 20");
                                }
                            }

                            Console.ReadKey();
                            break;

                        case 7:
                            Console.Clear();
                            int i7, num;
                            num = 1;

                            for (i7 = 0; i7 <= 10; i7++)
                            {
                                Console.WriteLine("\nInforme um valor entre 12 e 20: ");
                                int num7 = int.Parse(Console.ReadLine());

                                if (num7 >= 12 && num7 <= 20)
                                {
                                    Console.WriteLine("Este número está entre 12 e 20");
                                }
                                else
                                {
                                    Console.WriteLine("Entrada inválida!");
                                }
                            }

                            if (num == 0)
                            {
                                Console.WriteLine("Programa finalizado!");
                            }
                            Console.ReadKey();
                            break;

                        case 8:
                            Console.Clear();

                            for (int i = 10; i >= 0; i--)
                            {
                                if (i == 10 || i == 9)
                                {
                                    Console.WriteLine(i + " - Aguardando os motores...");
                                }



                                else if (i == 8)
                                {
                                    Console.WriteLine(i + " - Ligando os motores...");
                                }



                                else if (i == 7)
                                {
                                    Console.WriteLine(i + " - Iniciando o processo...");
                                }



                                else if (i == 6)
                                {
                                    Console.WriteLine(i + " - Motores ligados...");
                                }



                                else if (i == 5 || i == 4 || i == 3 || i == 2 || i == 1)
                                {
                                    Console.WriteLine(i + " - Preparar para a decolagem...");
                                }



                                else if (i == 0)
                                {
                                    Console.WriteLine(i + " - Decolando...");
                                }
                            }
                            break;

                    }
                    break;

                case 12:
                    Console.Clear();

                    Console.WriteLine("Atividade lista 2 (desafios): ");

                    //MENU
                    Console.WriteLine("Opção 1: Número enter 18 e 43");
                    Console.WriteLine("Opção 2: Maior valor");
                    Console.WriteLine("Opção 3: 100 números aleatórios");
                    Console.WriteLine("Opção 4: 500 números pares");
                    Console.WriteLine("Opção 5: Multiplos do número informado");
                    Console.WriteLine("Opção 6: Jogo de Adivinhação");

                    int op12 = int.Parse(Console.ReadLine());

                    switch (op12)
                    {
                        case 1:
                            Console.Clear();
                            int erro = 0;
                            while (erro != 3)
                            {
                                Console.Write("Informe um número entre 18 e 43: ");
                                int entre = int.Parse(Console.ReadLine());


                                if (entre >= 18 && entre <= 43)
                                {
                                    Console.WriteLine("O número está correto" + "(" + entre + ")");
                                }
                                else if (entre <= 18 || entre >= 43)
                                {
                                    Console.WriteLine("O número está fora da margem entre 18 e 43!");
                                    erro += 1;
                                    Console.WriteLine("Erro = " + erro);
                                }
                                else if (entre == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Programa encerrado!");
                                }
                            }
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            int n = 1, nd = 0;
                            while (n != 0)
                            {
                                Console.WriteLine("Enquanto não informar 0 o programa não será encerrado!\n");
                                Console.Write("Informe valores e mostraremos qual deles é maior: ");
                                n = int.Parse(Console.ReadLine());

                                if (n > nd)
                                {
                                    nd = n;
                                    Console.WriteLine("O número maior é: " + n);
                                }
                                else
                                {
                                    Console.WriteLine("O número maior é: " + nd);
                                }
                            }
                            Console.ReadKey();
                            break;

                        case 3:
                            Console.Clear();
                            int par = 0, impar = 0, maior = 0, soma = 0;
                            Random rdm = new Random();
                            Console.WriteLine("100 números aleatórios: ");

                            for (int i = 1; i <= 100; i++)
                            {
                                int num = rdm.Next(0, 101);
                                Console.WriteLine(num);

                                if (num % 2 == 0)
                                {
                                    par += 1;
                                }
                                else if (num % 2 == 1)
                                {
                                    impar += 1;
                                }
                                soma += num;
                                if (num > maior)
                                {
                                    maior = num;
                                }
                            }
                            Console.WriteLine("A soma dos números é de: " + soma);
                            Console.WriteLine("Temos um total de " + par + " números pares");
                            Console.WriteLine("Temos um total de " + impar + " números ímpares");
                            Console.WriteLine("O maior número é: " + maior);
                            Console.ReadKey();

                            break;

                        case 4:
                            Console.Clear();

                            Console.WriteLine("500 primeiros pares: ");

                            for (int i = 1; i <= 1000; i++)
                            {
                                if (i % 2 == 0)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            Console.ReadKey();

                            break;

                        case 5:
                            Console.Clear();

                            Console.WriteLine("Soma dos múltiplos de n\n");
                            Console.Write("Informe um numero: ");
                            int numero = int.Parse(Console.ReadLine());
                            Console.Write("Informe o múltiplo: ");
                            int multiplo = int.Parse(Console.ReadLine());

                            int multiplos, somatoria = 0;

                            for (int i = 1; i <= numero; i++)
                            {
                                multiplos = i * multiplo;
                                Console.WriteLine(multiplos);
                                somatoria += multiplos;
                            }

                            Console.WriteLine("A somatória dos multiplos é de: " + somatoria);

                            Console.ReadKey();

                            break;

                        case 6:
                            Console.Clear();

                            Console.WriteLine("Número randômico entre 1 e 100\n\nTente acertar!");

                            int palpite = 0;

                            Random n6 = new Random();
                            int random = n6.Next(1, 101);

                            while (palpite != random)
                            {
                                Console.Write("Dê seu palpite: ");
                                palpite = int.Parse(Console.ReadLine());

                                if (palpite > random)
                                {
                                    Console.Clear();
                                    Console.WriteLine("O número é menor que seu palpite!");
                                }
                                else if (palpite < random)
                                {
                                    Console.Clear();
                                    Console.WriteLine("O número é maior que seu palpite!");
                                }
                            }

                            Console.WriteLine("Parabéns, você acertou!!");
                            Console.ReadKey();

                            break;
                    }

                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    goto inicio;
                    break;
            }

            Console.ReadKey();
        }
    }
}