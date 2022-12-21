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
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTAO TOCAR

            //axWindowsMediaPlayer1.URL = "alive.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //BOTAO ABRIR ARQUIVO

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //BOTAO PAUSAR

            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }
    }
}
