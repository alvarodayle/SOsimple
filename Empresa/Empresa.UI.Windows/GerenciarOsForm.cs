using Empresa.Db;
using Empresa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
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
            ExibirGrid();
            osDataGridView.AllowUserToAddRows = false;
        }

        private void ExibirTela()
        {

            buscarOsTabControl.Visible = true;
            buscarOsTabControl.TabPages.Remove(tabOrdemDeServico);

            filtroComboBox.Items.AddRange(new string[] { "OS" });

            novaOsButton.Visible = true;
            alterarOsButton.Visible = true;
            sairButton.Visible = true;
            gravarButton.Visible = false;
            confAlterarButton.Visible = false;
            voltarButton.Visible = false;
        }

        private void ExibirGrid()
        {
            osDataGridView.Visible = true;

            var db = new OsDb();
            osDataGridView.DataSource = db.Listar();
            osDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            osDataGridView.ReadOnly = true;
            osDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            osDataGridView.RowHeadersVisible = false;
            osDataGridView.EnableHeadersVisualStyles = false;

            osDataGridView.Columns[0].Width = 50;
            osDataGridView.Columns[1].Width = 30;
            osDataGridView.Columns[2].Width = 30;

            osDataGridView.Columns[0].Name = "OS";
            osDataGridView.Columns[1].Name = "ID Cliente";
            osDataGridView.Columns[2].Name = "ID Produto";
            osDataGridView.Columns[3].Name = "Aparência";
            osDataGridView.Columns[4].Name = "Número de Série";
            osDataGridView.Columns[5].Name = "Descrição do Defeito";
            osDataGridView.Columns[6].Name = "Status OS";



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
            nomeTextBox.ReadOnly = true;
            telefoneTextBox.ReadOnly = true;
            cepTextBox.ReadOnly = true;
            enderecoTextBox.ReadOnly = true;
            numeroTextBox.ReadOnly = true;
            cidadeTextBox.ReadOnly = true;
            ufTextBox.ReadOnly = true;
            numeroSerialTextBox.ReadOnly = true;

            nomeTextBox.BackColor = SystemColors.InactiveCaption;
            telefoneTextBox.BackColor = SystemColors.InactiveCaption;
            cepTextBox.BackColor = SystemColors.InactiveCaption;
            enderecoTextBox.BackColor = SystemColors.InactiveCaption;
            numeroTextBox.BackColor = SystemColors.InactiveCaption;
            cidadeTextBox.BackColor = SystemColors.InactiveCaption;
            ufTextBox.BackColor = SystemColors.InactiveCaption;
            numeroSerialTextBox.BackColor = SystemColors.InactiveCaption;

            buscarOsTabControl.SelectedTab = tabOrdemDeServico;
            buscarOsTabControl.TabPages.Remove(tabBuscar);
            buscarOsTabControl.TabPages.Add(tabOrdemDeServico);

            statusComboBox.Text = "Cadastrando Ordem de Serviço";
            statusComboBox.Enabled = false;

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

                    nomeTextBox.BackColor = SystemColors.InactiveCaption;
                    telefoneTextBox.BackColor = SystemColors.InactiveCaption;
                    cepTextBox.BackColor = SystemColors.InactiveCaption;
                    enderecoTextBox.BackColor = SystemColors.InactiveCaption;
                    numeroTextBox.BackColor = SystemColors.InactiveCaption;
                    cidadeTextBox.BackColor = SystemColors.InactiveCaption;
                    ufTextBox.BackColor = SystemColors.InactiveCaption;
                    numeroSerialTextBox.BackColor = SystemColors.InactiveCaption;

                    nomeTextBox.ReadOnly = true;
                    cpfTextBox.ReadOnly = true;
                    telefoneTextBox.ReadOnly = true;
                    cepTextBox.ReadOnly = true;
                    enderecoTextBox.ReadOnly = true;
                    numeroTextBox.ReadOnly = true;
                    cidadeTextBox.ReadOnly = true;
                    ufTextBox.ReadOnly = true;
                    numeroSerialTextBox.ReadOnly = false;
                    numeroSerialTextBox.BackColor = SystemColors.Window;

                }
                else
                {

                    nomeTextBox.BackColor = SystemColors.Window;
                    telefoneTextBox.BackColor = SystemColors.Window;
                    cepTextBox.BackColor = SystemColors.Window;
                    enderecoTextBox.BackColor = SystemColors.Window;
                    numeroTextBox.BackColor = SystemColors.Window;
                    cidadeTextBox.BackColor = SystemColors.Window;
                    ufTextBox.BackColor = SystemColors.Window;
                    numeroSerialTextBox.BackColor = SystemColors.Window;

                    nomeTextBox.ReadOnly = false;
                    telefoneTextBox.ReadOnly = false;
                    cepTextBox.ReadOnly = false;
                    enderecoTextBox.ReadOnly = false;
                    numeroTextBox.ReadOnly = false;
                    cidadeTextBox.ReadOnly = false;
                    ufTextBox.ReadOnly = false;
                    numeroSerialTextBox.ReadOnly = false;
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

            statusComboBox.Enabled = true;
            statusComboBox.Items.AddRange(new string[] { "Cadastrando Ordem de Serviço", "Aguardando Peças", "Em Manutenção",
            "Ordem de Serviço Finalizada"});

            marcaComboBox.Text = null;
            tipoComboBox.Text = null;
            modeloComboBox.Text = null;

            marcaComboBox.Items.Clear();
            tipoComboBox.Items.Clear();
            modeloComboBox.Items.Clear();


            //ExibirTela();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            LimparCampos();

            IdClienteArmazenado = 0;
            IdProdutoArmazenado = 0;

            buscarOsTabControl.TabPages.Add(tabBuscar);
            ExibirTela();
            cpfTextBox.ReadOnly = false;
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (cpfTextBox.Text == null || cpfTextBox.Text.Length != 11) 
            {

                MessageBox.Show("Necessário digitar CPF");

            }
            else
            {
                OsDb os = new OsDb();
                os.Incluir(IdClienteArmazenado, IdProdutoArmazenado, aparenciaTextBox.Text, numeroSerialTextBox.Text, descDefeitoTextBox.Text, statusComboBox.Text);

                LimparCampos();

                IdClienteArmazenado = 0;
                IdProdutoArmazenado = 0;

                buscarOsTabControl.TabPages.Add(tabBuscar);
                ExibirTela();
                cpfTextBox.ReadOnly = false;

            }

        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            string textBoxText = filtroTextBox.Text;

            if (!string.IsNullOrEmpty(textBoxText))
            {
                // Verifica se o item existe em pelo menos um dos dois campos no banco de dados
                string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SoSimple;Integrated Security=True;Encrypt=False;";
                string query = "SELECT * FROM TORDE WHERE OS = @value";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@value", textBoxText);

                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Exibe os resultados no DataGridView
                            osDataGridView.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado encontrado no banco de dados.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um dado no filtro.");
            }
        }
    }
}
