namespace ContaBancaria.UserControls
{
    partial class UserControlCadastrarConta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelDeposito = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxValorDeposito = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxNumeroConta = new System.Windows.Forms.TextBox();
            this.NumeroConta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Archivo", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastar Conta";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrar.Location = new System.Drawing.Point(198, 423);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(250, 40);
            this.buttonCadastrar.TabIndex = 28;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // labelDeposito
            // 
            this.labelDeposito.AutoSize = true;
            this.labelDeposito.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeposito.ForeColor = System.Drawing.Color.DimGray;
            this.labelDeposito.Location = new System.Drawing.Point(193, 318);
            this.labelDeposito.Name = "labelDeposito";
            this.labelDeposito.Size = new System.Drawing.Size(133, 25);
            this.labelDeposito.TabIndex = 25;
            this.labelDeposito.Text = "Valor a Depositar";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labelUsername.Location = new System.Drawing.Point(525, 215);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(126, 25);
            this.labelUsername.TabIndex = 26;
            this.labelUsername.Text = "Nome do Titular";
            // 
            // textBoxValorDeposito
            // 
            this.textBoxValorDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxValorDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorDeposito.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorDeposito.Location = new System.Drawing.Point(198, 346);
            this.textBoxValorDeposito.Multiline = true;
            this.textBoxValorDeposito.Name = "textBoxValorDeposito";
            this.textBoxValorDeposito.Size = new System.Drawing.Size(250, 30);
            this.textBoxValorDeposito.TabIndex = 23;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(530, 243);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(250, 30);
            this.textBoxNome.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(209, 365);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 21;
            // 
            // textBoxNumeroConta
            // 
            this.textBoxNumeroConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxNumeroConta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNumeroConta.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroConta.Location = new System.Drawing.Point(198, 243);
            this.textBoxNumeroConta.Multiline = true;
            this.textBoxNumeroConta.Name = "textBoxNumeroConta";
            this.textBoxNumeroConta.Size = new System.Drawing.Size(250, 30);
            this.textBoxNumeroConta.TabIndex = 24;
            // 
            // NumeroConta
            // 
            this.NumeroConta.AutoSize = true;
            this.NumeroConta.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroConta.ForeColor = System.Drawing.Color.DimGray;
            this.NumeroConta.Location = new System.Drawing.Point(193, 215);
            this.NumeroConta.Name = "NumeroConta";
            this.NumeroConta.Size = new System.Drawing.Size(138, 25);
            this.NumeroConta.TabIndex = 26;
            this.NumeroConta.Text = "Número de Conta";
            // 
            // UserControlCadastrarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.labelDeposito);
            this.Controls.Add(this.NumeroConta);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxValorDeposito);
            this.Controls.Add(this.textBoxNumeroConta);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(275, 0);
            this.Name = "UserControlCadastrarConta";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1140, 698);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelDeposito;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxValorDeposito;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxNumeroConta;
        private System.Windows.Forms.Label NumeroConta;
    }
}
