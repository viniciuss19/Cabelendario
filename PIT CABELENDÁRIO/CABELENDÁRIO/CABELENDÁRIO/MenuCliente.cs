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

        private void dgvBarbearias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvBarbearias.Rows[e.RowIndex];
            tbBarbearia.Text = row.Cells["NomeBarbearia"].Value.ToString();
            tbEndereço.Text = row.Cells["EndereçoBarbearia"].Value.ToString();

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
           

            try
            {
                conexao.Open();
                string nomebarbearia = tbBarbearia.Text;
                sql.CommandText = $"SELECT dia,horas,Barbearia FROM Horários WHERE Barbearia = '{nomebarbearia}'";
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
                dgvHorário.DataSource = tabela;
                dgvHorário.ClearSelection();
                conexao.Close();
            }
            try
            {
                conexao.Open();
                string nomebarbearia = tbBarbearia.Text;
                sql.CommandText = $"SELECT Serviço,Preço FROM Serviços WHERE Barbearia = '{nomebarbearia}'";
                int i = sql.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText,conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvServiço.DataSource = tabela;
                dgvServiço.ClearSelection();
                conexao.Close();
            }



        }

        private void dgvHorário_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvHorário.Rows[e.RowIndex];
            tbDia.Text = row.Cells["dia"].Value.ToString();
            tbHoras.Text = row.Cells["horas"].Value.ToString();
        }

        private void dgvServiço_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvServiço.Rows[e.RowIndex];
            tbServiços.Text = row.Cells["Serviço"].Value.ToString();
            tbPreço.Text = row.Cells["Preço"].Value.ToString();
        }
    }
}
