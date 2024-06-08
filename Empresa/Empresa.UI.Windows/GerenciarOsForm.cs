using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class GerenciarOsForm : Form
    {
        public GerenciarOsForm()
        {
            InitializeComponent();
            confAlterarButtonPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoOsForm novoForm = new NovoOsForm();
            novoForm.ShowDialog();
        }
    }
}
