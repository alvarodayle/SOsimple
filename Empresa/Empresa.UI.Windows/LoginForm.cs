﻿using Empresa.UI.Windows.LoginControle;
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

        private void resetSenha_Click(object sender, EventArgs e)
        {
            ResetSenhaForm cad = new ResetSenhaForm();
            cad.autPreenchimento(loginTextBox.Text.ToString());
            cad.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (loginTextBox.Text == "" || senhaTextBox.Text == "")
            {
                mensagemErroLabel.Text = "Insira as Credênciais de Login";
            }
            else
            {

                Controle controle = new Controle();
                controle.Acessar(loginTextBox.Text, senhaTextBox.Text);
                controle.Alcada(loginTextBox.Text, senhaTextBox.Text);

                if (controle.mensagem.Equals(""))
                {
                    if (controle.tem)
                    {
                        principalForm telaPrincipal = new principalForm();
                        telaPrincipal.acesso(controle.departamento);
                        telaPrincipal.guardanome(controle.nomeFuncionario);
                        telaPrincipal.Show();
                        Hide();
                    }
                    else
                    {
                        senhaTextBox.Clear();

                        ResetSenhaForm cad = new ResetSenhaForm();
                        cad.autPreenchimento(loginTextBox.Text.ToString());
                        cad.ShowDialog();
                    }
                }
                else
                {
                    mensagemErroLabel.Text = controle.mensagem;
                }
            }
        }
    }
}
