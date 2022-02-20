
namespace Jogo_Pedra_Papel_e_Tesoura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imagemCPU = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imagemJogador = new System.Windows.Forms.PictureBox();
            this.botaoTesoura = new System.Windows.Forms.Button();
            this.botaoPapel = new System.Windows.Forms.Button();
            this.botaoPedra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemCPU)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagemJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.botaoTesoura);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPapel);
            this.splitContainer1.Panel2.Controls.Add(this.botaoPedra);
            this.splitContainer1.Size = new System.Drawing.Size(624, 444);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imagemCPU);
            this.groupBox2.Location = new System.Drawing.Point(418, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jogada CPU";
            // 
            // imagemCPU
            // 
            this.imagemCPU.Location = new System.Drawing.Point(29, 27);
            this.imagemCPU.Name = "imagemCPU";
            this.imagemCPU.Size = new System.Drawing.Size(165, 172);
            this.imagemCPU.TabIndex = 0;
            this.imagemCPU.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagemJogador);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minha Jogada";
            // 
            // imagemJogador
            // 
            this.imagemJogador.Location = new System.Drawing.Point(6, 36);
            this.imagemJogador.Name = "imagemJogador";
            this.imagemJogador.Size = new System.Drawing.Size(172, 172);
            this.imagemJogador.TabIndex = 0;
            this.imagemJogador.TabStop = false;
            // 
            // botaoTesoura
            // 
            this.botaoTesoura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoTesoura.BackgroundImage")));
            this.botaoTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoTesoura.Location = new System.Drawing.Point(424, 3);
            this.botaoTesoura.Name = "botaoTesoura";
            this.botaoTesoura.Size = new System.Drawing.Size(200, 214);
            this.botaoTesoura.TabIndex = 2;
            this.botaoTesoura.UseVisualStyleBackColor = true;
            // 
            // botaoPapel
            // 
            this.botaoPapel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPapel.BackgroundImage")));
            this.botaoPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoPapel.Location = new System.Drawing.Point(210, 3);
            this.botaoPapel.Name = "botaoPapel";
            this.botaoPapel.Size = new System.Drawing.Size(208, 214);
            this.botaoPapel.TabIndex = 1;
            this.botaoPapel.UseVisualStyleBackColor = true;
            this.botaoPapel.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoPedra
            // 
            this.botaoPedra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPedra.BackgroundImage")));
            this.botaoPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.botaoPedra.Location = new System.Drawing.Point(3, 3);
            this.botaoPedra.Name = "botaoPedra";
            this.botaoPedra.Size = new System.Drawing.Size(204, 214);
            this.botaoPedra.TabIndex = 0;
            this.botaoPedra.UseVisualStyleBackColor = true;
            this.botaoPedra.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 444);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra, Papel e Tesoura";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemCPU)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagemJogador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button botaoTesoura;
        private System.Windows.Forms.Button botaoPapel;
        private System.Windows.Forms.Button botaoPedra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imagemCPU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imagemJogador;
    }
}

