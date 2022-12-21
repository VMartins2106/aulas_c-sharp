namespace tela
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
            System.Windows.Forms.PictureBox pctImagem;
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            pctImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pctImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pctImagem
            // 
            pctImagem.Image = global::tela.Properties.Resources.OIP;
            pctImagem.Location = new System.Drawing.Point(178, 73);
            pctImagem.Name = "pctImagem";
            pctImagem.Size = new System.Drawing.Size(385, 276);
            pctImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pctImagem.TabIndex = 0;
            pctImagem.TabStop = false;
            pctImagem.Click += new System.EventHandler(this.pctImagem_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.AllowDrop = true;
            this.vScrollBar1.Location = new System.Drawing.Point(774, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 432);
            this.vScrollBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(pctImagem);
            this.Name = "Form1";
            this.Text = "Muhammad Ali É PICA";
            ((System.ComponentModel.ISupportInitialize)(pctImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

