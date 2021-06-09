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
            lblNomeUser.Text = TelaLogin.UserCliente;
            AtualizarBarbearias();
            tbBarbearia.Enabled = false;
            tbDia.Enabled = false;
            tbHoras.Enabled = false;
            tbPreço.Enabled = false;
            tbEndereço.Enabled = false;
            tbServiços.Enabled = false;
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
            if(tbBarbearia.Text == "")
            {
                MessageBox.Show("Selecione uma barbearia primeiro!");
                tbBarbearia.Focus();

            }
            else if (tbDia.Text == "")
            {
                MessageBox.Show("Selecione um Dia primeiro!");
                tbDia.Focus();

            }

            else if (tbServiços.Text == "")
            {
                MessageBox.Show("Selecione um Serviço primeiro");
                tbServiços.Focus();

            }

            AgendarHorário();
            RemoverHorário();
        
           

        }
        public void AgendarHorário()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            try
            {
                conexao.Open();
                sql.CommandText = $"INSERT INTO HoráriosAgendados (Cliente,Dia,Horas,Serviço,Barbearia) VALUES (@cliente,@dia,@horas,@serviço,@barbearia)";
                sql.Parameters.AddWithValue("@cliente", TelaLogin.UserCliente);
                sql.Parameters.AddWithValue("@dia", tbDia.Text);
                sql.Parameters.AddWithValue("@horas", tbHoras.Text);
                sql.Parameters.AddWithValue("@serviço", tbServiços.Text);
                sql.Parameters.AddWithValue("barbearia", tbBarbearia.Text);
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MessageBox.Show($"O Serviço de {tbServiços.Text} foi agendado no dia {tbDia.Text} as {tbHoras.Text} na barbearia {tbBarbearia.Text} com sucesso! ");
                conexao.Close();
                new MostrarAgendamentos().Show();
                this.Hide();
            }
        }
        public void RemoverHorário()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText = $"DELETE FROM Horários WHERE Dia = '{tbDia.Text}'  AND Horas = '{tbHoras.Text}'";
                sql.ExecuteNonQuery();
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {

                tbDia.Clear();
                tbHoras.Clear();
                conexao.Close();
            }
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

        private void btnPesquisarBarbearia_Click(object sender, EventArgs e)
        {
            PesquisarBarbearia();
        }
        public void PesquisarBarbearia()
        {
            lblBarbearia.Text = $"Busca por '{tbPesquisarBarbearia.Text}'";
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT NomeBarbearia,EndereçoBarbearia FROM Barbearias " +
                $"WHERE NomeBarbearia LIKE '%{tbPesquisarBarbearia.Text}%'";

            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvBarbearias.DataSource = tabela;
                dgvBarbearias.ClearSelection();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        private void lblBarbearia_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tbDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (tbBarbearia.Text == "")
            {
                MessageBox.Show("Selecione uma barbearia primeiro!");
            }
            else if(tbPesquisarDia.Text == "")
            {
                MessageBox.Show("Digite o horário que você deseja pesquisar primeiro!");
            }
            else
            {
                PesquisarDias();
            }
        }
        public void PesquisarDias()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;


            sql.CommandText = $"SELECT dia,horas,Barbearia FROM Horários WHERE dia LIKE '%{tbPesquisarDia.Text}%' AND Barbearia = '{tbBarbearia.Text}'";
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
                dgvHorário.DataSource = tabela;
                dgvHorário.ClearSelection();
                conexao.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MudarSenhaCliente().Show();
            this.Hide();
        }
    }
}
