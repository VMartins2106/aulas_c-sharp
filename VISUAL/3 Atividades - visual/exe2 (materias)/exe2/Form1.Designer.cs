namespace exe2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMSG = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.temporizadorDeCria = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lblCria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(67, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a disciplina";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblMSG.Location = new System.Drawing.Point(65, 249);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(174, 25);
            this.lblMSG.TabIndex = 1;
            this.lblMSG.Text = "Você deve usar: ";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnVerificar.Location = new System.Drawing.Point(70, 171);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(218, 46);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // cmbMateria
            // 
            this.cmbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Items.AddRange(new object[] {
            "Desenvolvimento de sistemas",
            "Programação mobile 1",
            "Programação web 2",
            "Banco de dados 2"});
            this.cmbMateria.Location = new System.Drawing.Point(70, 116);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(218, 25);
            this.cmbMateria.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnLimpar.Location = new System.Drawing.Point(295, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 46);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // temporizadorDeCria
            // 
            this.temporizadorDeCria.Interval = 1000;
            this.temporizadorDeCria.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(70, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "COMEÇAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCria
            // 
            this.lblCria.AutoSize = true;
            this.lblCria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCria.Location = new System.Drawing.Point(294, 24);
            this.lblCria.Name = "lblCria";
            this.lblCria.Size = new System.Drawing.Size(0, 25);
            this.lblCria.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 353);
            this.Controls.Add(this.lblCria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Timer temporizadorDeCria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCria;
    }
}

