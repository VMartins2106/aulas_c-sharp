namespace Projeto_academia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnPlano = new System.Windows.Forms.Button();
            this.tmrCria = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Projeto_academia.Properties.Resources.logo;
            this.pictureBox1.Image = global::Projeto_academia.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(59, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Projeto_academia.Properties.Resources.sair;
            this.button1.Location = new System.Drawing.Point(966, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 55);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.Transparent;
            this.btnAlunos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAlunos.Image = global::Projeto_academia.Properties.Resources.aluno;
            this.btnAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlunos.Location = new System.Drawing.Point(59, 193);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(241, 44);
            this.btnAlunos.TabIndex = 2;
            this.btnAlunos.Text = "ALUNOS";
            this.btnAlunos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.Color.Transparent;
            this.btnMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricula.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMatricula.Image = global::Projeto_academia.Properties.Resources.matricula;
            this.btnMatricula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatricula.Location = new System.Drawing.Point(59, 263);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(241, 54);
            this.btnMatricula.TabIndex = 3;
            this.btnMatricula.Text = "MATRÍCULA";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatricula.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsuario.Image = global::Projeto_academia.Properties.Resources.usuario;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(59, 406);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(241, 54);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "USUÁRIOS";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // btnPlano
            // 
            this.btnPlano.BackColor = System.Drawing.Color.Transparent;
            this.btnPlano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlano.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlano.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlano.Image = global::Projeto_academia.Properties.Resources.dumbbell;
            this.btnPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlano.Location = new System.Drawing.Point(59, 335);
            this.btnPlano.Name = "btnPlano";
            this.btnPlano.Size = new System.Drawing.Size(241, 54);
            this.btnPlano.TabIndex = 5;
            this.btnPlano.Text = "PLANOS";
            this.btnPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlano.UseVisualStyleBackColor = false;
            // 
            // tmrCria
            // 
            this.tmrCria.Enabled = true;
            this.tmrCria.Tick += new System.EventHandler(this.tmrCria_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_academia.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 583);
            this.Controls.Add(this.btnPlano);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnMatricula);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnMatricula;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnPlano;
        private System.Windows.Forms.Timer tmrCria;
    }
}

