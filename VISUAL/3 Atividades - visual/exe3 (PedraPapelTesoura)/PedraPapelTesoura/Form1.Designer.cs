namespace PedraPapelTesoura
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rdbPedra = new System.Windows.Forms.RadioButton();
            this.rdbPapel = new System.Windows.Forms.RadioButton();
            this.rdbTesoura = new System.Windows.Forms.RadioButton();
            this.cmbJogador = new System.Windows.Forms.ComboBox();
            this.cmbComputador = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ptbComputador = new System.Windows.Forms.PictureBox();
            this.ptbJogador = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.lblComputador = new System.Windows.Forms.Label();
            this.ptbPC = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(94, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "JOGADOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(698, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "COMPUTADOR";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(390, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "JOGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.Location = new System.Drawing.Point(701, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "TERMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button3.Location = new System.Drawing.Point(97, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "LIMPAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdbPedra
            // 
            this.rdbPedra.AutoSize = true;
            this.rdbPedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbPedra.Location = new System.Drawing.Point(97, 349);
            this.rdbPedra.Name = "rdbPedra";
            this.rdbPedra.Size = new System.Drawing.Size(73, 21);
            this.rdbPedra.TabIndex = 11;
            this.rdbPedra.Text = "PEDRA";
            this.rdbPedra.UseVisualStyleBackColor = true;
            // 
            // rdbPapel
            // 
            this.rdbPapel.AutoSize = true;
            this.rdbPapel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbPapel.Location = new System.Drawing.Point(390, 349);
            this.rdbPapel.Name = "rdbPapel";
            this.rdbPapel.Size = new System.Drawing.Size(70, 21);
            this.rdbPapel.TabIndex = 12;
            this.rdbPapel.Text = "PAPEL";
            this.rdbPapel.UseVisualStyleBackColor = true;
            // 
            // rdbTesoura
            // 
            this.rdbTesoura.AutoSize = true;
            this.rdbTesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbTesoura.Location = new System.Drawing.Point(701, 349);
            this.rdbTesoura.Name = "rdbTesoura";
            this.rdbTesoura.Size = new System.Drawing.Size(93, 21);
            this.rdbTesoura.TabIndex = 13;
            this.rdbTesoura.Text = "TESOURA";
            this.rdbTesoura.UseVisualStyleBackColor = true;
            // 
            // cmbJogador
            // 
            this.cmbJogador.FormattingEnabled = true;
            this.cmbJogador.Items.AddRange(new object[] {
            "Ramon Dino",
            "Chris Bumstead",
            "Fabio Giga",
            "Jay Cutler",
            "Ronnie Coleman",
            "Zyzz"});
            this.cmbJogador.Location = new System.Drawing.Point(97, 173);
            this.cmbJogador.Name = "cmbJogador";
            this.cmbJogador.Size = new System.Drawing.Size(150, 21);
            this.cmbJogador.TabIndex = 17;
            this.cmbJogador.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbComputador
            // 
            this.cmbComputador.FormattingEnabled = true;
            this.cmbComputador.Items.AddRange(new object[] {
            "Ramon Dino",
            "Chris Bumstead",
            "Fabio Giga",
            "Jay Cutler",
            "Ronnie Coleman",
            "Zyzz"});
            this.cmbComputador.Location = new System.Drawing.Point(701, 173);
            this.cmbComputador.Name = "cmbComputador";
            this.cmbComputador.Size = new System.Drawing.Size(151, 21);
            this.cmbComputador.TabIndex = 18;
            this.cmbComputador.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PedraPapelTesoura.Properties.Resources.tesoura1;
            this.pictureBox7.Location = new System.Drawing.Point(701, 393);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(151, 81);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PedraPapelTesoura.Properties.Resources.papel1;
            this.pictureBox6.Location = new System.Drawing.Point(390, 393);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(145, 81);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PedraPapelTesoura.Properties.Resources.pedra1;
            this.pictureBox5.Location = new System.Drawing.Point(97, 393);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 81);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // ptbComputador
            // 
            this.ptbComputador.Location = new System.Drawing.Point(701, 213);
            this.ptbComputador.Name = "ptbComputador";
            this.ptbComputador.Size = new System.Drawing.Size(151, 124);
            this.ptbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbComputador.TabIndex = 7;
            this.ptbComputador.TabStop = false;
            this.ptbComputador.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // ptbJogador
            // 
            this.ptbJogador.Location = new System.Drawing.Point(97, 213);
            this.ptbJogador.Name = "ptbJogador";
            this.ptbJogador.Size = new System.Drawing.Size(150, 124);
            this.ptbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbJogador.TabIndex = 6;
            this.ptbJogador.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PedraPapelTesoura.Properties.Resources.versus;
            this.pictureBox2.Location = new System.Drawing.Point(390, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PedraPapelTesoura.Properties.Resources.tema;
            this.pictureBox1.Location = new System.Drawing.Point(286, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "PONTUAÇÃO DO JOGADOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "PONTUAÇÃO DO COMPUTADOR";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(295, 604);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(0, 13);
            this.lblJogador.TabIndex = 21;
            // 
            // lblComputador
            // 
            this.lblComputador.AutoSize = true;
            this.lblComputador.Location = new System.Drawing.Point(600, 604);
            this.lblComputador.Name = "lblComputador";
            this.lblComputador.Size = new System.Drawing.Size(0, 13);
            this.lblComputador.TabIndex = 22;
            // 
            // ptbPC
            // 
            this.ptbPC.Location = new System.Drawing.Point(858, 213);
            this.ptbPC.Name = "ptbPC";
            this.ptbPC.Size = new System.Drawing.Size(133, 124);
            this.ptbPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPC.TabIndex = 23;
            this.ptbPC.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(855, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Escolha do computador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptbPC);
            this.Controls.Add(this.lblComputador);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbComputador);
            this.Controls.Add(this.cmbJogador);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.rdbTesoura);
            this.Controls.Add(this.rdbPapel);
            this.Controls.Add(this.rdbPedra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ptbComputador);
            this.Controls.Add(this.ptbJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbJogador;
        private System.Windows.Forms.PictureBox ptbComputador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdbPedra;
        private System.Windows.Forms.RadioButton rdbPapel;
        private System.Windows.Forms.RadioButton rdbTesoura;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ComboBox cmbJogador;
        private System.Windows.Forms.ComboBox cmbComputador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Label lblComputador;
        private System.Windows.Forms.PictureBox ptbPC;
        private System.Windows.Forms.Label label5;
    }
}

