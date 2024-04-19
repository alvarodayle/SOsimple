using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class ClienteIncluirForm : Form
    {
        public ClienteIncluirForm()
        {
            InitializeComponent();
        }
        private void sairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
