using Empresa.UI.Windows.LoginAcesso;
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
using Microsoft.SqlServer.Server;
using System.Security.Cryptography.X509Certificates;

namespace Empresa.UI.Windows
{
    public partial class principalForm : Form
    {

        public principalForm()
        {
            InitializeComponent();

        }

        public String boasvindas;

        public void guardanome(String nomeFuncionario)
        {
            boasvindas = nomeFuncionario;
            boasVindasLabel.Text = ($"Boas Vindas {boasvindas}");
        }

        public String direitoAcesso;

        public void acesso(String departamento)
        {
            direitoAcesso = departamento;

            if (direitoAcesso != "SUPERVISOR" || direitoAcesso != "GERENTE" || direitoAcesso != "DIRETOR")
            {
                funcionáriosToolStripMenuItem.Visible = false;
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var f = new ClientesForm();
            f.guardanome(boasvindas);
            f.acesso(direitoAcesso);
            f.ShowDialog();
            
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hide();
            var f = new ProdutoForm();
            f.guardanome(boasvindas);
            f.acesso(direitoAcesso);
            f.ShowDialog();
            
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var f = new FuncionarioForm();
            f.guardanome(boasvindas);
            f.acesso(direitoAcesso);
            f.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            var lf = new LoginForm();
            lf.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
