using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CABELENDÁRIO
{
    public partial class MudarSenhaBarbearia : Form
    {
        public MudarSenhaBarbearia()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new MenuBarbeariaGerenciar().Show();
            this.Hide();
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
                    sql.CommandText = $"UPDATE Barbearias SET CPFDonoBarbearia = '{textBox2.Text}' WHERE NomeBarbearia = '{TelaLogin.NomeBarbearia}'";
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

        private void MudarSenhaBarbearia_Load(object sender, EventArgs e)
        {
            lblNomeUser.Text = TelaLogin.NomeBarbearia;
        }
    }
}
