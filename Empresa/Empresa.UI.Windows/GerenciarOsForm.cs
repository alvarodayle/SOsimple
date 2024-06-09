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
        }

        private void GerenciarOsForm_Load_1(object sender, EventArgs e)
        {
            ExibirTela();
        }

        private void ExibirTela()
        {

            buscarOsTabControl.Visible = true;
            buscarOsTabControl.TabPages.Remove(tabOrdemDeServico);
            

            novaOsButton.Visible = true;
            alterarOsButton.Visible = true;
            sairButton.Visible = true;
            gravarButton.Visible = false;
            confAlterarButton.Visible = false;
            voltarButton.Visible = false;
        }

        private void DesabilitarBotoes()
        {
            novaOsButton.Visible = false;
            alterarOsButton.Visible = false;
            sairButton.Visible = false;
            gravarButton.Visible = false;
            confAlterarButton.Visible = false;
            voltarButton.Visible = false;
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();

            var pf = new principalForm();
            pf.Show();
        }

        private void novaOsButton_Click(object sender, EventArgs e)
        {
            DesabilitarBotoes();
            gravarButton.Visible = true;
            voltarButton.Visible = true;

            buscarOsTabControl.SelectedTab = tabOrdemDeServico;
            buscarOsTabControl.TabPages.Remove(tabBuscar);
            buscarOsTabControl.TabPages.Add(tabOrdemDeServico);



            //ExibirTela();
        }

        private void alterarOsButton_Click(object sender, EventArgs e)
        {
            DesabilitarBotoes();
            confAlterarButton.Visible = true;
            voltarButton.Visible = true;

            buscarOsTabControl.SelectedTab = tabOrdemDeServico;
            buscarOsTabControl.TabPages.Remove(tabBuscar);
            buscarOsTabControl.TabPages.Add(tabOrdemDeServico);


            //Configurar o autopreenchimento dos campos

            //ExibirTela();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            buscarOsTabControl.TabPages.Add(tabBuscar);
            ExibirTela();
        }
    }
}
