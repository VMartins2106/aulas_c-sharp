using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_academia.BLL
{
    internal class AlunoBLL
    {
        //COPIAR OS NOMES E TIPOS DOS ATRIBUTOS DO BANCO DESEJADO

        //ATALHOS PARA GERAR GET E SET: Ctrl + R + E

        //VARIAVEIS E MÉTODOS DEVEM ESTAR COM A INICIAL MINÚSCULA, USADAS DENTRO DA CLASSE A SEGUIR
        private int codaluno;
        private string nome;
        private string cpf;
        private string rg;
        private string email;
        private DateTime datanasc;

        //COMANDOS FEITOS COM O ATALHO Ctrl + R + E

        //CLASSES E MÉTODOS DEVEM INICIAR COM A LETRA MAIUSCULA
        public int Codaluno 
        { 
            get => codaluno; 
            set => codaluno = value; 
        }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Data { get => datanasc; set => datanasc = value; }
    }
}
