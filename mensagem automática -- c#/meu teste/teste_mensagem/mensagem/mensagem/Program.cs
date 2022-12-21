using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace mensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis contadoras
            string mensagem = "";
            int qtdmsg = 0;
            int contador = 10;

            //variavel para receber biblioteca que recebe os dados do teclado
            var inputSimulator = new InputSimulator();

            //pedir mensagem
            Console.WriteLine("Informe a mensagem desejada:");
            mensagem = Console.ReadLine();

            //pedir quantidade da mensagem
            Console.WriteLine("Quantas vezes quer que a mensagem seja enviada ?");
            qtdmsg = Convert.ToInt32(Console.ReadLine());

            //laço de repetição para o contador
            for(int i = 0; i < contador; i++)
            {
                Console.WriteLine("---------------> " + (contador - i));

                //biblioteca para o programa esperar o tempo para executar a ação seguinte
                Thread.Sleep(1000);
            }

            Console.WriteLine("Começou !!!");

            //laço para a quantidade da mensagem
            for(int i = 0; i < qtdmsg; i++)
            {
                inputSimulator.Keyboard.TextEntry(mensagem);
                //biblioteca para reiniciar o processo
                inputSimulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                //tempo minimo para o whatsapp nao travar
                Thread.Sleep(250);

                Console.WriteLine("Mensagem enviada com sucesso");
            }

        }
    }
}
