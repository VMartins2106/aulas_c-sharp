using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmrCria_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity == 1) tmrCria.Enabled = false;
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            UI.frmAluno aluno = new UI.frmAluno();
            aluno.ShowDialog();
        }
    }
}
