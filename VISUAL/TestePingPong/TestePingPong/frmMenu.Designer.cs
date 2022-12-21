namespace TestePingPong
{
    partial class frmMenu
    {
        //INICALIZADOR DE VARIÁVEL PARA DESIGN (NÃO INTERFERE NO CÓDIGO)

        private System.ComponentModel.IContainer components = null;

        //CÓDIGO PARA USAR APENAS OS ELEMENTOS COM AÇÃO (NÃO INTERFERE EM TODO O RESTO)

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnIniciante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIntermediario = new System.Windows.Forms.Button();
            this.btnAvançado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciante
            // 
            this.btnIniciante.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciante.FlatAppearance.BorderSize = 3;
            this.btnIniciante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.btnIniciante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnIniciante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciante.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciante.Location = new System.Drawing.Point(107, 87);
            this.btnIniciante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciante.Name = "btnIniciante";
            this.btnIniciante.Size = new System.Drawing.Size(207, 49);
            this.btnIniciante.TabIndex = 5;
            this.btnIniciante.Text = "Iniciante";
            this.btnIniciante.UseVisualStyleBackColor = true;
            this.btnIniciante.Click += new System.EventHandler(this.btnIniciante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o nível do jogo:";
            // 
            // btnIntermediario
            // 
            this.btnIntermediario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.btnIntermediario.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnIntermediario.FlatAppearance.BorderSize = 3;
            this.btnIntermediario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(210)))), ((int)(((byte)(173)))));
            this.btnIntermediario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnIntermediario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntermediario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermediario.Location = new System.Drawing.Point(107, 166);
            this.btnIntermediario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIntermediario.Name = "btnIntermediario";
            this.btnIntermediario.Size = new System.Drawing.Size(207, 49);
            this.btnIntermediario.TabIndex = 6;
            this.btnIntermediario.Text = "Intermediário";
            this.btnIntermediario.UseVisualStyleBackColor = false;
            this.btnIntermediario.Click += new System.EventHandler(this.btnIntermediario_Click);
            // 
            // btnAvançado
            // 
            this.btnAvançado.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAvançado.FlatAppearance.BorderSize = 3;
            this.btnAvançado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAvançado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAvançado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvançado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvançado.Location = new System.Drawing.Point(107, 249);
            this.btnAvançado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAvançado.Name = "btnAvançado";
            this.btnAvançado.Size = new System.Drawing.Size(207, 49);
            this.btnAvançado.TabIndex = 7;
            this.btnAvançado.Text = "Avançado";
            this.btnAvançado.UseVisualStyleBackColor = true;
            this.btnAvançado.Click += new System.EventHandler(this.btnAvançado_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(415, 370);
            this.Controls.Add(this.btnAvançado);
            this.Controls.Add(this.btnIntermediario);
            this.Controls.Add(this.btnIniciante);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //CÓDIGO DAS IMAGENS, LABEL'S E BOTÕES --> AVANÇADO

        private System.Windows.Forms.Button btnIniciante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIntermediario;
        private System.Windows.Forms.Button btnAvançado;
    }
}