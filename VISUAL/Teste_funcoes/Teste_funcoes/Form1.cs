using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_funcoes
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
            panel1.Hide();            
        }

        bool parar = false;

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //KEY PRESS

            int c = e.KeyChar;
            /*if (c == 61 || c == 97)
            {
                panel1.Left = panel1.Left - 25;
            }
            else if(c == 115 || c == 83)
            {
                panel1.Left = panel1.Left + 10;
                panel1.Top = panel1.Top - 25;
            }*/
        }

        private void panel1_BackColorChanged(object sender, EventArgs e)
        {
            //PAINEL COR --> CLIQUEI SEM QUERER
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //KEY DOWN

            if (parar == false)
            {
                if (e.KeyCode == Keys.W)
                {
                    panel1.Top = panel1.Top - 15;
                    colisao();
                }
                else if (e.KeyCode == Keys.S)
                {
                    panel1.Top = panel1.Top + 15;
                    colisao();
                }
                else if (e.KeyCode == Keys.A)
                {
                    panel1.Left = panel1.Left - 15;
                    colisao();
                }
                else if (e.KeyCode == Keys.D)
                {
                    panel1.Left = panel1.Left + 15;
                    colisao();
                }
            }
            else
            {
                MessageBox.Show("PERDEU");
            }

        }

        public void colisao()
        {
            if (panel2.Bounds.IntersectsWith(panel1.Bounds) || panel3.Bounds.IntersectsWith(panel1.Bounds) || panel4.Bounds.IntersectsWith(panel1.Bounds) || panel5.Bounds.IntersectsWith(panel1.Bounds) || panel6.Bounds.IntersectsWith(panel1.Bounds) || panel7.Bounds.IntersectsWith(panel1.Bounds) || panel8.Bounds.IntersectsWith(panel1.Bounds) || panel9.Bounds.IntersectsWith(panel1.Bounds) || panel10.Bounds.IntersectsWith(panel1.Bounds) || panel11.Bounds.IntersectsWith(panel1.Bounds) || panel12.Bounds.IntersectsWith(panel1.Bounds) || panel13.Bounds.IntersectsWith(panel1.Bounds))
            {
                panel1.BackColor = Color.Red;
                panel1.TabStop = true;
                parar = true;
                start.Text = "REINICIAR";

            }
            else if (estrela.Bounds.IntersectsWith(panel1.Bounds) && panel1.BackColor == Color.Lime)
            {
                MessageBox.Show("PARABÉNS");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //PANEL 2 --> CLIQUEI SEM QUERER
        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //TESTE
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(start.Text == "COMEÇAR")
            {
                panel1.Visible = true;
                panel1.TabStop = false;
            }
            else if(start.Text == "REINICIAR")
            {
                panel1.BackColor= Color.Lime;
                start.Text = "COMEÇAR";
                panel1.Hide();
                panel1.Location = new Point(118, 176);
                parar = false;
            }


            
        }
    }
}
