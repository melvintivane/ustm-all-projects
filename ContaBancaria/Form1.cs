using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class formRegister : System.Windows.Forms.Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Nenhum campo deve estar vazio!");
            } else if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                //connection.Open();
                //string register = "INSERT INTO Estudante VALUES ('" + textBoxUsername + " ',' " + textBoxPassword + ")";
                //connection.Close;

                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";

                MessageBox.Show("Conta Registrada Com Sucesso!");
            } else
            {
                MessageBox.Show("Palavra-passe não corresponde. Por favor, volte a digitar!");
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxPassword.Focus();
            }
        }

        private void checkBoxConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            } else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmPassword.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
