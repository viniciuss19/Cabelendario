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

    
    public partial class TelaLogin : Form
    {
        private List<Cliente> LoginsArmazenado;

        public TelaLogin()
        {
           
            InitializeComponent();


           
        }
        public static string UserCliente = "";
        public static string UserBarbearia = "";
        public static string NomeBarbearia = "";
        public static string EndereçoBarbearia = "";
        

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogarUser();
          
           
              
            
                
        }
        public void LogarUser()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            sql.CommandText = $"SELECT * From Clientes WHERE UserCliente = '{txtUsername.Text}' AND SenhaCliente = '{txtPassword.Text}'";
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
            DataTable tabela = new DataTable();

            string querybarbearia = $"SELECT * FROM Barbearias WHERE UserDonoBarbearia = '{txtUsername.Text}' AND CPFDonoBarbearia = '{txtPassword.Text}'";
            SqlDataAdapter adaptador2 = new SqlDataAdapter(querybarbearia, conexao);
            DataTable tabela2 = new DataTable();

            adaptador.Fill(tabela);
            adaptador2.Fill(tabela2);

            if(tabela.Rows.Count == 1)
            {
                UserCliente = txtUsername.Text;





                new MenuCliente().Show();
                this.Hide();
                txtPassword.Clear();
                txtUsername.Clear();
            }
           
          else  if(tabela2.Rows.Count == 1)
            
            {
                
                UserBarbearia = txtUsername.Text;
                SqlCommand sql2 = new SqlCommand($"SELECT NomeBarbearia FROM Barbearias WHERE UserDonoBarbearia = '{UserBarbearia}'");
                SqlCommand sql3 = new SqlCommand($"SELECT EndereçoBarbearia FROM Barbearias WHERE UserDonoBarbearia = '{UserBarbearia}'");
                sql2.Connection = conexao;
                sql3.Connection = conexao;
                conexao.Open();
                EndereçoBarbearia = Convert.ToString(sql3.ExecuteScalar());
                NomeBarbearia = Convert.ToString(sql2.ExecuteScalar());
                conexao.Close();
                


               new MenuBarbeariaGerenciar().Show();
                this.Hide();
                txtPassword.Clear();
                txtUsername.Clear();
            }
            else
            {
                MessageBox.Show("USUÁRIO INVÁLIDO!");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        public void LogarBarbearia()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-V3GENC1;Initial Catalog=BancoPIT;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;

            sql.CommandText = $"SELECT * From Barbearias WHERE UserDonoBarbearia = '{txtUsername.Text}' AND CPFDonoBarbearia = '{txtPassword.Text}'";
            SqlDataAdapter adaptador = new SqlDataAdapter(sql.CommandText, conexao);
            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);

            if (tabela.Rows.Count == 1)
            {
                new MenuBarbeariaGerenciar().Show();
                this.Hide();
                txtPassword.Clear();
                txtUsername.Clear();
            }
            else
            {
                MessageBox.Show("Este login não foi encontrado!");
            }
        }
    }
}
