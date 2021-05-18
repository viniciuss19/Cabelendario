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
    public partial class MenuBarbeariaGerenciar : Form
    {
        public MenuBarbeariaGerenciar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdicionarHorariosGB_Click(object sender, EventArgs e)
        {
            AdicionarHorario();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AtualizarHorários();
        }

        private void AtualizarHorários()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            sql.CommandText = "Select * FROM Horários";
            try
            {
                conexao.Open();
                int i = sql.ExecuteNonQuery();
               
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
                DataTable tabela = new DataTable();
                adaptador.Fill(tabela);
                dgvHorarios.DataSource = tabela;
                dgvHorarios.ClearSelection();
                conexao.Close();
            }
        }

        public void AdicionarHorario()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
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
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                AtualizarHorários();
                MessageBox.Show($"O horário {tbDias.Text} {tbHoras.Text} foi adicionado com sucesso");
                conexao.Close();
            }
            tbDias.Text = "";
            tbHoras.Text = "";
        }

        private void buttonAdicionarServiçosGB_Click(object sender, EventArgs e)
        {
            AdicionarServiços();
        }
        public void AdicionarServiços()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText = "INSERT INTO Serviços(Serviço,Preço) VALUES (@serviço,@preço)";
                sql.Parameters.AddWithValue("@serviço", tbServiços.Text);
                sql.Parameters.AddWithValue("@preço", tbPreçoServiço.Text);
                int i = sql.ExecuteNonQuery();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                AtualizarServiços();
                MessageBox.Show($"O Serviço {tbServiços.Text} foi adicionado com sucesso");
                conexao.Close();
            }
            tbServiços.Text = "";
            tbPreçoServiço.Text = "";
        }
        public void AtualizarServiços()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
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
            AtualizarServiços();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarHorários();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RemoverHorarios();
        }
        public void RemoverHorarios()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText = "DELETE FROM Horários WHERE dia = '" + tbDias.Text + " ' AND horas = '"+tbHoras.Text+"'";
                sql.ExecuteNonQuery();
                AtualizarHorários();
               

               
                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                MessageBox.Show($"A data {tbDias.Text} {tbHoras.Text} foi removida com sucesso");
                tbDias.Clear();
                tbHoras.Clear();
                conexao.Close();
            }
        }

        private void MenuBarbeariaGerenciar_Load(object sender, EventArgs e)
        {
            AtualizarHorários();
            AtualizarServiços();
        }
        public void RemoverServiços()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            try
            {
                conexao.Open();
                sql.CommandText = "DELETE FROM Serviços WHERE Serviço = '" + tbServiços.Text + " ' ";
                sql.ExecuteNonQuery();
                AtualizarServiços();



                int i = sql.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                MessageBox.Show($"O Serviço {tbServiços.Text} foi removido com sucesso");
                tbServiços.Clear();
                tbPreçoServiço.Clear();
                conexao.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoverServiços();
        }
        
    }
}

