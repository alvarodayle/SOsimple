using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Db;

namespace Empresa.UI.Windows
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var f = new ClientesForm();
            f.ShowDialog();
            
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hide();
            var f = new ProdutoForm();
            f.ShowDialog();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
