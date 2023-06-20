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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CheckBoxConfirmPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
            }
        }

        public static List<string[]> ObterNomeSenhaAdmins(string connectionString)
        {
            List<string[]> admins = new List<string[]>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Nome, Senha FROM Admin_ContaBancaria", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string nome = reader["Nome"].ToString();
                        string senha = reader["Senha"].ToString();

                        string[] admin = new string[] { nome, senha };
                        admins.Add(admin);
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar: " + ex.Message);
                }
            }

            return admins;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=MELVINPC\SQLEXPRESS;Database=ContaBancaria;Trusted_Connection=True";

            List<string[]> admins = ObterNomeSenhaAdmins(connectionString);

            string valorTextBoxUsername = textBoxUsername.Text;
            string valorTextBoxPassword = textBoxPassword.Text;

            bool adminEncontrado = false; // Variável para indicar se o cliente foi encontrado

            foreach (string[] admin in admins)
            {
                string nome = admin[0];
                string senha = admin[1];

                if (valorTextBoxUsername.Equals(nome) && valorTextBoxPassword.Equals(senha))
                {
                    Principal principal = new Principal();
                    principal.Show();
                    adminEncontrado = true; // Admin encontrado
                    this.Hide();

                    break; // Encerra o loop, pois o admin foi encontrado
                }
            }

            if (!adminEncontrado)
            {
                MessageBox.Show("Nome de usuário ou senha incorretos. Por favor, tente novamente.", "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxUsername.Focus();
            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }
    }
}
