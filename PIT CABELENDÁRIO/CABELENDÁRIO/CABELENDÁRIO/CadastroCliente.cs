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
    public partial class CadastroCliente : Form
    {

       static List<Cliente> clientes = new List<Cliente>();

        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CadastrarCliente();




            

          
           




            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Preencha o nome");
                txtNomeCliente.Focus();
            }

            else if (txtSenhaCliente.Text == "")
            {
                MessageBox.Show("Preencha a senha");
                txtSenhaCliente.Focus();
            }

            else if (txtCpfCliente.Text == "")
            {
                MessageBox.Show("Preencha o cpf");
                txtCpfCliente.Focus();
                return;
            }
            else
            {
                new TelaLogin().Show();
                this.Hide();
            }


            

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void CadastrarCliente()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = "INSERT INTO Clientes (UserCliente,SenhaCliente,CPFCliente) VALUES (@usercliente,@senhacliente,@cpfcliente)";
            sql.Parameters.AddWithValue("@usercliente", txtNomeCliente.Text);
            sql.Parameters.AddWithValue("@senhacliente", txtSenhaCliente.Text);
            sql.Parameters.AddWithValue("@cpfcliente", txtCpfCliente.Text);

            conexao.Open();
            int i = sql.ExecuteNonQuery();
            conexao.Close();
            if (i > 0)
            {
                MessageBox.Show($"O cadastro do cliente {txtNomeCliente.Text} foi realizado com sucesso!");
            }
            else MessageBox.Show($"Erro ao cadastrar");
        }
    }
    
}


