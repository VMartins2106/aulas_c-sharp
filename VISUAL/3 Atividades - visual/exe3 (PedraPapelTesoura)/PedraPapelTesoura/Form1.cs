using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedraPapelTesoura
{
    public partial class Form1 : Form
    {
        int somaJogador = 0, somaPc = 0, pontos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cliquei sem querer
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //COMBOBOX JOGADOR 1

            if(cmbJogador.Text == "Ramon Dino")
            {
                ptbJogador.Image = Properties.Resources.ramon;
            }
            else if (cmbJogador.Text == "Chris Bumstead")
            {
                ptbJogador.Image = Properties.Resources.cbum;
            }
            else if (cmbJogador.Text == "Fabio Giga")
            {
                ptbJogador.Image = Properties.Resources.giga;
            }
            else if (cmbJogador.Text == "Jay Cutler")
            {
                ptbJogador.Image = Properties.Resources.jay;
            }
            else if (cmbJogador.Text == "Ronnie Coleman")
            {
                ptbJogador.Image = Properties.Resources.ronnie;
            }
            else if (cmbJogador.Text == "Zyzz")
            {
                ptbJogador.Image = Properties.Resources.zyzz;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //cliquei sem querer
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbComputador.Text == "Ramon Dino")
            {
                ptbComputador.Image = Properties.Resources.ramon;
            }
            else if (cmbComputador.Text == "Chris Bumstead")
            {
                ptbComputador.Image = Properties.Resources.cbum;
            }
            else if (cmbComputador.Text == "Fabio Giga")
            {
                ptbComputador.Image = Properties.Resources.giga;
            }
            else if (cmbComputador.Text == "Jay Cutler")
            {
                ptbComputador.Image = Properties.Resources.jay;
            }
            else if (cmbComputador.Text == "Ronnie Coleman")
            {
                ptbComputador.Image = Properties.Resources.ronnie;
            }
            else if (cmbComputador.Text == "Zyzz")
            {
                ptbComputador.Image = Properties.Resources.zyzz;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int escolhaPC = rdm.Next(0,3);            

            //0 = pedra
            //1 = papel
            //2 = tesoura

            //jogador escolheu pedra
            if (rdbPedra.Checked && escolhaPC==0)
            {
                ptbPC.Image = Properties.Resources.pedra1;
            }
            else if(rdbPedra.Checked && escolhaPC==1)
            {
                ptbPC.Image = Properties.Resources.papel1;
                somaPc += 1;
                lblComputador.Text = " " + somaPc;
            }
            else if(rdbPedra.Checked && escolhaPC == 2)
            {
                ptbPC.Image = Properties.Resources.tesoura1;
                somaJogador += 1;
                lblJogador.Text = " " + somaJogador;
                System.Media.SoundPlayer vitoria = new System.Media.SoundPlayer("videoplayback.wav");
                vitoria.Play();
            }

            //jogador escolheu papel
            if (rdbPapel.Checked && escolhaPC == 0)
            {
                ptbPC.Image = Properties.Resources.pedra1;
                somaJogador += 1;
                lblJogador.Text = " " + somaJogador;
                System.Media.SoundPlayer vitoria = new System.Media.SoundPlayer("videoplayback.wav");
                vitoria.Play();
            }
            else if (rdbPapel.Checked && escolhaPC == 1)
            {
                ptbPC.Image = Properties.Resources.papel1;
            }
            else if (rdbPapel.Checked && escolhaPC == 2)
            {
                ptbPC.Image = Properties.Resources.tesoura1;
                somaPc += 1;
                lblComputador.Text = " " + somaPc;
            }

            //jogador escolheu tesoura
            if (rdbTesoura.Checked && escolhaPC == 0)
            {
                ptbPC.Image = Properties.Resources.pedra1;
                somaPc += 1;
                lblComputador.Text = " " + somaPc;
            }
            else if (rdbTesoura.Checked && escolhaPC == 1)
            {
                ptbPC.Image = Properties.Resources.papel1;
                somaJogador += 1;
                lblJogador.Text = " " + somaJogador;
                System.Media.SoundPlayer vitoria = new System.Media.SoundPlayer("videoplayback.wav");
                vitoria.Play();
            }
            else if (rdbTesoura.Checked && escolhaPC == 2)
            {
                ptbPC.Image = Properties.Resources.tesoura1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (somaJogador > somaPc)
            {
                pontos = somaJogador - somaPc;
                MessageBox.Show("O jogador ganhou com " + pontos + " a mais do que você");
            }
            else if(somaJogador < somaPc)
            {
                pontos = somaPc - somaJogador;
                MessageBox.Show("O computador ganhou com " + pontos + " a mais do que você");
            }
            else if(somaJogador == somaPc)
            {
                MessageBox.Show("EMPATE");
            }
            else
            {
                MessageBox.Show("Não houve jogo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblComputador.Text = "";
            lblJogador.Text = "";
            ptbComputador.Image = null;
            ptbJogador.Image = null;
            ptbPC.Image = null;
            cmbComputador.Text = null;
            cmbJogador.Text = null;
            rdbPapel.Checked = false;
            rdbPedra.Checked = false;
            rdbTesoura.Checked = false;            
        }
    }
}
