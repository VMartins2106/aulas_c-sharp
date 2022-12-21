using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_academia.UI
{
    public partial class frmAluno : Form
    {

        //REFERENCIANDO BLL E DAL
        BLL.AlunoBLL aBLL = new BLL.AlunoBLL();
        DAL.AlunoDAL aDAL = new DAL.AlunoDAL();

        public frmAluno()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            //ENVIAR VALORES PARA A BLL
            aBLL.Nome = nome.Text;
            aBLL.Cpf = cpf.Text;
            aBLL.Rg = rg.Text;
            aBLL.Email = email.Text;
            aBLL.Data = data.Value;

            //EXECUTAR O MÉTODO DA DAL ENVIANDO OS DADOS DA BLL
            aDAL.Cadastrar(aBLL);
            MessageBox.Show("DADOS GRAVADOS COM SUCESSO");
            dgvAluno.DataSource = aDAL.ConsultarTodos();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            //BOTÃO CONSULTAR
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            //BOTÃO EDITAR
            aBLL.Codaluno = Convert.ToInt16(dgvAluno[0, dgvAluno.CurrentRow.Index].Value);
            aBLL = aDAL.Retornar(aBLL);
            nome.Text = aBLL.Nome;
            cpf.Text = aBLL.Cpf;
            rg.Text = aBLL.Rg;
            email.Text = aBLL.Email;
            data.Value = aBLL.Data;

            tabControl1.SelectedTab = tabPage1;
        }

        private void btnEsclui_Click(object sender, EventArgs e)
        {
            //BOTÃO EXCLUIR
        }

        private void frmAluno_Load(object sender, EventArgs e)
        {
            //FORMULÁRIO INTEIRO (NA TELA DE CONSULTAR)
            dgvAluno.DataSource = aDAL.ConsultarTodos();
        }
    }
}
