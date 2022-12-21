using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoSom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTÃO MEDIA PLAYER

            frmPlayer player = new frmPlayer();

            //player.Show(); --> MOSTRA A NOVA JANELA DE FORMA A PODER TRANSITAR ENTRE AS ABAS
            //player.ShowDialog(); --> MOSTRA A NOVA JANELA DE FORMA QUE VOCê NÃO POSSA MEXER NA OUTRA ENQUANTO NÃO FECHAR A ATUAL

            player.Show();
        }
    }
}
