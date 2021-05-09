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

            foreach (Barbearia b in barbearias)
            {
                Barbearia barb = new Barbearia();

                barb.nomebarbearia = txtNomeBarbearia.Text;
                barb.endereçobarbearia = txtEndereçoBarbearia.Text;
                barb.nomedono = txtNomeDonoBarbearia.Text;
                barb.cpfdono = txtCpfDonoBarbearia.Text;

                if (barb.nomebarbearia == txtNomeBarbearia.Text)
                {
                    index = barbearias.IndexOf(b);
                }
                if (index < 0)
                {
                    barbearias.Add(barb);
                }
                else
                {
                    barbearias[index] = barb;
                }
            }

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
