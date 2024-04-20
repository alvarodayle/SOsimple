using Empresa.UI.Windows.LoginControle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            CadastroUsuarioForm cad = new CadastroUsuarioForm();
            cad.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(loginTextBox.Text, senhaTextBox.Text);
            if (controle.mensagem.Equals(""))
            { 
                if (controle.tem)
                {
                    principalForm telaPrincipal = new principalForm();
                    telaPrincipal.Show();
                    Hide();
                }
                else
                {
                    if(loginTextBox.Text == "" || senhaTextBox.Text == "")
                    {
                        mensagemErroLabel.Text = "Insira as Credênciais de Login";
                    }
                    else
                    {
                        mensagemErroLabel.Text = "Login ou Senha Incorretos";
                    }
                }
            }else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
