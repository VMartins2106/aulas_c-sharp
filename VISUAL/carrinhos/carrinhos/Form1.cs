using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrinhos
{
    public partial class Form1 : Form
    {
        //CRIANDO RANDOM
        Random rdm = new Random();

        //CRIANDO VELOCIDADE DOS CARROS
        int velocidade = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //BOTÃO COMEÇAR

            tmrCarroUm.Start();
            tmrCarroDois.Start();
            tmrCarroTres.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pctCarroUm.Left = 0;
            pctCarroDois.Left = 0;
            pctCarroTres.Left = 0;
        }

        public void vitoria(int posicao, int carro)
        {
            if (posicao > 600)
            {
                if (carro == 1)
                {
                    paraTudo();
                    MessageBox.Show("O crash ganhou !!");
                }
                else if (carro == 2)
                {
                    paraTudo();
                    MessageBox.Show("O minion ganhou !!");
                }
                else if (carro == 3)
                {
                    paraTudo();
                    MessageBox.Show("O flash ganhou !!");
                }
            }
        }

        public void paraTudo()
        {
            tmrCarroUm.Stop();
            tmrCarroDois.Stop();
            tmrCarroTres.Stop();
        }

        private void tmrCarroUm_Tick(object sender, EventArgs e)
        {
            pctCarroUm.Left = pctCarroUm.Left + rdm.Next(1, velocidade);
            vitoria(pctCarroUm.Left, 1);
        }

        private void tmrCarroDois_Tick(object sender, EventArgs e)
        {
            pctCarroDois.Left = pctCarroDois.Left + rdm.Next(1, velocidade);
            vitoria(pctCarroDois.Left, 2);

        }

        private void tmrCarroTres_Tick(object sender, EventArgs e)
        {
            pctCarroTres.Left = pctCarroTres.Left + rdm.Next(1, velocidade);
            vitoria(pctCarroTres.Left, 3);
        }
    }
}
