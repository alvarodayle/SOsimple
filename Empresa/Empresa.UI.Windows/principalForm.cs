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

            if (direitoAcesso != "SUPERVISOR")
            {
                funcionáriosToolStripMenuItem.Visible = false;
            }
        }

        private void gerenciamentoDeOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            Hide();
            var os = new ServiceOrderForm();
            os.guardanome(boasvindas);
            os.acesso(direitoAcesso);
            os.ShowDialog();
            */
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var cli = new ClientesForm();
            cli.guardanome(boasvindas);
            cli.acesso(direitoAcesso);
            cli.ShowDialog();
            
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hide();
            var prd = new ProdutoForm();
            prd.guardanome(boasvindas);
            prd.acesso(direitoAcesso);
            prd.ShowDialog();
            
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var pca = new PecaForm();
            pca.guardanome(boasvindas);
            pca.acesso(direitoAcesso);
            pca.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var fun = new FuncionarioForm();
            fun.guardanome(boasvindas);
            fun.acesso(direitoAcesso);
            fun.ShowDialog();
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
