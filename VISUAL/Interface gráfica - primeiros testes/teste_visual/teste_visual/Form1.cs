using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pctImagem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Tá tranquilo prc, pouco abaixo da media");
        }

        private void btnMnesagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meio pegado, mas ainda tá suave jao, faz skin care de malandro");
        }

        private void btnMensagem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ai ja da uma pegada, mas faz uma academia e skin care que vc consegue");
        }

        private void btnMensagem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muito complicado seu caso, mas espere um tempo e tente mais que você sai dessa");
        }

        private void btnMensagem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Porra irmão, nasce de novo que tlvz resolva");
        }

        private void btnMensagem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você é um real merda, nada salva você seu inferior, tente de tudo: nada adiantará !!! Ta repreendido, saia de perto da sociedade seu monstro !!!");
        }
    }
}
