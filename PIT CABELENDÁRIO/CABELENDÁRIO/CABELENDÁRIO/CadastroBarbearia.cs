﻿using System;
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
    public partial class CadastroBarbearia : Form
    {
        static List<Barbearia> barbearias = new List<Barbearia>();
        public CadastroBarbearia()
        {
            InitializeComponent();
        }

        private void CadastroBarbearia_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Cadastro().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = -1;

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-SO3COJV;Initial Catalog=Cabelendário;Integrated Security=True";
            SqlCommand sql = new SqlCommand();
            sql.Connection = conexao;
            sql.CommandText = "INSERT INTO Barbearias (NomeBarbearia,EndereçoBarbearia,UserDonoBarbearia,CPFDonoBarbearia) VALUES (@nomebarbearia,@endereçobarbearia,@userdonobarbearia,@cpfdonobarbearia)";
            sql.Parameters.AddWithValue("@nomebarbearia", txtNomeBarbearia.Text);
            sql.Parameters.AddWithValue("@endereçobarbearia", txtEndereçoBarbearia.Text);
            sql.Parameters.AddWithValue("@userdonobarbearia", txtNomeDonoBarbearia.Text);
            sql.Parameters.AddWithValue("@cpfdonobarbearia", txtCpfDonoBarbearia.Text);

            conexao.Open();
            int i = sql.ExecuteNonQuery();
            conexao.Close();
            if (i > 0)
            {
                MessageBox.Show($"A barbearia {txtNomeBarbearia.Text} foi realizado com sucesso!");
            }
            else MessageBox.Show($"Erro ao cadastrar");


            if (txtNomeBarbearia.Text == "")
            {
                MessageBox.Show("Digite o nome da sua barbearia!");
                txtNomeBarbearia.Focus();
            }
            else if (txtEndereçoBarbearia.Text == "")
            {
                MessageBox.Show("Digite o endereço da sau barbearia");
                txtEndereçoBarbearia.Focus();
            }
            else if (txtNomeDonoBarbearia.Text == "")
            {
                MessageBox.Show("Digite o nome do dono da barbearia");
                txtNomeDonoBarbearia.Focus();
            }
            else if (txtCpfDonoBarbearia.Text == "")
            {
                MessageBox.Show("Digite o CPF do dono da barbearia");
                txtCpfDonoBarbearia.Focus();
            }
            else
            {
                new TelaLogin().Show();
                this.Hide();
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
