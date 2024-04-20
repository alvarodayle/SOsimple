using Empresa.UI.Windows.LoginControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (string.IsNullOrEmpty(nomeCadastroTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Nome é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(deptTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Departamento é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Login é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(senhaTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Senha é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(confirSenhaTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Confirmar Senha é de preenchimento obrigatório";
            }

            else if (senhaTextBox.Text != confirSenhaTextBox.Text)
            {
                erroCadastroLabel.Text = "As senhas não coincidem";
            }
            else
            {

                Controle controle = new Controle();
                string mensagem = controle.Cadastrar(nomeCadastroTextBox.Text, loginTextBox.Text, senhaTextBox.Text, deptTextBox.Text, confirSenhaTextBox.Text);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    erroCadastroLabel.Text = "";
                    nomeCadastroTextBox.Clear();
                    loginTextBox.Clear();
                    senhaTextBox.Clear();
                    deptTextBox.Clear();
                    confirSenhaTextBox.Clear();
                }
                else
                {
                    erroCadastroLabel.Text = mensagem;
                }
            }
        }
    }
}
