namespace Atividade_jogo
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
            this.facil = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.Label();
            this.instru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // facil
            // 
            this.facil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.facil.Location = new System.Drawing.Point(162, 343);
            this.facil.Name = "facil";
            this.facil.Size = new System.Drawing.Size(109, 38);
            this.facil.TabIndex = 0;
            this.facil.Text = "JOGAR";
            this.facil.UseVisualStyleBackColor = true;
            this.facil.Click += new System.EventHandler(this.facil_Click);
            // 
            // txtStart
            // 
            this.txtStart.AutoSize = true;
            this.txtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtStart.Location = new System.Drawing.Point(95, 210);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(265, 25);
            this.txtStart.TabIndex = 3;
            this.txtStart.Text = "CLIQUE PARA COMEÇAR";
            // 
            // instru
            // 
            this.instru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.instru.Location = new System.Drawing.Point(141, 36);
            this.instru.Name = "instru";
            this.instru.Size = new System.Drawing.Size(152, 38);
            this.instru.TabIndex = 4;
            this.instru.Text = "INSTRUÇÕES";
            this.instru.UseVisualStyleBackColor = true;
            this.instru.Click += new System.EventHandler(this.instru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 489);
            this.Controls.Add(this.instru);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.facil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button facil;
        private System.Windows.Forms.Label txtStart;
        private System.Windows.Forms.Button instru;
    }
}

