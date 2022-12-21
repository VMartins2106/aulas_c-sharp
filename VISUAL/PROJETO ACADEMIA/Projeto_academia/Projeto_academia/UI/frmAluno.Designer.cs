namespace Projeto_academia.UI
{
    partial class frmAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGravar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnEsclui = new System.Windows.Forms.Button();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.data);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rg);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cpf);
            this.tabPage1.Controls.Add(this.nome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(919, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGravar.Image = global::Projeto_academia.Properties.Resources.save;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(332, 373);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(203, 44);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(552, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de nascimento :";
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(557, 213);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(227, 26);
            this.data.TabIndex = 9;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.email.Location = new System.Drawing.Point(103, 290);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(681, 31);
            this.email.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(98, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-mail :";
            // 
            // rg
            // 
            this.rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rg.Location = new System.Drawing.Point(283, 208);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(252, 31);
            this.rg.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(278, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "RG :";
            // 
            // cpf
            // 
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cpf.Location = new System.Drawing.Point(103, 208);
            this.cpf.Mask = "000,000,000,00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(160, 31);
            this.cpf.TabIndex = 4;
            this.cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.nome.Location = new System.Drawing.Point(103, 112);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(681, 31);
            this.nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(98, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(98, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvAluno);
            this.tabPage2.Controls.Add(this.txtNomeConsulta);
            this.tabPage2.Controls.Add(this.btnEsclui);
            this.tabPage2.Controls.Add(this.btnEdita);
            this.tabPage2.Controls.Add(this.btnConsulta);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(919, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(28, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nome:";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(479, 42);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(99, 27);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnEdita
            // 
            this.btnEdita.Location = new System.Drawing.Point(646, 43);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(102, 27);
            this.btnEdita.TabIndex = 2;
            this.btnEdita.Text = "Editar";
            this.btnEdita.UseVisualStyleBackColor = true;
            this.btnEdita.Click += new System.EventHandler(this.btnEdita_Click);
            // 
            // btnEsclui
            // 
            this.btnEsclui.Location = new System.Drawing.Point(800, 42);
            this.btnEsclui.Name = "btnEsclui";
            this.btnEsclui.Size = new System.Drawing.Size(96, 27);
            this.btnEsclui.TabIndex = 3;
            this.btnEsclui.Text = "Excluir";
            this.btnEsclui.UseVisualStyleBackColor = true;
            this.btnEsclui.Click += new System.EventHandler(this.btnEsclui_Click);
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(104, 43);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(317, 26);
            this.txtNomeConsulta.TabIndex = 4;
            // 
            // dgvAluno
            // 
            this.dgvAluno.AllowUserToAddRows = false;
            this.dgvAluno.AllowUserToDeleteRows = false;
            this.dgvAluno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(33, 99);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAluno.Size = new System.Drawing.Size(878, 405);
            this.dgvAluno.TabIndex = 5;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 545);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAluno";
            this.Text = "frmAluno";
            this.Load += new System.EventHandler(this.frmAluno_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Button btnEsclui;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label6;
    }
}