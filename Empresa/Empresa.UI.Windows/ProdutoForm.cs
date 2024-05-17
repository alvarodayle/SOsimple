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
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
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

            var db = new ProdutoDb();
            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = true;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false;
            
            listaDataGridView.Columns[0].Width = 35;
            listaDataGridView.Columns[1].Width = 200;
            listaDataGridView.Columns[2].Width = 100;
            listaDataGridView.Columns[3].Width = 100;

            listaDataGridView.Columns[0].HeaderText = "ID";
            listaDataGridView.Columns[1].HeaderText = "Tipo";
            listaDataGridView.Columns[2].HeaderText = "Modelo";
            listaDataGridView.Columns[3].HeaderText = "Marca";

        }
        private void ProdutoForm_Load(object sender, EventArgs e)
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
            tipoTextBox.Clear();
            modeloTextBox.Clear();
            marcaTextBox.Clear();


        }
        private void voltarButton_Click(object sender, EventArgs e)
        {
            if (excluirAcionado)
            { 

                excluirAcionado = false;

                tipoTextBox.ReadOnly = false;
                modeloTextBox.ReadOnly = false;
                marcaTextBox.ReadOnly = false;
            }

            ExibirGrid();
        }

        private void confirmarNovoButton_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.tipoProduto = tipoTextBox.Text;
            produto.modeloProduto = modeloTextBox.Text;
            produto.marcaProduto = marcaTextBox.Text;


            var db = new ProdutoDb();
            db.Incluir(produto);

            ExibirGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {

            if (listaDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Náo há nenhum registro selecionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Produto produto = (Produto)listaDataGridView.CurrentRow.DataBoundItem;

                idTextBox.Text = produto.IdProduto.ToString();
                tipoTextBox.Text = produto.tipoProduto;
                modeloTextBox.Text = produto.modeloProduto;
                marcaTextBox.Text = produto.marcaProduto;

                ExibirFicha();
                confirmarAlterarButton.Visible = true;
                confirmarExclusaoButton.Visible = false;
                confirmarNovoButton.Visible = false;
            }
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto.IdProduto = Convert.ToInt32(idTextBox.Text);
            produto.tipoProduto = tipoTextBox.Text;
            produto.modeloProduto = modeloTextBox.Text;
            produto.marcaProduto = marcaTextBox.Text;


            var db = new ProdutoDb();
            db.Alterar(produto);

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

                Produto produto = (Produto)listaDataGridView.CurrentRow.DataBoundItem;

                tipoTextBox.ReadOnly = true;
                modeloTextBox.ReadOnly = true;
                marcaTextBox.ReadOnly = true;


                idTextBox.Text = produto.IdProduto.ToString();
                tipoTextBox.Text = produto.tipoProduto.ToString();
                modeloTextBox.Text = produto.modeloProduto.ToString();
                marcaTextBox.Text = produto.marcaProduto.ToString();

                ExibirFicha();
                confirmarAlterarButton.Visible = false;
                confirmarExclusaoButton.Visible = true;
                confirmarNovoButton.Visible = false;

            }
        }

        private void confirmarExclusaoButton_Click(object sender, EventArgs e)
        {

            var produto = new Produto();
            produto.IdProduto = Convert.ToInt32(idTextBox.Text);

            var db = new ProdutoDb();
            db.Excluir(produto.IdProduto);

            ExibirGrid();

            excluirAcionado = false;

            tipoTextBox.ReadOnly = false;
            modeloTextBox.ReadOnly = false;
            marcaTextBox.ReadOnly = false;

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
