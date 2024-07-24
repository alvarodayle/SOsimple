using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Db;
using Empresa.Models;

namespace Empresa.UI.Windows
{
    public partial class PecaForm : Form
    {
        public PecaForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Columns.Clear();
            listaDataGridView.Visible = true;
            filtrosPainel.Visible = true;
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

        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {

            string filtroTipoProduto = ($"%{filtroTipoTextBox.Text}%");
            string filtroModeloProduto = ($"%{filtroModeloTextBox.Text}%");
            string filtroMarcaProduto = ($"%{filtroMarcaTextBox.Text}%");
            string filtroDescPeca = ($"%{filtroDescPecaTextBox.Text}%");

            var db = new PecaDb();
            listaDataGridView.DataSource = db.Listar(filtroMarcaProduto, filtroTipoProduto, filtroModeloProduto, filtroDescPeca);
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = true;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false;

            listaDataGridView.Columns[0].Width = 35;

            listaDataGridView.Columns[0].HeaderText = "ID";
            listaDataGridView.Columns[1].HeaderText = "Marca";
            listaDataGridView.Columns[2].HeaderText = "Tipo do Produto";
            listaDataGridView.Columns[3].HeaderText = "Modelo";
            listaDataGridView.Columns[4].HeaderText = "Descrição da Peça";
            listaDataGridView.Columns[5].HeaderText = "Quantidade em Estoque";
        }
        private void PecaForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void ExibirFicha()
        {
            fichaPanel.Visible = true;
            fichaPanel.Dock = DockStyle.Fill;
            listaDataGridView.Visible = false;
            filtrosPainel.Visible = false;
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

            marcaComboBox.Text = null;
            tipoComboBox.Text = null;
            modeloComboBox.Text = null;

            marcaComboBox.Items.Clear();
            tipoComboBox.Items.Clear();
            modeloComboBox.Items.Clear();

            tipoComboBox.Enabled = false;
            modeloComboBox.Enabled = false;

            marcaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            modeloComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var cb = new PecaDb();
            List<string> listaMarca = cb.MarcaComboBox();

            marcaComboBox.Items.AddRange(listaMarca.ToArray());

            confirmarAlterarButton.Visible = false;
            confirmarExclusaoButton.Visible = false;
            confirmarNovoButton.Visible = true;

            LimparFicha();

        }

        private void marcaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoComboBox.Items.Clear();
            modeloComboBox.Items.Clear();

            tipoComboBox.Text = null;
            modeloComboBox.Text = null;

            var cb = new PecaDb();

            tipoComboBox.Enabled = true;

            List<string> listaTipo = cb.TipoComboBox(marcaComboBox.Text);

            tipoComboBox.Items.AddRange(listaTipo.ToArray());
        }

        private void tipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modeloComboBox.Items.Clear();
            modeloComboBox.Text = null;

            var cb = new PecaDb();

            modeloComboBox.Enabled = true;

            List<string> listaModelo = cb.ModeloComboBox(marcaComboBox.Text, tipoComboBox.Text);

            modeloComboBox.Items.AddRange(listaModelo.ToArray());
        }

        private void LimparFicha()
        {
            descPecaTextBox.Clear();
            qtdTextBox.Clear();
        }
        private void voltarButton_Click(object sender, EventArgs e)
        {
            if (excluirAcionado)
            { 

                excluirAcionado = false;

                marcaComboBox.Enabled = true;
                tipoComboBox.Enabled = true;
                modeloComboBox.Enabled = true;
                descPecaTextBox.ReadOnly = false;
                qtdTextBox.ReadOnly = false;
            }

            ExibirGrid();
        }

        private void confirmarNovoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(marcaComboBox.Text))
            {
                mensagemLabel.Text = "Campo Marca do Produto é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(tipoComboBox.Text))
            {
                mensagemLabel.Text = "Campo Tipo do Produto é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(modeloComboBox.Text))
            {
                mensagemLabel.Text = "Campo Modelo do Produto é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(descPecaTextBox.Text))
            {
                mensagemLabel.Text = "Campo Descrição da Peça é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(qtdTextBox.Text))
            {
                mensagemLabel.Text = "Campo Quantidade de Peças é de preenchimento obrigatório";
            }
            else
            {
                
                var peca = new Peca();
                peca.marcaProduto = marcaComboBox.Text;
                peca.tipoProduto = tipoComboBox.Text;
                peca.modeloProduto = modeloComboBox.Text;
                peca.nomePeca = descPecaTextBox.Text;
                peca.qtdPeca = Convert.ToInt32(qtdTextBox.Text);

                var db = new PecaDb();
                db.Incluir(peca);

                ExibirGrid();
                
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {

            if (listaDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Náo há nenhum registro selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                marcaComboBox.Items.Clear();
                tipoComboBox.Items.Clear();
                modeloComboBox.Items.Clear();

                var cb = new PecaDb();
                List<string> listaMarca = cb.MarcaComboBox();

                marcaComboBox.Items.AddRange(listaMarca.ToArray());

                Peca peca = (Peca)listaDataGridView.CurrentRow.DataBoundItem;

                idPecaTextBox.Text = peca.idPeca.ToString();
                marcaComboBox.Text = peca.marcaProduto;
                tipoComboBox.Text = peca.tipoProduto;
                modeloComboBox.Text = peca.modeloProduto;
                descPecaTextBox.Text = peca.nomePeca;
                qtdTextBox.Text = Convert.ToString(peca.qtdPeca);

                ExibirFicha();
                confirmarAlterarButton.Visible = true;
                confirmarExclusaoButton.Visible = false;
                confirmarNovoButton.Visible = false;
            }
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var peca = new Peca();

            peca.idPeca = Convert.ToInt32(idPecaTextBox.Text);
            peca.tipoProduto = tipoComboBox.Text;
            peca.modeloProduto = modeloComboBox.Text;
            peca.marcaProduto = marcaComboBox.Text;
            peca.nomePeca = descPecaTextBox.Text;
            peca.qtdPeca = Convert.ToInt32(qtdTextBox.Text);


            var db = new PecaDb();
            db.Alterar(peca);

            ExibirGrid();
        }

        bool excluirAcionado = false;


        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (listaDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Náo há nenhum registro selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                excluirAcionado = true;

                Peca peca = (Peca)listaDataGridView.CurrentRow.DataBoundItem;

                marcaComboBox.Items.Clear();
                tipoComboBox.Items.Clear();
                modeloComboBox.Items.Clear();

                marcaComboBox.Enabled = false;
                tipoComboBox.Enabled = false;
                modeloComboBox.Enabled = false;
                descPecaTextBox.ReadOnly = true;
                qtdTextBox.ReadOnly = true;

                idPecaTextBox.Text = peca.idPeca.ToString();
                marcaComboBox.Text = peca.marcaProduto;
                tipoComboBox.Text = peca.tipoProduto;
                modeloComboBox.Text = peca.modeloProduto;
                descPecaTextBox.Text = peca.nomePeca;
                qtdTextBox.Text = Convert.ToString(peca.qtdPeca);

                ExibirFicha();
                confirmarAlterarButton.Visible = false;
                confirmarExclusaoButton.Visible = true;
                confirmarNovoButton.Visible = false;

            }
        }

        private void confirmarExclusaoButton_Click(object sender, EventArgs e)
        {

            var peca = new Peca();
            peca.idPeca = Convert.ToInt32(idPecaTextBox.Text);

            var db = new PecaDb();
            db.Excluir(peca.idPeca);

            ExibirGrid();

            excluirAcionado = false;

            marcaComboBox.Enabled = true;
            tipoComboBox.Enabled = true;
            modeloComboBox.Enabled = true;
            descPecaTextBox.ReadOnly = false;
            qtdTextBox.ReadOnly = false;

        }

        public String boasvindas;

        public void guardanome(String nomeFuncionario)
        {
            boasvindas = nomeFuncionario;
        }

        public String direitoAcesso;

        public void acesso(String departamento)
        {
            direitoAcesso = departamento;
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();

            var pf = new principalForm();
            pf.guardanome(boasvindas);
            pf.acesso(direitoAcesso);
            pf.Show();
        }
    }
}
