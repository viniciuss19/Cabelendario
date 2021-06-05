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
    public partial class MostrarAgendamentos : Form
    {
        public MostrarAgendamentos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGVHorariosAgendados.Rows[e.RowIndex];
            tbDias.Text = row.Cells["Dia"].Value.ToString();
            tbHoras.Text = row.Cells["Horas"].Value.ToString();
            tbServiços.Text = row.Cells["Serviço"].Value.ToString();
            tbBarbearia.Text = row.Cells["Barbearia"].Value.ToString();
        }

        private void MostrarAgendamentos_Load(object sender, EventArgs e)
        {
            AtualizarHorariosAgendados();
            lblNomeUser.Text = TelaLogin.UserCliente;
            
            tbBarbearia.Enabled = false;
            tbDias.Enabled = false;
            tbHoras.Enabled = false;
            tbServiços.Enabled = false;
        }
        public void AtualizarHorariosAgendados()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;


            sql.CommandText = $"SELECT Dia,Horas,Serviço,Barbearia FROM HoráriosAgendados WHERE Cliente = '{TelaLogin.UserCliente}'";
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
                DGVHorariosAgendados.DataSource = tabela;
                DGVHorariosAgendados.ClearSelection();
                conexao.Close();
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DesmarcarHorario();
            RetornarAgendamentosDisponivel();
        }
        public void DesmarcarHorario()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

          
            try
            {
                conexao.Open();
                sql.CommandText = $"DELETE FROM HoráriosAgendados WHERE Dia = '{tbDias.Text}'  AND Horas = '{tbHoras.Text}' AND Serviço = '{tbServiços.Text}' AND Barbearia = '{tbBarbearia.Text}' ";
                sql.ExecuteNonQuery();
                



                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                
                MessageBox.Show($"Seu serviço {tbServiços.Text} no dia {tbDias.Text} às {tbHoras.Text} foi desmarcado com sucesso com sucesso");
                AtualizarHorariosAgendados();   
                
                
                conexao.Close();
            }
           
            

        }
        public void RetornarAgendamentosDisponivel()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;


            try
            {
                conexao.Open();
                sql.CommandText = "INSERT INTO Horários(dia,horas,Barbearia) VALUES (@Dia,@Horas,@barbearia)";
                sql.Parameters.AddWithValue("@Dia", tbDias.Text);
                sql.Parameters.AddWithValue("@Horas", tbHoras.Text);
                sql.Parameters.AddWithValue("@barbearia", tbBarbearia.Text);

                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                AtualizarHorariosAgendados();
                conexao.Close();
            }
            tbDias.Text = "";
            tbHoras.Text = "";
            tbServiços.Text = "";
            tbBarbearia.Text = "";
        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {
            new MenuCliente().Show();
        }
    }
}
