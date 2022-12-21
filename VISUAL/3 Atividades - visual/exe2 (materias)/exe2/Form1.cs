using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2
{
    public partial class Form1 : Form
    {
        int tempinho;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if(cmbMateria.Text == "Desenvolvimento de sistemas")
            {
                lblMSG.Text = "Você deve usar:\nVISUAL STUDIO";
            }
            else if (cmbMateria.Text == "Programação mobile 1")
            {
                lblMSG.Text = "Você deve usar:\nANDROID STUDIO";
            }
            else if (cmbMateria.Text == "Programação web 2")
            {
                lblMSG.Text = "Você deve usar:\nXAMPP E VISUAL STUDIO CODE";
            }
            else if (cmbMateria.Text == "Banco de dados 2")
            {
                lblMSG.Text = "Você deve usar:\nSQL-SERVER";
            }            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbMateria.Text = "";
            lblMSG.Text = "Você deve usar:";
            tempinho = 0;
            lblCria.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            if(tempinho == 0)
            {
                temporizadorDeCria.Stop();
                MessageBox.Show("C É LERDO EM PRC");
            }
            lblCria.Text = ("Tempo: " + tempinho);
            tempinho -= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempinho = 20;
            temporizadorDeCria.Start();            
        }
    }
}
