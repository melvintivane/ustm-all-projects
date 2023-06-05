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
    public partial class UserControlEfectuarDeposito : UserControl
    {
        public UserControlEfectuarDeposito()
        {
            InitializeComponent();

            string connectionString = @"Server=MELVINPC\SQLEXPRESS;Database=ContaBancaria;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT NumeroConta FROM Cliente";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBox1.Items.Clear();

                        while (reader.Read())
                        {
                            string numeroConta = reader.GetString(0);

                            comboBox1.Items.Add(numeroConta);
                        }
                    }
                }
            }
        }

     

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxValorDeposito.Text == "")
            {
                MessageBox.Show("O campo Deposito não deve estar vazio!");
            }
            else
            {
                string NrConta = comboBox1.SelectedItem.ToString();
                string saldo = textBoxSaldoDeposito.Text;
                string valorDeposito = textBoxValorDeposito.Text;

                decimal novoSaldo = Convert.ToDecimal(saldo) + Convert.ToDecimal(valorDeposito);

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
                            comando.Parameters.AddWithValue("@numeroConta", NrConta);
                            comando.Parameters.AddWithValue("@NovoSaldo", novoSaldo.ToString());

                            comando.CommandText = "UPDATE Cliente SET Saldo = @NovoSaldo WHERE NumeroConta = @numeroConta";

                            comando.ExecuteNonQuery();
                            MessageBox.Show("Depósito Efectuado com Sucesso!");
                        }

                        textBoxSaldoDeposito.Text = novoSaldo.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                    }
                }

                textBoxValorDeposito.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string connectionString = @"Server=MELVINPC\SQLEXPRESS;Database=ContaBancaria;Trusted_Connection=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectedClientId = comboBox1.SelectedItem.ToString(); // Obtém o ID selecionado como string

                string query = "SELECT Nome, Saldo FROM Cliente WHERE NumeroConta = @ClientId"; // Consulta SQL com parâmetro

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientId", selectedClientId); // Define o valor do parâmetro

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string clienteNome = reader.GetString(0); // Obtém o nome do cliente como string
                            decimal saldo = reader.GetDecimal(1);

                            textBoxNomeDeposito.Text = clienteNome;
                            textBoxSaldoDeposito.Text = saldo.ToString();
                        }
                        else
                        {
                            textBoxNomeDeposito.Text = ""; // Limpa o TextBox se nenhum nome for encontrado
                            textBoxSaldoDeposito.Text = "";
                        }
                    }
                }
            }
        }
    }
}
