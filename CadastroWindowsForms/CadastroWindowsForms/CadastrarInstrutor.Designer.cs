namespace WindowsFormsCadastro
{
    partial class CadastrarInstrutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarInstrutor));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome_instrutor = new System.Windows.Forms.TextBox();
            this.telefone_instrutor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endereco_instrutor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.instrutor_cpf = new System.Windows.Forms.TextBox();
            this.instrutor = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cadastrar_instrutor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // nome_instrutor
            // 
            this.nome_instrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_instrutor.Location = new System.Drawing.Point(165, 15);
            this.nome_instrutor.Name = "nome_instrutor";
            this.nome_instrutor.Size = new System.Drawing.Size(497, 31);
            this.nome_instrutor.TabIndex = 4;
            this.nome_instrutor.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // telefone_instrutor
            // 
            this.telefone_instrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone_instrutor.Location = new System.Drawing.Point(165, 177);
            this.telefone_instrutor.Mask = "000000000";
            this.telefone_instrutor.Name = "telefone_instrutor";
            this.telefone_instrutor.Size = new System.Drawing.Size(497, 31);
            this.telefone_instrutor.TabIndex = 7;
            this.telefone_instrutor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTel_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Endereço";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // endereco_instrutor
            // 
            this.endereco_instrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereco_instrutor.Location = new System.Drawing.Point(165, 114);
            this.endereco_instrutor.Name = "endereco_instrutor";
            this.endereco_instrutor.Size = new System.Drawing.Size(497, 31);
            this.endereco_instrutor.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "CPF";
            // 
            // instrutor_cpf
            // 
            this.instrutor_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrutor_cpf.Location = new System.Drawing.Point(165, 61);
            this.instrutor_cpf.Name = "instrutor_cpf";
            this.instrutor_cpf.Size = new System.Drawing.Size(497, 31);
            this.instrutor_cpf.TabIndex = 18;
            // 
            // instrutor
            // 
            this.instrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrutor.FormattingEnabled = true;
            this.instrutor.ItemHeight = 25;
            this.instrutor.Location = new System.Drawing.Point(12, 355);
            this.instrutor.Name = "instrutor";
            this.instrutor.Size = new System.Drawing.Size(776, 129);
            this.instrutor.TabIndex = 23;
            this.instrutor.SelectedIndexChanged += new System.EventHandler(this.instrutor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "LISTAGEM DE INSTRUTORES";
            // 
            // cadastrar_instrutor
            // 
            this.cadastrar_instrutor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastrar_instrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar_instrutor.Location = new System.Drawing.Point(190, 235);
            this.cadastrar_instrutor.Name = "cadastrar_instrutor";
            this.cadastrar_instrutor.Size = new System.Drawing.Size(165, 58);
            this.cadastrar_instrutor.TabIndex = 14;
            this.cadastrar_instrutor.Text = "Cadastrar";
            this.cadastrar_instrutor.UseVisualStyleBackColor = false;
            this.cadastrar_instrutor.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 58);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastrarInstrutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.instrutor);
            this.Controls.Add(this.instrutor_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endereco_instrutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cadastrar_instrutor);
            this.Controls.Add(this.telefone_instrutor);
            this.Controls.Add(this.nome_instrutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarInstrutor";
            this.Text = "Cadastrar Instrutor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nome_instrutor;
        private System.Windows.Forms.MaskedTextBox telefone_instrutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox endereco_instrutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox instrutor_cpf;
        private System.Windows.Forms.ListBox instrutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cadastrar_instrutor;
        private System.Windows.Forms.Button button1;
    }
}

