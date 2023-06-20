using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class FormRegister : System.Windows.Forms.Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "" || textBoxPassword.Text == "" || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Nenhum campo deve estar vazio!");
            } else if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                Login login = new Login();

                string valorTextBoxUsername = textBoxUsername.Text;
                string valorTextBoxSenha = textBoxPassword.Text;

                //adicionar dados a tabela
                using (SqlConnection conexao = new SqlConnection())
                {
                    conexao.ConnectionString = @"Server=MELVINPC\SQLEXPRESS;Database=ContaBancaria;Trusted_Connection=True";
                    conexao.Open();

                    try
                    {
                        using (SqlCommand comando = new SqlCommand())
                        {
                            comando.Connection = conexao;

                            //parâmetros
                            comando.Parameters.AddWithValue("@Nome", valorTextBoxUsername);
                            comando.Parameters.AddWithValue("@Senha", valorTextBoxSenha);

                            comando.CommandText = "INSERT INTO Admin_ContaBancaria (Nome, Senha) VALUES (@Nome, @Senha)";

                            comando.ExecuteNonQuery();
                            login.Show();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                    }
                }
            } else
            {
                MessageBox.Show("Palavra-passe não corresponde. Por favor, volte a digitar!");
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxPassword.Focus();
            }
        }

        private void CheckBoxConfirmPass_CheckedChanged(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
