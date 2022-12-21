namespace Atividade_jogo
{
    partial class telaInstrucao
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
            this.obs = new System.Windows.Forms.Label();
            this.jogadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // obs
            // 
            this.obs.AutoSize = true;
            this.obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.obs.Location = new System.Drawing.Point(12, 72);
            this.obs.Name = "obs";
            this.obs.Size = new System.Drawing.Size(803, 50);
            this.obs.TabIndex = 0;
            this.obs.Text = "VOCÊ COMEÇARÁ MOVIMENTANDO O VITAO, DEPOIS YAN, BIEL E WESLEY... \r\nCOLOQUE TODOS " +
    "NO MESMO LUGAR PARA GANHAR";
            // 
            // jogadas
            // 
            this.jogadas.AutoSize = true;
            this.jogadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.jogadas.Location = new System.Drawing.Point(12, 181);
            this.jogadas.Name = "jogadas";
            this.jogadas.Size = new System.Drawing.Size(609, 200);
            this.jogadas.TabIndex = 1;
            this.jogadas.Text = "\r\nW (CIMA) A (ESQUERDA) S (BAIXO) D (DIREITA) --> VITAO\r\n\r\nU (CIMA) H (ESQUERDA) " +
    "J (BAIXO) K (DIREITA) --> WESLEY\r\n\r\nG (CIMA) C (ESQUERDA) V (BAIXO) B (DIREITA) " +
    "--> WESLEY\r\n\r\nSETINHAS --> YAN";
            // 
            // telaInstrucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 472);
            this.Controls.Add(this.jogadas);
            this.Controls.Add(this.obs);
            this.Name = "telaInstrucao";
            this.Text = "telaInstrucao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label obs;
        private System.Windows.Forms.Label jogadas;
    }
}