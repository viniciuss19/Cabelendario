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
    }
}
