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
    public partial class MenuCliente : Form
    {

        public MenuCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AtualizarBarbearias();

        }

        private void menuconfigs_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Barb1_Click(object sender, EventArgs e)
        {

        }

        private void Barb2_Click(object sender, EventArgs e)
        {

        }

        private void Barb3_Click(object sender, EventArgs e)
        {


        }

        private void Barb4_Click(object sender, EventArgs e)
        {
        }

        private void Barb5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MostrarAgendamentos().Show();
            this.Hide();
        }

        public void AtualizarBarbearias()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            sql.CommandText = "Select NomeBarbearia,EndereçoBarbearia FROM Barbearias";
            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvBarbearias.DataSource = tabela;
                dgvBarbearias.ClearSelection();
                conexao.Close();
            }
        }

    }
}
