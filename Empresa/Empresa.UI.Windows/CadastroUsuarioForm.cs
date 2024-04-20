using Empresa.UI.Windows.LoginControle;
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
    public partial class CadastroUsuarioForm : Form
    {
        public CadastroUsuarioForm()
        {
            InitializeComponent();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmarCadastroButton_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.Cadastrar(nomeCadastroTextBox.Text, loginTextBox.Text, senhaTextBox.Text, deptTextBox.Text, confirSenhaTextBox.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
