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
            
            string nome = textBox1.Text;
            string senha = textBox2.Text;
          Cliente c = new Cliente(nome,senha);
            Barbearia.Clientes.Add(c);

        }
    }
}
