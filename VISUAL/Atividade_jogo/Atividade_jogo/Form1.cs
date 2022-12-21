using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void facil_Click(object sender, EventArgs e)
        {
            //BOTÃO FÁCIL
            telaFacil facil = new telaFacil();
            facil.Show();
        }

        private void instru_Click(object sender, EventArgs e)
        {
            //BOTÃO INSTRUÇÃO
            telaInstrucao instrucao = new telaInstrucao();
            instrucao.Show();
        }
    }
}
