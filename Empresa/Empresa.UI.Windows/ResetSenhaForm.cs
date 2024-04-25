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
    public partial class ResetSenhaForm : Form
    {
        public ResetSenhaForm()
        {
            InitializeComponent();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void autPreenchimento (String loginFunc)
        {
            loginResetTextBox.Text = loginFunc;
        }

        private void confirmarCadastroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginResetLabel.Text))
            {
                erroCadastroLabel.Text = "Campo Login é de preenchimento obrigatório";
            }

            if (string.IsNullOrEmpty(senhaAtualTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Senha Atual é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(novaSenhaTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Nova Senha é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(confirmarSenhaTextBox.Text))
            {
                erroCadastroLabel.Text = "Campo Confirmar Senha é de preenchimento obrigatório";
            }
            else
            {

                Controle controle = new Controle();
                string mensagem = controle.resetSenha(loginResetTextBox.Text.ToUpper(),senhaAtualTextBox.Text, novaSenhaTextBox.Text, confirmarSenhaTextBox.Text);
                if (controle.tem)
                {
                    MessageBox.Show(mensagem, "Alteração de Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    erroCadastroLabel.Text = "";
                    loginResetTextBox.Clear();
                    senhaAtualTextBox.Clear();
                    confirmarSenhaTextBox.Clear();
                    novaSenhaTextBox.Clear();
                }
                else
                {
                    erroCadastroLabel.Text = mensagem;
                }
            }
        }
    }
}
