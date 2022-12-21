namespace Cara_Coroa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdbCara = new System.Windows.Forms.RadioButton();
            this.rdbCoroa = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.ptbMoeda = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbComp = new System.Windows.Forms.PictureBox();
            this.lblMSG = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoeda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComp)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbCara
            // 
            this.rdbCara.AutoSize = true;
            this.rdbCara.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdbCara.Checked = true;
            this.rdbCara.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.75F);
            this.rdbCara.Location = new System.Drawing.Point(325, 318);
            this.rdbCara.Name = "rdbCara";
            this.rdbCara.Size = new System.Drawing.Size(99, 36);
            this.rdbCara.TabIndex = 0;
            this.rdbCara.TabStop = true;
            this.rdbCara.Text = "Cara";
            this.rdbCara.UseVisualStyleBackColor = false;
            this.rdbCara.CheckedChanged += new System.EventHandler(this.rdbCara_CheckedChanged);
            // 
            // rdbCoroa
            // 
            this.rdbCoroa.AutoSize = true;
            this.rdbCoroa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rdbCoroa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.75F);
            this.rdbCoroa.Location = new System.Drawing.Point(604, 318);
            this.rdbCoroa.Name = "rdbCoroa";
            this.rdbCoroa.Size = new System.Drawing.Size(116, 36);
            this.rdbCoroa.TabIndex = 1;
            this.rdbCoroa.Text = "Coroa";
            this.rdbCoroa.UseVisualStyleBackColor = false;
            this.rdbCoroa.CheckedChanged += new System.EventHandler(this.rdbCoroa_CheckedChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnVerificar.Location = new System.Drawing.Point(361, 605);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(297, 69);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptbMoeda
            // 
            this.ptbMoeda.Location = new System.Drawing.Point(409, 384);
            this.ptbMoeda.Name = "ptbMoeda";
            this.ptbMoeda.Size = new System.Drawing.Size(206, 151);
            this.ptbMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMoeda.TabIndex = 3;
            this.ptbMoeda.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptbComp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.groupBox1.Location = new System.Drawing.Point(371, 697);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "O COMPUTADOR ESCOLHEU :";
            // 
            // ptbComp
            // 
            this.ptbComp.Location = new System.Drawing.Point(74, 71);
            this.ptbComp.Name = "ptbComp";
            this.ptbComp.Size = new System.Drawing.Size(160, 113);
            this.ptbComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbComp.TabIndex = 0;
            this.ptbComp.TabStop = false;
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.lblMSG.Location = new System.Drawing.Point(57, 99);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(0, 47);
            this.lblMSG.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.Location = new System.Drawing.Point(778, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 65);
            this.button1.TabIndex = 6;
            this.button1.Text = "Novo jogo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 930);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ptbMoeda);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.rdbCoroa);
            this.Controls.Add(this.rdbCara);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoeda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCara;
        private System.Windows.Forms.RadioButton rdbCoroa;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox ptbMoeda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbComp;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Button button1;
    }
}

