using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CABELENDÁRIO
{
    public partial class CadastroCliente : Form
    {
       List<Cliente> clientes;

        public CadastroCliente()
        {
            InitializeComponent();

            clientes = new List<Cliente>();
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
            int index = -1;

            foreach (Cliente c in clientes)
            {


                Cliente cl = new Cliente();

                cl.Nome = txtNomeCliente.Text;
                cl.Senha = txtSenhaCliente.Text;
                cl.cpf = txtCpfCliente.Text;

                if (c.Nome == txtNomeCliente.Text)
                {
                    index = clientes.IndexOf(c);
                }

                if (index < 0)
                {
                    clientes.Add(cl);
                }
                else
                {
                    clientes[index] = cl;
                }


            }
           

              

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

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
