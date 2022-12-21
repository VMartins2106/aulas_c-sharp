using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_jogo
{
    public partial class telaFacil : Form
    {
        public telaFacil()
        {
            InitializeComponent();
        }

        private void telaFacil_KeyDown(object sender, KeyEventArgs e)
        {
            //KEY DOWN (COMANDOS DE MEXER)

            //MOVIMENTAÇÃO VITÃO

            if (e.KeyCode == Keys.W)
            {
                vitao.Top = vitao.Top - 8;
            }
            else if (e.KeyCode == Keys.S)
            {
                vitao.Top = vitao.Top + 8;
            }
            else if (e.KeyCode == Keys.A)
            {
                vitao.Left = vitao.Left - 8;
            }
            else if (e.KeyCode == Keys.D)
            {
                vitao.Left = vitao.Left + 8;
            }

            //MOVIMENTAÇÃO YAN

            else if (e.KeyCode == Keys.Up)
            {
                yan.Top = yan.Top - 8;
            }
            else if (e.KeyCode == Keys.Down)
            {
                yan.Top = yan.Top + 8;
            }
            else if (e.KeyCode == Keys.Left)
            {
                yan.Left = yan.Left - 8;
            }
            else if (e.KeyCode == Keys.Right)
            {
                yan.Left = yan.Left + 8;
            }

            //MOVIMENTAÇÃO BIEL

            else if (e.KeyCode == Keys.G)
            {
                biel.Top = biel.Top - 8;
            }
            else if (e.KeyCode == Keys.V)
            {
                biel.Top = biel.Top + 8;
            }
            else if (e.KeyCode == Keys.C)
            {
                biel.Left = biel.Left - 8;
            }
            else if (e.KeyCode == Keys.B)
            {
                biel.Left = biel.Left + 8;
            }

            //MOVIMENTAÇÃO WESLEY

            else if (e.KeyCode == Keys.U)
            {
                wesley.Top = wesley.Top - 8;
            }
            else if (e.KeyCode == Keys.J)
            {
                wesley.Top = wesley.Top + 8;
            }
            else if (e.KeyCode == Keys.H)
            {
                wesley.Left = wesley.Left - 8;
            }
            else if (e.KeyCode == Keys.K)
            {
                wesley.Left = wesley.Left + 8;
            }
            colisao();
        }

        public void colisao()
        {
            if (panel1.Bounds.IntersectsWith(vitao.Bounds) || panel2.Bounds.IntersectsWith(vitao.Bounds) || panel3.Bounds.IntersectsWith(vitao.Bounds) || panel4.Bounds.IntersectsWith(vitao.Bounds) || panel5.Bounds.IntersectsWith(vitao.Bounds) || panel6.Bounds.IntersectsWith(vitao.Bounds) || panel7.Bounds.IntersectsWith(vitao.Bounds) || panel8.Bounds.IntersectsWith(vitao.Bounds) || panel9.Bounds.IntersectsWith(vitao.Bounds) || panel10.Bounds.IntersectsWith(vitao.Bounds) || panel11.Bounds.IntersectsWith(vitao.Bounds) || panel12.Bounds.IntersectsWith(vitao.Bounds) || panel13.Bounds.IntersectsWith(vitao.Bounds) || panel14.Bounds.IntersectsWith(vitao.Bounds) || panel15.Bounds.IntersectsWith(vitao.Bounds) || panel16.Bounds.IntersectsWith(vitao.Bounds) || panel17.Bounds.IntersectsWith(vitao.Bounds) || panel18.Bounds.IntersectsWith(vitao.Bounds) || panel19.Bounds.IntersectsWith(vitao.Bounds) || panel20.Bounds.IntersectsWith(vitao.Bounds) || panel21.Bounds.IntersectsWith(vitao.Bounds) || panel22.Bounds.IntersectsWith(vitao.Bounds) || panel23.Bounds.IntersectsWith(vitao.Bounds) || panel24.Bounds.IntersectsWith(vitao.Bounds) || panel25.Bounds.IntersectsWith(vitao.Bounds) || panel26.Bounds.IntersectsWith(vitao.Bounds) || panel27.Bounds.IntersectsWith(vitao.Bounds) || panel28.Bounds.IntersectsWith(vitao.Bounds) || panel29.Bounds.IntersectsWith(vitao.Bounds))
            {
                //CÓDIGO DA COLISAO VITAO

                MessageBox.Show("PERDEU");

            }
            else if (panel1.Bounds.IntersectsWith(yan.Bounds) || panel2.Bounds.IntersectsWith(yan.Bounds) || panel3.Bounds.IntersectsWith(yan.Bounds) || panel4.Bounds.IntersectsWith(yan.Bounds) || panel5.Bounds.IntersectsWith(yan.Bounds) || panel6.Bounds.IntersectsWith(yan.Bounds) || panel7.Bounds.IntersectsWith(yan.Bounds) || panel8.Bounds.IntersectsWith(yan.Bounds) || panel9.Bounds.IntersectsWith(yan.Bounds) || panel10.Bounds.IntersectsWith(yan.Bounds) || panel11.Bounds.IntersectsWith(yan.Bounds) || panel12.Bounds.IntersectsWith(yan.Bounds) || panel13.Bounds.IntersectsWith(yan.Bounds) || panel14.Bounds.IntersectsWith(yan.Bounds) || panel15.Bounds.IntersectsWith(yan.Bounds) || panel16.Bounds.IntersectsWith(yan.Bounds) || panel17.Bounds.IntersectsWith(yan.Bounds) || panel18.Bounds.IntersectsWith(yan.Bounds) || panel19.Bounds.IntersectsWith(yan.Bounds) || panel20.Bounds.IntersectsWith(yan.Bounds) || panel21.Bounds.IntersectsWith(yan.Bounds) || panel22.Bounds.IntersectsWith(yan.Bounds) || panel23.Bounds.IntersectsWith(yan.Bounds) || panel24.Bounds.IntersectsWith(yan.Bounds) || panel25.Bounds.IntersectsWith(yan.Bounds) || panel26.Bounds.IntersectsWith(yan.Bounds) || panel27.Bounds.IntersectsWith(yan.Bounds) || panel28.Bounds.IntersectsWith(yan.Bounds) || panel29.Bounds.IntersectsWith(yan.Bounds))
            {
                //CÓDIGO DA COLISAO YAN

                MessageBox.Show("PERDEU");

            }
            else if (panel1.Bounds.IntersectsWith(biel.Bounds) || panel2.Bounds.IntersectsWith(biel.Bounds) || panel3.Bounds.IntersectsWith(biel.Bounds) || panel4.Bounds.IntersectsWith(biel.Bounds) || panel5.Bounds.IntersectsWith(biel.Bounds) || panel6.Bounds.IntersectsWith(biel.Bounds) || panel7.Bounds.IntersectsWith(biel.Bounds) || panel8.Bounds.IntersectsWith(biel.Bounds) || panel9.Bounds.IntersectsWith(biel.Bounds) || panel10.Bounds.IntersectsWith(biel.Bounds) || panel11.Bounds.IntersectsWith(biel.Bounds) || panel12.Bounds.IntersectsWith(biel.Bounds) || panel13.Bounds.IntersectsWith(biel.Bounds) || panel14.Bounds.IntersectsWith(biel.Bounds) || panel15.Bounds.IntersectsWith(biel.Bounds) || panel16.Bounds.IntersectsWith(biel.Bounds) || panel17.Bounds.IntersectsWith(biel.Bounds) || panel18.Bounds.IntersectsWith(biel.Bounds) || panel19.Bounds.IntersectsWith(biel.Bounds) || panel20.Bounds.IntersectsWith(biel.Bounds) || panel21.Bounds.IntersectsWith(biel.Bounds) || panel22.Bounds.IntersectsWith(biel.Bounds) || panel23.Bounds.IntersectsWith(biel.Bounds) || panel24.Bounds.IntersectsWith(biel.Bounds) || panel25.Bounds.IntersectsWith(biel.Bounds) || panel26.Bounds.IntersectsWith(biel.Bounds) || panel27.Bounds.IntersectsWith(biel.Bounds) || panel28.Bounds.IntersectsWith(biel.Bounds) || panel29.Bounds.IntersectsWith(biel.Bounds))
            {
                //CÓDIGO DA COLISAO BIEL

                MessageBox.Show("PERDEU");

            }
            else if (panel1.Bounds.IntersectsWith(wesley.Bounds) || panel2.Bounds.IntersectsWith(wesley.Bounds) || panel3.Bounds.IntersectsWith(wesley.Bounds) || panel4.Bounds.IntersectsWith(wesley.Bounds) || panel5.Bounds.IntersectsWith(wesley.Bounds) || panel6.Bounds.IntersectsWith(wesley.Bounds) || panel7.Bounds.IntersectsWith(wesley.Bounds) || panel8.Bounds.IntersectsWith(wesley.Bounds) || panel9.Bounds.IntersectsWith(wesley.Bounds) || panel10.Bounds.IntersectsWith(wesley.Bounds) || panel11.Bounds.IntersectsWith(wesley.Bounds) || panel12.Bounds.IntersectsWith(wesley.Bounds) || panel13.Bounds.IntersectsWith(wesley.Bounds) || panel14.Bounds.IntersectsWith(wesley.Bounds) || panel15.Bounds.IntersectsWith(wesley.Bounds) || panel16.Bounds.IntersectsWith(wesley.Bounds) || panel17.Bounds.IntersectsWith(wesley.Bounds) || panel18.Bounds.IntersectsWith(wesley.Bounds) || panel19.Bounds.IntersectsWith(wesley.Bounds) || panel20.Bounds.IntersectsWith(wesley.Bounds) || panel21.Bounds.IntersectsWith(wesley.Bounds) || panel22.Bounds.IntersectsWith(wesley.Bounds) || panel23.Bounds.IntersectsWith(wesley.Bounds) || panel24.Bounds.IntersectsWith(wesley.Bounds) || panel25.Bounds.IntersectsWith(wesley.Bounds) || panel26.Bounds.IntersectsWith(wesley.Bounds) || panel27.Bounds.IntersectsWith(wesley.Bounds) || panel28.Bounds.IntersectsWith(wesley.Bounds) || panel29.Bounds.IntersectsWith(wesley.Bounds))
            {
                //CÓDIGO DA COLISAO WESLEY

                MessageBox.Show("PERDEU");

            }          

            else if(vitao.Bounds.IntersectsWith(chegada.Bounds) && yan.Bounds.IntersectsWith(chegada.Bounds) && biel.Bounds.IntersectsWith(chegada.Bounds) && wesley.Bounds.IntersectsWith(chegada.Bounds))
            {
                MessageBox.Show("GANHOU");
            }           
        }
    }
}
