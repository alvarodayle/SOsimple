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
            produtoPecaTabControl.TabPages.Remove(tabPecas);

            filtroComboBox.Items.Clear();
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

            osDataGridView.Columns[0].HeaderText = "OS";
            osDataGridView.Columns[1].HeaderText = "ID Cliente";
            osDataGridView.Columns[2].HeaderText = "ID Produto";
            osDataGridView.Columns[3].HeaderText = "Aparência";
            osDataGridView.Columns[4].HeaderText = "Número de Série";
            osDataGridView.Columns[5].HeaderText = "Descrição do Defeito";
            osDataGridView.Columns[6].HeaderText= "Status OS";



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
            produtoPecaTabControl.TabPages.Remove(tabPecas);
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
            numeroSerialTextBox.ReadOnly = false;

            nomeTextBox.BackColor = SystemColors.InactiveCaption;
            telefoneTextBox.BackColor = SystemColors.InactiveCaption;
            cepTextBox.BackColor = SystemColors.InactiveCaption;
            enderecoTextBox.BackColor = SystemColors.InactiveCaption;
            numeroTextBox.BackColor = SystemColors.InactiveCaption;
            cidadeTextBox.BackColor = SystemColors.InactiveCaption;
            ufTextBox.BackColor = SystemColors.InactiveCaption;

            buscarOsTabControl.SelectedTab = tabOrdemDeServico;
            buscarOsTabControl.TabPages.Remove(tabBuscar);
            buscarOsTabControl.TabPages.Add(tabOrdemDeServico);

            statusComboBox.Text = "Cadastrando Uma OS";
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

                string cpfText = cpfTextBox.Text;

                if (!string.IsNullOrEmpty(cpfText))
                {
                    // Verifica se o item existe em pelo menos um dos dois campos no banco de dados
                    string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SoSimple;Integrated Security=True;Encrypt=False;";
                    string query = "SELECT * FROM TCLIE WHERE cpfCliente = @value";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@value", cpfText);

                        try
                        {
                            connection.Open();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                OsDb cd = new OsDb();

                                ClienteGerenciamentoDeOS cliente = cd.ProcurarCliente(cpfTextBox.Text);

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

                                connection.Close();
                            }
                            else
                            {
                                MessageBox.Show("Cpf não encontrado no banco de dados.");
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
                    MessageBox.Show("Por favor, insira um Cpf no filtro.");
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
            statusComboBox.Items.AddRange(new string[] { "Cadastrando Uma OS", "Aguardando Peças", "Em Manutenção",
            "Manutenção Finalizada"});

            marcaComboBox.Text = null;
            tipoComboBox.Text = null;
            modeloComboBox.Text = null;

            marcaComboBox.Items.Clear();
            tipoComboBox.Items.Clear();
            modeloComboBox.Items.Clear();

            marcaComboBox.Enabled = false;
            tipoComboBox.Enabled = false;
            modeloComboBox.Enabled = false;

            if (osDataGridView.SelectedRows.Count > 0)
            {
                var osSelecionada = osDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                var idClienteOSSelecionado = osDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                var idProdutoOSSelecionado = osDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                var aparenciaProdSelecionado = osDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                var numSerieSelecionado = osDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                var descDefeitoSelecionado = osDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                var statusOSSelecionado = osDataGridView.SelectedRows[0].Cells[6].Value.ToString();

                osTextBox.Text = osSelecionada;
                osTextBox.ReadOnly = true;

                IdClienteArmazenado = Convert.ToInt32(idClienteOSSelecionado);

                IdProdutoArmazenado = Convert.ToInt32(idProdutoOSSelecionado);

                numeroSerialTextBox.Text = numSerieSelecionado;
                numeroSerialTextBox.ReadOnly = true;

                aparenciaTextBox.Text = aparenciaProdSelecionado;
                aparenciaTextBox.ReadOnly = true;

                descDefeitoTextBox.Text = descDefeitoSelecionado;
                descDefeitoTextBox.ReadOnly = true;

                statusComboBox.Text = statusOSSelecionado;

                cpfTextBox.BackColor = SystemColors.InactiveCaption;
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
                numeroSerialTextBox.ReadOnly = true;

            }

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {

            LimparCampos();

            IdClienteArmazenado = 0;
            IdProdutoArmazenado = 0;

            buscarOsTabControl.TabPages.Add(tabBuscar);
            ExibirTela();
            ExibirGrid();
            produtoPecaTabControl.TabPages.Remove(tabPecas);

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

        private void confAlterarButton_Click(object sender, EventArgs e)
        {
            var OS = Convert.ToInt32(osTextBox.Text);
            OsDb alterar = new OsDb();
            alterar.Alterar(OS, IdClienteArmazenado, IdProdutoArmazenado, aparenciaTextBox.Text, numeroSerialTextBox.Text, descDefeitoTextBox.Text, statusComboBox.Text);

            LimparCampos();

            IdClienteArmazenado = 0;
            IdProdutoArmazenado = 0;

            buscarOsTabControl.TabPages.Add(tabBuscar);
            ExibirTela();
            cpfTextBox.ReadOnly = false;
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

                            connection.Close();
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
                ExibirGrid();
            }
        }


    }
}
