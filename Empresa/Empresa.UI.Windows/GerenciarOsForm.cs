using Empresa.Db;
using Empresa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void LimparCampos()
        {
            osTextBox.Clear();
            statusComboBox.Items.Clear();
            cpfTextBox.Clear();
            nomeTextBox.Clear();
            telefoneTextBox.Clear();
            cidadeTextBox.Clear();
            ufTextBox.Clear();
            cidadeTextBox.Clear();
            enderecoTextBox.Clear();
            numeroSerialTextBox.Clear();
            aparenciaTextBox.Clear();
            descDefeitoTextBox.Clear();
            quantidadeTextBox.Clear();
            tipoComboBox.Items.Clear();
            marcaComboBox.Items.Clear();
            modeloComboBox.Items.Clear();
            cepTextBox.Clear();
            numeroTextBox.Clear();
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

        public int IdClienteArmazenado;

        private void novaOsButton_Click(object sender, EventArgs e)
        {

            DesabilitarBotoes();
            gravarButton.Visible = true;
            voltarButton.Visible = true;
            osTextBox.ReadOnly = true;

            buscarOsTabControl.SelectedTab = tabOrdemDeServico;
            buscarOsTabControl.TabPages.Remove(tabBuscar);
            buscarOsTabControl.TabPages.Add(tabOrdemDeServico);

            statusComboBox.Text = "Cadastrando uma OS";

            marcaComboBox.Text = null;
            tipoComboBox.Text = null;
            modeloComboBox.Text = null;

            marcaComboBox.Items.Clear();
            tipoComboBox.Items.Clear();
            modeloComboBox.Items.Clear();

            tipoComboBox.Enabled = false;
            modeloComboBox.Enabled = false;

            var cb = new PecaDb();
            List<string> listaMarca = cb.MarcaComboBox();

            marcaComboBox.Items.AddRange(listaMarca.ToArray());
        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoComboBox.Items.Clear();

            tipoComboBox.Text = null;
            modeloComboBox.Text = null;

            var cb = new PecaDb();

            tipoComboBox.Enabled = true;

            List<string> listaTipo = cb.TipoComboBox(marcaComboBox.Text);

            tipoComboBox.Items.AddRange(listaTipo.ToArray());
        }

        private void tipoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            modeloComboBox.Items.Clear();
            modeloComboBox.Text = null;

            var cb = new PecaDb();

            modeloComboBox.Enabled = true;

            List<string> listaModelo = cb.ModeloComboBox(marcaComboBox.Text, tipoComboBox.Text);

            modeloComboBox.Items.AddRange(listaModelo.ToArray());
        }

        public int IdProdutoArmazenado;

        private void modeloComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoDb pd = new ProdutoDb();
            IdProdutoArmazenado = pd.ProcurarID(tipoComboBox.Text, marcaComboBox.Text, modeloComboBox.Text);
        }

        private void cpfTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cpfTextBox.Text.Length == 11)
            {
                OsDb cd = new OsDb();
  
                ClienteGerenciamentoDeOS cliente = cd.ProcurarCliente(cpfTextBox.Text);

                if (cliente != null)
                {

                    IdClienteArmazenado = cliente.IdCliente;
                    nomeTextBox.Text = cliente.nomeCliente;
                    cpfTextBox.Text = cliente.cpfCliente;
                    telefoneTextBox.Text = cliente.telCliente;
                    cepTextBox.Text = cliente.cepCliente;
                    enderecoTextBox.Text = cliente.endCliente;
                    numeroTextBox.Text = cliente.numEndCliente;
                    cidadeTextBox.Text = cliente.cidCliente;
                    ufTextBox.Text = cliente.ufCliente;

                    nomeTextBox.ReadOnly = true;
                    cpfTextBox.ReadOnly = true;
                    telefoneTextBox.ReadOnly = true;
                    enderecoTextBox.ReadOnly = true;
                    numeroTextBox.ReadOnly = true;
                    cidadeTextBox.ReadOnly = true;
                    ufTextBox.ReadOnly = true;
                }
                
            }
        }

        private void alterarOsButton_Click(object sender, EventArgs e)
        {
            DesabilitarBotoes();
            confAlterarButton.Visible = true;
            voltarButton.Visible = true;

            buscarOsTabControl.SelectedTab = tabOrdemDeServico;
            buscarOsTabControl.TabPages.Remove(tabBuscar);
            buscarOsTabControl.TabPages.Add(tabOrdemDeServico);


            statusComboBox.Items.AddRange(new string[] { "Cadastrando Ordem de Serviço", "Aguardando Peças", "Em Manutenção",
            "Ordem de Serviço Finalizada"});


            //Configurar o autopreenchimento dos campos

            //ExibirTela();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            LimparCampos();

            IdClienteArmazenado = 0;
            IdProdutoArmazenado = 0;

            buscarOsTabControl.TabPages.Add(tabBuscar);
            ExibirTela();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            OsDb os = new OsDb();
            os.Incluir(IdClienteArmazenado, IdProdutoArmazenado, aparenciaTextBox.Text, numeroSerialTextBox.Text, descDefeitoTextBox.Text, statusComboBox.Text);

            LimparCampos();

            IdClienteArmazenado = 0;
            IdProdutoArmazenado = 0;

            buscarOsTabControl.TabPages.Add(tabBuscar);
            ExibirTela();

        }
    }
}
