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

        }

        private void MostrarAgendamentos_Load(object sender, EventArgs e)
        {
            AtualizarHorariosAgendados();
        }
        public void AtualizarHorariosAgendados()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;


            sql.CommandText = $"SELECT Dia,Horas,Serviço,Barbearia FROM HoráriosAgendados";
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
                DGVHA.DataSource = tabela;
                DGVHA.ClearSelection();
                conexao.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Agendamento().Show();
            this.Hide();
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
                sql.CommandText = "DELETE FROM HoráriosAgendados WHERE Dia = '" + tbDias.Text + " ' AND Horas = '" + tbHoras.Text + " ' AND Serviço = '" + tbServiços.Text + " '";
                sql.ExecuteNonQuery();
                



                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                
                MessageBox.Show($"Seu serviço {tbServiços.Text} no dia {tbDias.Text} às {tbHoras.Text} foi desmarcada com sucesso com sucesso");
                AtualizarHorariosAgendados();
                
                tbDias.Clear();
                tbHoras.Clear();
                tbServiços.Clear();
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
                sql.CommandText = "INSERT INTO Horários(dia,horas) VALUES (@Dia,@Horas)";
                sql.Parameters.AddWithValue("@Dia", tbDias.Text);
                sql.Parameters.AddWithValue("@Horas", tbHoras.Text);

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
        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {
            new MenuCliente().Show();
        }
    }
}
