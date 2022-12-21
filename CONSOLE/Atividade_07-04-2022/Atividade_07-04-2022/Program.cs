using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            inicio:
            int op=0;

            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {

                case 1:
                    Console.Clear();

                    //declarando vetor
                    double[] vetValores = new double[10];
                    double[] vetAcrescimo = new double[10];

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("Informe o " + (i + 1) + "º valor:");
                        vetValores[i] = double.Parse(Console.ReadLine());
                        vetAcrescimo[i] = vetValores[i];
                    }

                    StringComparer ordenar1 = StringComparer.CurrentCultureIgnoreCase;

                    Array.Sort(vetValores, ordenar1);

                    for (int i = 0; i < vetValores.Length; i++)
                    {
                        Console.WriteLine("Seu " + (i + 1) + "º valor é: " + vetValores[i]);
                    }

                    for (int i = 0; i < vetAcrescimo.Length; i++)
                    {
                        Console.WriteLine("Seu valor número " + vetValores[i] + " com 10 % de acréscimo é: " + (vetValores[i] * 1.1));
                    }

                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();

                    int[] vetNum = new int[10];
                    int maior = 0;
                    int indice = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write("Informe o " + (i + 1) + "º valor:");
                        vetNum[i] = int.Parse(Console.ReadLine());

                        if (maior < vetNum[i])
                        {
                            maior = vetNum[i];
                            indice = i;
                        }
                    }

                    Console.WriteLine("\n\n");

                    for (int i = 0; i < vetNum.Length; i++)
                    {
                        Console.WriteLine("Seu " + (i + 1) + "º valor é: " + vetNum[i]);
                    }

                    Console.WriteLine("\n\n");
                    Console.Write("O maior valor informado foi: " + maior);
                    Console.WriteLine("\n\n");
                    Console.Write("E se encontra no índice: " + (indice + 1));
                    Console.WriteLine("\n\n");

                    break;

                case 3:
                    Console.Clear();

                    int[] vetRandom = new int[100];
                    int soma = 0, media = 0, acima = 0;
                    Random random = new Random();

                    for (int i = 0; i < 100; i++)
                    {
                        int numero = random.Next(1, 101);
                        vetRandom[i] = numero;
                        soma += vetRandom[i];
                    }
                    media = soma / 100;
                    for (int i = 0; i < vetRandom.Length; i++)
                    {
                        Console.WriteLine("O " + (i + 1) + "º número é : " + vetRandom[i]);

                        if (vetRandom[i] > media)
                        {
                            acima += 1;
                        }
                    }

                    Console.WriteLine("A média dos valores é de: " + media);
                    Console.Write("Há " + acima + " valores acima da média!");

                    break;

                case 4:
                    Console.Clear();

                    Console.WriteLine("======MENU======");
                    Console.WriteLine("1 - Cadastrar nome");
                    Console.WriteLine("2 - Pesquisar nome");
                    Console.WriteLine("3 - Listar nomes cadastrados");
                    Console.WriteLine("0 - Sair");
                    int op4 = int.Parse(Console.ReadLine());

                    string[] nomes;

                    switch (op4) {                        

                            case 1:

                            Console.Clear();

                            Console.Write("Informe quantos nomes você quer inserir: ");
                            int qtd = int.Parse(Console.ReadLine());                            
                            nomes = new string[qtd];
                            

                            for (int i=1; i <= qtd; i++){                                
                                Console.Write("Informe o nome a ser cadastrado: ");
                                nomes[i] = Console.ReadLine();                                
                             }

                            break;
                        

                        /*case 3:
                            Console.Clear();
                            
                            Console.WriteLine("Os nomes cadastrados são: \n");

                            string[] exibir = new string[nomes.Length];
                            
                            for(int i=0; i<nomes.Length; i++)
                            {
                                Console.WriteLine("O " + i + "º nome é: " + exibir[nomes.Length]);
                            }

                            break;*/

                        case 0:
                            Console.ReadKey();
                            break;

                        default:
                            Console.ReadKey();
                            break;
                    }
                    break;

                default:
                    goto inicio;
                    break;

            }
        }
    }
}