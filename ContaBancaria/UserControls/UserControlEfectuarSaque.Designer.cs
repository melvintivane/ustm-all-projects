namespace ContaBancaria.UserControls
{
    partial class UserControlEfectuarSaque
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.labelDeposito = new System.Windows.Forms.Label();
            this.NumeroConta = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxValorSaque = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "asdf",
            "asdfgh"});
            this.comboBox1.Location = new System.Drawing.Point(198, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 49;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSacar
            // 
            this.buttonSacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSacar.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSacar.ForeColor = System.Drawing.Color.White;
            this.buttonSacar.Location = new System.Drawing.Point(198, 423);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(250, 40);
            this.buttonSacar.TabIndex = 48;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = false;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // labelDeposito
            // 
            this.labelDeposito.AutoSize = true;
            this.labelDeposito.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeposito.ForeColor = System.Drawing.Color.DimGray;
            this.labelDeposito.Location = new System.Drawing.Point(193, 318);
            this.labelDeposito.Name = "labelDeposito";
            this.labelDeposito.Size = new System.Drawing.Size(126, 25);
            this.labelDeposito.TabIndex = 45;
            this.labelDeposito.Text = "Valor a Levantar";
            // 
            // NumeroConta
            // 
            this.NumeroConta.AutoSize = true;
            this.NumeroConta.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroConta.ForeColor = System.Drawing.Color.DimGray;
            this.NumeroConta.Location = new System.Drawing.Point(193, 215);
            this.NumeroConta.Name = "NumeroConta";
            this.NumeroConta.Size = new System.Drawing.Size(154, 25);
            this.NumeroConta.TabIndex = 46;
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
            this.labelUsername.TabIndex = 47;
            this.labelUsername.Text = "Nome do Titular";
            // 
            // textBoxValorSaque
            // 
            this.textBoxValorSaque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxValorSaque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValorSaque.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorSaque.Location = new System.Drawing.Point(198, 346);
            this.textBoxValorSaque.Multiline = true;
            this.textBoxValorSaque.Name = "textBoxValorSaque";
            this.textBoxValorSaque.Size = new System.Drawing.Size(250, 30);
            this.textBoxValorSaque.TabIndex = 43;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxNome.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(530, 243);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(250, 30);
            this.textBoxNome.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 42;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(227, 351);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Archivo", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 48);
            this.label1.TabIndex = 40;
            this.label1.Text = "Efectuar Saque";
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSaldo.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxSaldo.Font = new System.Drawing.Font("Archivo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaldo.Location = new System.Drawing.Point(530, 346);
            this.textBoxSaldo.Multiline = true;
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.ReadOnly = true;
            this.textBoxSaldo.Size = new System.Drawing.Size(250, 30);
            this.textBoxSaldo.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Archivo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(525, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Saldo da Conta";
            // 
            // UserControlEfectuarSaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSacar);
            this.Controls.Add(this.labelDeposito);
            this.Controls.Add(this.NumeroConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxValorSaque);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(275, 0);
            this.Name = "UserControlEfectuarSaque";
            this.Size = new System.Drawing.Size(1140, 698);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.Label labelDeposito;
        private System.Windows.Forms.Label NumeroConta;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxValorSaque;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Label label3;
    }
}
