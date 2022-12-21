using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cara_Coroa
{
    public partial class Form1 : Form
    {

        int soma = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdbCara_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbCoroa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ESCOLHA DO COMPUTADOR

            Random rdm = new Random();
            int escolhaPC = rdm.Next(0, 2);
            
            //random = 1

            if(escolhaPC == 0)
            {
                ptbComp.Image = Properties.Resources.cara;
            }

            //random = 2

            else if (escolhaPC == 1)
            {
                ptbComp.Image = Properties.Resources.coroa;
            }
                       
            //imagem escolhida

            if (rdbCara.Checked)
            {
                ptbMoeda.Image = Properties.Resources.cara;
            }
            else if (rdbCoroa.Checked)
            {
                ptbMoeda.Image = Properties.Resources.coroa;
            }

            //mensagem de vitória ou derrota
                     
            if(rdbCara.Checked && escolhaPC == 0)
            {
                lblMSG.Text = "VOCÊ GANHOU";
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer("acerto.wav");
                sp.Play();                
                soma += 1;

                if (soma == 3)
                {
                    System.Media.SoundPlayer aplauso = new System.Media.SoundPlayer("aplauso.wav");
                    aplauso.Play();
                    soma = 0;
                }

            }
            else if(rdbCoroa.Checked && escolhaPC == 1)
            {
                lblMSG.Text = "VOCÊ GANHOU";
                System.Media.SoundPlayer acerto = new System.Media.SoundPlayer("acerto.wav");
                acerto.Play();
                soma += 1;

                if (soma == 3)
                {
                    System.Media.SoundPlayer aplauso = new System.Media.SoundPlayer("aplauso.wav");
                    aplauso.Play();
                    soma = 0;
                }

            }
            else
            {
                lblMSG.Text = "VOCÊ PERDEU";
                System.Media.SoundPlayer erro = new System.Media.SoundPlayer("erro.wav");
                erro.Play();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
