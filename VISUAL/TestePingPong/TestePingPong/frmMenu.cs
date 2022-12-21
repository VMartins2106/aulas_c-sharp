using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePingPong
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void btnIniciante_Click(object sender, EventArgs e)
        {
            //Esconde o menu
            this.Hide();
            //Abre a tela do jogo
            Iniciante frm1 = new Iniciante(200);
            //Mostra o jogo
            frm1.Show();
        }

        private void btnIntermediario_Click(object sender, EventArgs e)
        {
            //Esconde o menu
            this.Hide();
            //Abre a tela do jogo
            Intermediario frm1 = new Intermediario();
            //Mostra o jogo
            frm1.Show();
        }

        private void btnAvançado_Click(object sender, EventArgs e)
        {
            //Esconde o menu
            this.Hide();
            //Abre a tela do jogo
            Avancado frm1 = new Avancado();
            //Mostra o jogo
            frm1.Show();
        }
    }
}
