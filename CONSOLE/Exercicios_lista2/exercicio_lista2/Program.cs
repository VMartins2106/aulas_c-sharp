using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_lista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
