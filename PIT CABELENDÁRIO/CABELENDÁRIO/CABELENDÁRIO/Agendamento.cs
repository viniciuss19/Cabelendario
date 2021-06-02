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
    public partial class Agendamento : Form
    {
        public Agendamento()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new MenuCliente().Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Agendamento_Load(object sender, EventArgs e)
        {

            AtualizarHorarioAgendar();
            AtualizarServiçosAgendar();
        }
        public void AtualizarHorarioAgendar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            sql.CommandText = "Select dia,horas,barbearia FROM Horários";
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
                dgvHorariosAgendar.DataSource = tabela;
                dgvHorariosAgendar.ClearSelection();
                conexao.Close();
            }

        }
        public void AtualizarServiçosAgendar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            sql.CommandText = "Select * FROM Serviços";
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
                dgvServiçosAgendar.DataSource = tabela;
                dgvServiçosAgendar.ClearSelection();
                conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisarDia();
        }

        private void btPesquisarServiços_Click(object sender, EventArgs e)
        {
            PesquisarServiços();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btPesquisarHorario_Click(object sender, EventArgs e)
        {
            PesquisarHorario();
        }
        public void PesquisarHorario()
        {
            lblTBDATAS.Text = "Busca por datas...:";
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT dia,horas FROM Horários " +
                $"WHERE horas LIKE '%{tbHorarioAgendar.Text}%'";

            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvHorariosAgendar.DataSource = tabela;
                dgvHorariosAgendar.ClearSelection();
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
        public void PesquisarServiços()
        {
            lblTBDATAS.Text = "Busca por serviços...:";
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT Serviço,Preço FROM Serviços " +
                $"WHERE Serviço LIKE '%{tbServiçoAgendar.Text}%'";

            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvServiçosAgendar.DataSource = tabela;
                dgvServiçosAgendar.ClearSelection();
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
        public void PesquisarDia()
        {
            lblTBDATAS.Text = "Busca por datas...:";
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = $"SELECT dia,horas FROM Horários " +
                $"WHERE dia LIKE '%{tbDiaAgendar.Text}%'";

            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvHorariosAgendar.DataSource = tabela;
                dgvHorariosAgendar.ClearSelection();
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

        private void btAgendar_Click(object sender, EventArgs e)
        {
            AgendarHorario();
            RemoverHorarioAgendar();
            tbServiçoAgendar.Clear();
        }
        public void AgendarHorario()
        {
            if (tbDiaAgendar.Text == "")
            {
                MessageBox.Show("Preencha o dia que deseja agendar!");
            }
            else if (tbHorarioAgendar.Text == "")
            {
                MessageBox.Show("Preencha o horario que deseja agendar!");
            }
            else if (tbServiçoAgendar.Text == "")
            {
                MessageBox.Show("Preencha o serviço que você deseja agendar!");
            }
            else
            {

                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
                SqlCommand sql = new SqlCommand();
                sql.Connection = conexao;
                sql.CommandText = "INSERT INTO HoráriosAgendados (Cliente,Dia,Horas,Serviço,Barbearia) VALUES (@cliente,@dia,@horas,@serviço,@barbearia)";

                sql.Parameters.AddWithValue("@cliente", "Henzo");
                sql.Parameters.AddWithValue("@dia", tbDiaAgendar.Text);
                sql.Parameters.AddWithValue("@horas", tbHorarioAgendar.Text);
                sql.Parameters.AddWithValue("@serviço", tbServiçoAgendar.Text);
                sql.Parameters.AddWithValue("@barbearia", "Barbearia 3");


                conexao.Open();
                int i = sql.ExecuteNonQuery();
                conexao.Close();
                if (i > 0)
                {
                    MessageBox.Show($"Seu serviço de {tbServiçoAgendar.Text} foi agendado no dia {tbDiaAgendar.Text}");
                    new MostrarAgendamentos().Show();
                }
                else
                {
                    MessageBox.Show("ERRO!");
                    tbDiaAgendar.Clear();
                    tbHorarioAgendar.Clear();
                    tbServiçoAgendar.Clear();
                }



                AtualizarHorarioAgendar();
                AtualizarServiçosAgendar();
            }
        }
        public void RemoverHorarioAgendar()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText = "DELETE FROM Horários WHERE Dia = '" + tbDiaAgendar.Text + " ' AND Horas = '" + tbHorarioAgendar.Text + "'";
                sql.ExecuteNonQuery();
                AtualizarHorarioAgendar();



                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
               
                tbDiaAgendar.Clear();
                tbHorarioAgendar.Clear();
                conexao.Close();
            }
        }
    }
    }

