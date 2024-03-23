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
using Empresa.Models;

namespace Empresa.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;
            novoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            confirmarExclusaoButton.Visible = false;
            confirmarNovoButton.Visible = false;
            voltarButton.Visible = false;

            var db = new ClienteDb();
            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = true;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false;
            
            listaDataGridView.Columns[0].Width = 35;
            listaDataGridView.Columns[1].Width = 200;
            listaDataGridView.Columns[2].Width = 90;
            listaDataGridView.Columns[3].Width = 90;
            listaDataGridView.Columns[4].Width = 60;
            listaDataGridView.Columns[5].Width = 180;
            listaDataGridView.Columns[6].Width = 50;
            listaDataGridView.Columns[8].Width = 50;

            listaDataGridView.Columns[0].HeaderText = "ID";
            listaDataGridView.Columns[1].HeaderText = "Nome";
            listaDataGridView.Columns[2].HeaderText = "CPF";
            listaDataGridView.Columns[3].HeaderText = "Telefone";
            listaDataGridView.Columns[4].HeaderText = "CEP";
            listaDataGridView.Columns[5].HeaderText = "Endereço";
            listaDataGridView.Columns[6].HeaderText = "Número";
            listaDataGridView.Columns[7].HeaderText = "Cidade";
            listaDataGridView.Columns[8].HeaderText = "UF";
        }
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void ExibirFicha()
        {
            fichaPanel.Visible = true;
            fichaPanel.Dock = DockStyle.Fill;
            listaDataGridView.Visible = false;
            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarExclusaoButton.Visible = false;
            confirmarNovoButton.Visible = true;
            voltarButton.Visible = true;

        }
        private void novoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();
            confirmarAlterarButton.Visible = false;
            confirmarExclusaoButton.Visible = false;
            confirmarNovoButton.Visible = true;

            LimparFicha();

        }
        private void LimparFicha()
        {
            nomeTextBox.Clear();
            cpfTextBox.Clear();
            telefoneTextBox.Clear();
            cepTextBox.Clear();
            enderecoTextBox.Clear();
            numeroTextBox.Clear();
            cidadeTextBox.Clear();
            ufTextBox.Clear();

        }
        private void voltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void confirmarNovoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.nomeCliente = nomeTextBox.Text;
            cliente.cpfCliente = cpfTextBox.Text;
            cliente.telCliente = telefoneTextBox.Text;
            cliente.cepCliente = cepTextBox.Text;
            cliente.endCliente = enderecoTextBox.Text;
            cliente.numEndCliente = numeroTextBox.Text;
            cliente.cidCliente = cidadeTextBox.Text;
            cliente.ufCliente = ufTextBox.Text;

            var db = new ClienteDb();
            db.Incluir(cliente);

            ExibirGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;
            idTextBox.Text = cliente.IdCliente.ToString();
            nomeTextBox.Text = cliente.nomeCliente;
            cpfTextBox.Text = cliente.cpfCliente;
            telefoneTextBox.Text = cliente.telCliente;
            cepTextBox.Text = cliente.cepCliente;
            enderecoTextBox.Text = cliente.endCliente;
            numeroTextBox.Text = cliente.numEndCliente;
            cidadeTextBox.Text = cliente.cidCliente;
            ufTextBox.Text = cliente.ufCliente;
            ExibirFicha();
            confirmarAlterarButton.Visible = true;
            confirmarExclusaoButton.Visible = false;
            confirmarNovoButton.Visible = false;

        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.IdCliente = Convert.ToInt32(idTextBox.Text);
            cliente.nomeCliente = nomeTextBox.Text;
            cliente.cpfCliente = cpfTextBox.Text;
            cliente.telCliente = telefoneTextBox.Text;
            cliente.cepCliente = cepTextBox.Text;
            cliente.endCliente = enderecoTextBox.Text;
            cliente.numEndCliente = numeroTextBox.Text;
            cliente.cidCliente = cidadeTextBox.Text;
            cliente.ufCliente = ufTextBox.Text;

            var db = new ClienteDb();
            db.Alterar(cliente);

            ExibirGrid();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;

            nomeTextBox.ReadOnly = true;
            cpfTextBox.ReadOnly = true;
            telefoneTextBox.ReadOnly = true;
            cepTextBox.ReadOnly = true;
            enderecoTextBox.ReadOnly = true;
            numeroTextBox.ReadOnly = true;
            cidadeTextBox.ReadOnly = true;
            ufTextBox.ReadOnly = true;

            idTextBox.Text = cliente.IdCliente.ToString();
            nomeTextBox.Text = cliente.nomeCliente.ToString();
            cpfTextBox.Text = cliente.cpfCliente.ToString();
            telefoneTextBox.Text = cliente.telCliente.ToString();
            cepTextBox.Text = cliente.cepCliente.ToString();
            enderecoTextBox.Text = cliente.endCliente.ToString();
            numeroTextBox.Text = cliente.numEndCliente.ToString();
            cidadeTextBox.Text = cliente.cidCliente.ToString();
            ufTextBox.Text = cliente.ufCliente.ToString();
            ExibirFicha();
            confirmarAlterarButton.Visible = false;
            confirmarExclusaoButton.Visible = true;
            confirmarNovoButton.Visible = false;
        }

        private void confirmarExclusaoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.IdCliente = Convert.ToInt32(idTextBox.Text);

            var db = new ClienteDb();
            db.Excluir(cliente.IdCliente);

            ExibirGrid();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
