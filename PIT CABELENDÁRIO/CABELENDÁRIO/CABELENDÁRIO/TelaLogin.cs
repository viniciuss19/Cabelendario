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

           
                if (txtUsername.Text == "usuario" && txtPassword.Text == "123")
                {
                    new Menu().Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("O nome de usuário ou senha está incorreto,tente novamente.");
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
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
    }
}
