namespace carrinhos
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
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tmrCarroUm = new System.Windows.Forms.Timer(this.components);
            this.tmrCarroDois = new System.Windows.Forms.Timer(this.components);
            this.tmrCarroTres = new System.Windows.Forms.Timer(this.components);
            this.pctCarroTres = new System.Windows.Forms.PictureBox();
            this.pctCarroDois = new System.Windows.Forms.PictureBox();
            this.pctCarroUm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroDois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroUm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.btnStart.Location = new System.Drawing.Point(146, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.button2.Location = new System.Drawing.Point(400, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reiniciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tmrCarroUm
            // 
            this.tmrCarroUm.Interval = 50;
            this.tmrCarroUm.Tick += new System.EventHandler(this.tmrCarroUm_Tick);
            // 
            // tmrCarroDois
            // 
            this.tmrCarroDois.Interval = 50;
            this.tmrCarroDois.Tick += new System.EventHandler(this.tmrCarroDois_Tick);
            // 
            // tmrCarroTres
            // 
            this.tmrCarroTres.Interval = 50;
            this.tmrCarroTres.Tick += new System.EventHandler(this.tmrCarroTres_Tick);
            // 
            // pctCarroTres
            // 
            this.pctCarroTres.BackColor = System.Drawing.Color.MistyRose;
            this.pctCarroTres.Image = global::carrinhos.Properties.Resources.flash;
            this.pctCarroTres.Location = new System.Drawing.Point(35, 401);
            this.pctCarroTres.Name = "pctCarroTres";
            this.pctCarroTres.Size = new System.Drawing.Size(163, 120);
            this.pctCarroTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarroTres.TabIndex = 4;
            this.pctCarroTres.TabStop = false;
            // 
            // pctCarroDois
            // 
            this.pctCarroDois.BackColor = System.Drawing.SystemColors.Info;
            this.pctCarroDois.Image = global::carrinhos.Properties.Resources.minion;
            this.pctCarroDois.Location = new System.Drawing.Point(35, 270);
            this.pctCarroDois.Name = "pctCarroDois";
            this.pctCarroDois.Size = new System.Drawing.Size(163, 125);
            this.pctCarroDois.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarroDois.TabIndex = 3;
            this.pctCarroDois.TabStop = false;
            // 
            // pctCarroUm
            // 
            this.pctCarroUm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pctCarroUm.Image = global::carrinhos.Properties.Resources.crash;
            this.pctCarroUm.Location = new System.Drawing.Point(35, 119);
            this.pctCarroUm.Name = "pctCarroUm";
            this.pctCarroUm.Size = new System.Drawing.Size(163, 145);
            this.pctCarroUm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctCarroUm.TabIndex = 2;
            this.pctCarroUm.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 523);
            this.Controls.Add(this.pctCarroTres);
            this.Controls.Add(this.pctCarroDois);
            this.Controls.Add(this.pctCarroUm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroDois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarroUm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pctCarroUm;
        private System.Windows.Forms.Timer tmrCarroUm;
        private System.Windows.Forms.PictureBox pctCarroDois;
        private System.Windows.Forms.PictureBox pctCarroTres;
        private System.Windows.Forms.Timer tmrCarroDois;
        private System.Windows.Forms.Timer tmrCarroTres;
    }
}

