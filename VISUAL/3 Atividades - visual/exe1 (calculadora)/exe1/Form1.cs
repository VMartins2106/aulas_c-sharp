using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe1
{
    public partial class Form1 : Form
    {

        double n1, n2, total;

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txt1.Text);
            n2 = double.Parse(txt2.Text);

                if (rdSoma.Checked == true)
                {
                    total = n1 + n2;
                    lblMSG.Text = ("Resultado: "+total);
                }
                else if (rdSub.Checked == true)
                {
                    total = n1 - n2;
                    lblMSG.Text = ("Resultado: " + total);
                }
                else if (rdDiv.Checked == true)
                {
                    total = n1 / n2;
                    lblMSG.Text = ("Resultado: " + total);
                }
                else if (rdMul.Checked == true)
                {
                    total = n1 * n2;
                    lblMSG.Text = ("Resultado: " + total);
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            rdSoma.Checked = false;
            rdSub.Checked = false;
            rdDiv.Checked = false;
            rdMul.Checked = false;

            txt1.Text = "";
            txt2.Text = "";

            lblMSG.Text = "Resultado: ";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FORMULÁRIO EM SI
        }
    }
}
