namespace teste_visual
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMnesagem = new System.Windows.Forms.Button();
            this.btnMensagem2 = new System.Windows.Forms.Button();
            this.btnMensagem3 = new System.Windows.Forms.Button();
            this.btnMensagem4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMensagem5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMnesagem
            // 
            this.btnMnesagem.Location = new System.Drawing.Point(605, 88);
            this.btnMnesagem.Name = "btnMnesagem";
            this.btnMnesagem.Size = new System.Drawing.Size(99, 31);
            this.btnMnesagem.TabIndex = 0;
            this.btnMnesagem.Text = "Feio";
            this.btnMnesagem.UseVisualStyleBackColor = true;
            this.btnMnesagem.Click += new System.EventHandler(this.btnMnesagem_Click);
            // 
            // btnMensagem2
            // 
            this.btnMensagem2.Location = new System.Drawing.Point(605, 139);
            this.btnMensagem2.Name = "btnMensagem2";
            this.btnMensagem2.Size = new System.Drawing.Size(99, 31);
            this.btnMensagem2.TabIndex = 1;
            this.btnMensagem2.Text = "Muito feio";
            this.btnMensagem2.UseVisualStyleBackColor = true;
            this.btnMensagem2.Click += new System.EventHandler(this.btnMensagem2_Click);
            // 
            // btnMensagem3
            // 
            this.btnMensagem3.Location = new System.Drawing.Point(605, 193);
            this.btnMensagem3.Name = "btnMensagem3";
            this.btnMensagem3.Size = new System.Drawing.Size(99, 36);
            this.btnMensagem3.TabIndex = 2;
            this.btnMensagem3.Text = "Cabrero";
            this.btnMensagem3.UseVisualStyleBackColor = true;
            this.btnMensagem3.Click += new System.EventHandler(this.btnMensagem3_Click);
            // 
            // btnMensagem4
            // 
            this.btnMensagem4.Location = new System.Drawing.Point(605, 252);
            this.btnMensagem4.Name = "btnMensagem4";
            this.btnMensagem4.Size = new System.Drawing.Size(99, 42);
            this.btnMensagem4.TabIndex = 3;
            this.btnMensagem4.Text = "Maligno";
            this.btnMensagem4.UseVisualStyleBackColor = true;
            this.btnMensagem4.Click += new System.EventHandler(this.btnMensagem4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "O quão feio você é ?";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnMensagem5
            // 
            this.btnMensagem5.Location = new System.Drawing.Point(605, 323);
            this.btnMensagem5.Name = "btnMensagem5";
            this.btnMensagem5.Size = new System.Drawing.Size(99, 40);
            this.btnMensagem5.TabIndex = 5;
            this.btnMensagem5.Text = "Nivel kevyn";
            this.btnMensagem5.UseVisualStyleBackColor = true;
            this.btnMensagem5.Click += new System.EventHandler(this.btnMensagem5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::teste_visual.Properties.Resources.Cassionataca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMensagem5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMensagem4);
            this.Controls.Add(this.btnMensagem3);
            this.Controls.Add(this.btnMensagem2);
            this.Controls.Add(this.btnMnesagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMensagem5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMensagem4;
        private System.Windows.Forms.Button btnMensagem3;
        private System.Windows.Forms.Button btnMensagem2;
        private System.Windows.Forms.Button btnMnesagem;
    }
}

