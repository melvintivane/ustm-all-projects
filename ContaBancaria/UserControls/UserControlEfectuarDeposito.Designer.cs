namespace ContaBancaria.UserControls
{
    partial class UserControlEfectuarDeposito
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelDeposito = new System.Windows.Forms.Label();
            this.NumeroConta = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxValorDeposito = new System.Windows.Forms.TextBox();
            this.textBoxNomeDeposito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSaldoDeposito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.buttonCadastrar.TabIndex = 38;
            this.buttonCadastrar.Text = "Depositar";
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
            this.labelDeposito.TabIndex = 35;
            this.labelDeposito.Text = "Valor a Depositar";
            // 
            // NumeroConta
            // 
            this.NumeroConta.AutoSize = true;
            this.NumeroConta.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroConta.ForeColor = System.Drawing.Color.DimGray;
            this.NumeroConta.Location = new System.Drawing.Point(193, 215);
            this.NumeroConta.Name = "NumeroConta";
            this.NumeroConta.Size = new System.Drawing.Size(154, 25);
            this.NumeroConta.TabIndex = 36;
            this.NumeroConta.Text = "Seleccione a  Conta";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.DimGray;
            this.labelUsername.Location = new System.Drawing.Point(525, 215);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(126, 25);
            this.labelUsername.TabIndex = 37;
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
            this.textBoxValorDeposito.TabIndex = 32;
            // 
            // textBoxNomeDeposito
            // 
            this.textBoxNomeDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxNomeDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeDeposito.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxNomeDeposito.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeDeposito.Location = new System.Drawing.Point(530, 243);
            this.textBoxNomeDeposito.Multiline = true;
            this.textBoxNomeDeposito.Name = "textBoxNomeDeposito";
            this.textBoxNomeDeposito.ReadOnly = true;
            this.textBoxNomeDeposito.Size = new System.Drawing.Size(250, 30);
            this.textBoxNomeDeposito.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 31;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(210, 363);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Archivo", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 48);
            this.label1.TabIndex = 29;
            this.label1.Text = "Efectuar Depósito";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(525, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Saldo da Conta";
            // 
            // textBoxSaldoDeposito
            // 
            this.textBoxSaldoDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSaldoDeposito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSaldoDeposito.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxSaldoDeposito.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaldoDeposito.Location = new System.Drawing.Point(530, 346);
            this.textBoxSaldoDeposito.Multiline = true;
            this.textBoxSaldoDeposito.Name = "textBoxSaldoDeposito";
            this.textBoxSaldoDeposito.ReadOnly = true;
            this.textBoxSaldoDeposito.Size = new System.Drawing.Size(250, 30);
            this.textBoxSaldoDeposito.TabIndex = 51;
            // 
            // UserControlEfectuarDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSaldoDeposito);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.labelDeposito);
            this.Controls.Add(this.NumeroConta);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxValorDeposito);
            this.Controls.Add(this.textBoxNomeDeposito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(275, 0);
            this.Name = "UserControlEfectuarDeposito";
            this.Size = new System.Drawing.Size(1140, 698);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label labelDeposito;
        private System.Windows.Forms.Label NumeroConta;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxValorDeposito;
        private System.Windows.Forms.TextBox textBoxNomeDeposito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSaldoDeposito;
    }
}
