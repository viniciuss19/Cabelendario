using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CABELENDÁRIO
{
    public partial class MudarSenhaCliente : Form
    {
        public MudarSenhaCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisarBarbearia_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");

            }
            else
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
                SqlCommand sql = new SqlCommand();
                sql.Connection = conexao;

                try
                {
                    conexao.Open();
                    sql.CommandText = $"UPDATE Clientes SET SenhaCliente = '{textBox2.Text}' WHERE UserCliente = '{TelaLogin.UserCliente}'";
                    int i = sql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    MessageBox.Show($"A senha foi alterada de {textBox1.Text} para {textBox2.Text} com sucesso!");
                    conexao.Close();
                }
            }
        }

        private void MudarSenhaCliente_Load(object sender, EventArgs e)
        {
            lblNomeUser.Text = TelaLogin.UserCliente;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new MenuCliente().Show();
            this.Hide();
        }
    }
}
