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
    public partial class BarbeariaAgendamentos : Form
    {
        public BarbeariaAgendamentos()
        {
            InitializeComponent();
        }

        private void BarbeariaAgendamentos_Load(object sender, EventArgs e)
        {
            tbServiços.Enabled = false;
            tbHoras.Enabled = false;
            tbDia.Enabled = false;
            tbCliente.Enabled = false;
            lblNomeBarbearia.Text = TelaLogin.NomeBarbearia;
            AtualizarHorários();
        }
        public void AtualizarHorários()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = "Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT Cliente,Dia,Horas,Serviço FROM HoráriosAgendados WHERE Barbearia = '{TelaLogin.NomeBarbearia}'";
            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvBarbeariaHorarios.DataSource = tabela;
                dgvBarbeariaHorarios.ClearSelection();
                conexao.Close();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {
            new MenuBarbeariaGerenciar().Show();
        }

        private void dgvBarbeariaHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvBarbeariaHorarios.Rows[e.RowIndex];
            tbDia.Text = row.Cells["Dia"].Value.ToString();
            tbHoras.Text = row.Cells["Horas"].Value.ToString();
            tbServiços.Text = row.Cells["Serviço"].Value.ToString();
            tbCliente.Text = row.Cells["Cliente"].Value.ToString();
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
                sql.CommandText = $"DELETE FROM HoráriosAgendados WHERE Dia = '{tbDia.Text}'  AND Horas = '{tbHoras.Text}' AND Serviço = '{tbServiços.Text}' AND Cliente = '{tbCliente.Text}' ";
                sql.ExecuteNonQuery();




                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {

                MessageBox.Show($"O dia {tbDia.Text} às {tbHoras.Text} foi desmarcado com sucesso com sucesso");
                AtualizarHorários();
                tbDia.Text = "";
                tbHoras.Text = "";
                tbServiços.Text = "";
                tbCliente.Text = "";

                conexao.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RemoverHorário();
            RetornarHorário();
            AtualizarHorários();
            
            
        }
        public void RetornarHorário()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText = "INSERT INTO Horários(dia,horas,Barbearia) VALUES (@Dia,@Horas,@barbearia)";
                sql.Parameters.AddWithValue("@Dia", tbDia.Text);
                sql.Parameters.AddWithValue("@Horas", tbHoras.Text);
                sql.Parameters.AddWithValue("@barbearia", tbCliente.Text);

                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                tbDia.Text = "";
                tbHoras.Text = "";
                tbServiços.Text = "";
                tbCliente.Text = "";
                conexao.Close();
            }
           

        }
    }
}
