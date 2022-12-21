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
    public partial class Intermediario : Form
    {

        int velocidade = 30;
        int resultado, valor;
        bool topo, esquerda;
        public Intermediario()
        {
            InitializeComponent();
            //tamanho da "raquete"

            valor = 200;
     
                picRaquete.Height = valor;
        }

        private void Intermediario_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            picBola.Location = new Point(0, rand.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frm1 = new frmMenu();
            frm1.Show();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Intermediario frm1 = new Intermediario();
            frm1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Avancado frm1 = new Avancado();
            frm1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //se perder
            if (picBola.Left > picRaquete.Left)
            {
                timer1.Enabled = false;
                lblResultado.Text = "Você perdeu com  " + resultado.ToString() + " pontos!";
                resultado = 0;
                lblPontos.Text = null;

            }

            //mandar o resultado
            if (picBola.Left + picBola.Width >= picRaquete.Left && picBola.Left + picBola.Width <= picRaquete.Left + picRaquete.Width
                && picBola.Top + picBola.Height >= picRaquete.Top && picBola.Top + picBola.Height <= picRaquete.Top + picRaquete.Height + picBola.Height)
            {
                esquerda = false;
                resultado += 1;
                lblResultado.Text = resultado.ToString();
            }



            if (esquerda)
                picBola.Left += velocidade;
            else
                picBola.Left -= velocidade;

            if (topo)
                picBola.Top += velocidade;
            else
                picBola.Top -= velocidade;

            if (picBola.Top >= this.Height - 50)
                topo = false;

            if (picBola.Top <= 0)
                topo = true;

            if (picBola.Left <= 0)
                esquerda = true;
        }

        private void Intermediario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                picRaquete.Top = picRaquete.Top - 25;
            }
            else if (e.KeyCode == Keys.Down)
            {
                picRaquete.Top = picRaquete.Top + 25;
            }
        }
    }
}
