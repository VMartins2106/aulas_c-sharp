using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_inicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Comandos para limpar campos
            txtNome.Clear();
            txtCurso.Text = "";
            txtIdade.Clear();

            //Direcionando o foco para a txtNome
            txtNome.Focus();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string curso = txtCurso.Text;
            int idade = int.Parse(txtIdade.Text);
            int ano = 2022 - idade;
            MessageBox.Show("Seu nome é " + nome + ", sua idade é " + idade + " e está no curso de " + curso);

            if (idade >= 16)
            {
                MessageBox.Show("Já pode tirar o titulo de eleitor!");
            }
            else if(idade >= 18)
            {
                MessageBox.Show("Você deve tirar o titulo de eleitor!");
            }
            else
            {
                MessageBox.Show("Você não pode tirar o titulo de eleitor");
            }
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
