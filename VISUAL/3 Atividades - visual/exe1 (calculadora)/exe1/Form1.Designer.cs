namespace exe1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMSG = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdSoma = new System.Windows.Forms.RadioButton();
            this.rdSub = new System.Windows.Forms.RadioButton();
            this.rdDiv = new System.Windows.Forms.RadioButton();
            this.rdMul = new System.Windows.Forms.RadioButton();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(44, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(44, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor 2:";
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblMSG.Location = new System.Drawing.Point(44, 328);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(121, 25);
            this.lblMSG.TabIndex = 2;
            this.lblMSG.Text = "Resultado: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Location = new System.Drawing.Point(49, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.Location = new System.Drawing.Point(172, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdSoma
            // 
            this.rdSoma.AutoSize = true;
            this.rdSoma.Checked = true;
            this.rdSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rdSoma.Location = new System.Drawing.Point(354, 93);
            this.rdSoma.Name = "rdSoma";
            this.rdSoma.Size = new System.Drawing.Size(92, 29);
            this.rdSoma.TabIndex = 5;
            this.rdSoma.TabStop = true;
            this.rdSoma.Text = "Somar";
            this.rdSoma.UseVisualStyleBackColor = true;
            // 
            // rdSub
            // 
            this.rdSub.AutoSize = true;
            this.rdSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rdSub.Location = new System.Drawing.Point(354, 146);
            this.rdSub.Name = "rdSub";
            this.rdSub.Size = new System.Drawing.Size(105, 29);
            this.rdSub.TabIndex = 6;
            this.rdSub.Text = "Subtrair";
            this.rdSub.UseVisualStyleBackColor = true;
            // 
            // rdDiv
            // 
            this.rdDiv.AutoSize = true;
            this.rdDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rdDiv.Location = new System.Drawing.Point(354, 200);
            this.rdDiv.Name = "rdDiv";
            this.rdDiv.Size = new System.Drawing.Size(90, 29);
            this.rdDiv.TabIndex = 7;
            this.rdDiv.Text = "Dividir";
            this.rdDiv.UseVisualStyleBackColor = true;
            // 
            // rdMul
            // 
            this.rdMul.AutoSize = true;
            this.rdMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rdMul.Location = new System.Drawing.Point(354, 257);
            this.rdMul.Name = "rdMul";
            this.rdMul.Size = new System.Drawing.Size(128, 29);
            this.rdMul.TabIndex = 8;
            this.rdMul.Text = "Multiplicar";
            this.rdMul.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt1.Location = new System.Drawing.Point(47, 97);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(226, 31);
            this.txt1.TabIndex = 9;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txt2.Location = new System.Drawing.Point(47, 176);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(226, 31);
            this.txt2.TabIndex = 10;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 429);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.rdMul);
            this.Controls.Add(this.rdDiv);
            this.Controls.Add(this.rdSub);
            this.Controls.Add(this.rdSoma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdSoma;
        private System.Windows.Forms.RadioButton rdSub;
        private System.Windows.Forms.RadioButton rdDiv;
        private System.Windows.Forms.RadioButton rdMul;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

