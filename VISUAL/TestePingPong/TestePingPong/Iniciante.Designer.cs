namespace TestePingPong
{
    partial class Iniciante
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

        #region Código gerado pelo Windows Form Designer

        //CÓDIGO FEITO PELO DESENVOLVEDOR PARA FORMATAÇÃO DO DESIGNER (NÃO MEXER)

        private void InitializeComponent()
        {

            //CÓDIGO QUE INICIALIZA TODAS AS VARIÁVEIS, IMAGENS, AÇÕES E ETC --> INICIANTE

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciante));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Label();
            this.picRaquete = new System.Windows.Forms.PictureBox();
            this.picBola = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).BeginInit();
            this.SuspendLayout();

            // INICIALIZANDO TIMER 1 --> INICANTE
 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // DECLARANDO FORMATAÇÃO PARA A LABEL DO RESULTADO --> INICIANTE
 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.lblResultado.Location = new System.Drawing.Point(125, 85);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 30);
            this.lblResultado.TabIndex = 4;
            
            //DECLARANDO FORMATAÇÃO PARA A LABLE DA PONTUAÇÃO --> INICANTE

            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.lblPontos.Location = new System.Drawing.Point(16, 85);
            this.lblPontos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(99, 30);
            this.lblPontos.TabIndex = 15;
            this.lblPontos.Text = "Pontos:";

            // DECLARANDO FORMATAÇÃO PARA O BOTÃO DE VOLTAR --> INICIANTE

            this.btnVoltar.AutoSize = true;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(120)))), ((int)(((byte)(223)))));
            this.btnVoltar.Location = new System.Drawing.Point(16, 34);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 30);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // DECLARANDO FORMATAÇÃO PARA O BOTÃO DE REINICIAR --> INICIANTE

            this.btnReiniciar.AutoSize = true;
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(120)))), ((int)(((byte)(223)))));
            this.btnReiniciar.Location = new System.Drawing.Point(147, 34);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(116, 30);
            this.btnReiniciar.TabIndex = 17;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);

            //DECLARANDO FORMATAÇÃO PARA A RAQUETE --> INICIANTE
 
            this.picRaquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(68)))), ((int)(((byte)(140)))));
            this.picRaquete.Location = new System.Drawing.Point(1073, 85);
            this.picRaquete.Margin = new System.Windows.Forms.Padding(4);
            this.picRaquete.Name = "picRaquete";
            this.picRaquete.Size = new System.Drawing.Size(57, 375);
            this.picRaquete.TabIndex = 3;
            this.picRaquete.TabStop = false;

            //DECLARANDO FORMATAÇÃO PARA A BOLINHA --> INICIANTE

            this.picBola.BackColor = System.Drawing.Color.Transparent;
            this.picBola.Image = global::TestePingPong.Properties.Resources.OIP_removebg_preview__2_;
            this.picBola.Location = new System.Drawing.Point(788, 180);
            this.picBola.Margin = new System.Windows.Forms.Padding(4);
            this.picBola.Name = "picBola";
            this.picBola.Size = new System.Drawing.Size(81, 78);
            this.picBola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBola.TabIndex = 2;
            this.picBola.TabStop = false;
            this.picBola.Click += new System.EventHandler(this.picBola_Click);

            //DECLARANDO FORMATAÇÃO PARA A LABLE QUE AVANÇA O NÍVEL --> INICIANTE

            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(120)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(813, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ir para o próximo nível>> ";
            this.label1.Click += new System.EventHandler(this.label1_Click);

            //DEFININDO FUNÇÃO ON CLICK PARA O BOTÃO INICIANTE

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1128, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.picRaquete);
            this.Controls.Add(this.picBola);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Iniciante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciante";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picRaquete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //CÓDIGO DAS IMAGENS, LABEL'S E BOTÕES --> INICIANTE

        private System.Windows.Forms.PictureBox picRaquete;
        private System.Windows.Forms.PictureBox picBola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label btnVoltar;
        private System.Windows.Forms.Label btnReiniciar;
        private System.Windows.Forms.Label label1;
    }
}

