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

namespace ContaBancaria.UserControls
{
    public partial class UserControlCadastrarConta : UserControl
    {
        public UserControlCadastrarConta()
        {
            InitializeComponent();
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroConta.Text == "" || textBoxNome.Text == "" || textBoxValorDeposito.Text == "")
            {
                MessageBox.Show("Nenhum campo deve estar vazio!");
            }
            else 
            {
                string valorTextBoxNrConta = textBoxNumeroConta.Text;
                string valorTextBoxNome = textBoxNome.Text;
                string valorTextBoxValorDeposito = textBoxValorDeposito.Text;

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
                            comando.Parameters.AddWithValue("@NumeroConta", valorTextBoxNrConta);
                            comando.Parameters.AddWithValue("@Nome", valorTextBoxNome);
                            comando.Parameters.AddWithValue("@Saldo", valorTextBoxValorDeposito);

                            comando.CommandText = "INSERT INTO Cliente (NumeroConta, Nome, Saldo) VALUES (@NumeroConta, @Nome, @Saldo)";

                            comando.ExecuteNonQuery();
                            MessageBox.Show("Cliente Inserido com Sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                    }
                }

                textBoxNumeroConta.Text = "";
                textBoxNome.Text = "";
                textBoxValorDeposito.Text = "";
            }
        }
    }
}
