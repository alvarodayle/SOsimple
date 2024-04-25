using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Db;
using Empresa.Models;

namespace Empresa.UI.Windows
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
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
            mensagemLabel.Text = "";

            var db = new FuncionarioDb();
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
            listaDataGridView.Columns[1].HeaderText = "Nome";
            listaDataGridView.Columns[2].HeaderText = "Login";
            listaDataGridView.Columns[3].HeaderText = "Departamento";

        }
        private void FuncionarioForm_Load(object sender, EventArgs e)
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
            resetSenhaButton.Visible = true;

        }
        private void novoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();
            confirmarAlterarButton.Visible = false;
            confirmarExclusaoButton.Visible = false;
            confirmarNovoButton.Visible = true;
            resetSenhaButton.Visible = false;

            LimparFicha();

        }
        private void LimparFicha()
        {
            nomeTextBox.Clear();
            loginTextBox.Clear();
            departamentoTextBox.Clear();


        }
        private void voltarButton_Click(object sender, EventArgs e)
        {
            if (excluirAcionado)
            { 

                excluirAcionado = false;

                nomeTextBox.ReadOnly = false;
                loginTextBox.ReadOnly = false;
                departamentoTextBox.ReadOnly = false;
            }

            ExibirGrid();
        }

        private void confirmarNovoButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nomeTextBox.Text))
            {
                mensagemLabel.Text = "Campo Nome é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(departamentoTextBox.Text))
            {
                mensagemLabel.Text = "Campo Departamento é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                mensagemLabel.Text = "Campo Login é de preenchimento obrigatório";
            }

            else
            {
                var funcionario = new Funcionario();
                funcionario.nomeFunc = nomeTextBox.Text;
                funcionario.loginFunc = loginTextBox.Text.ToUpper();
                funcionario.deptFunc = departamentoTextBox.Text.ToUpper();


                var db = new FuncionarioDb();
                db.Incluir(funcionario);

                if (db.tem)
                {
                    mensagemLabel.Text = db.mensagem;
                }
                else
                {
                    ExibirGrid();
                }
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
                Funcionario funcionario = (Funcionario)listaDataGridView.CurrentRow.DataBoundItem;

                idTextBox.Text = funcionario.IdFunc.ToString();
                nomeTextBox.Text = funcionario.nomeFunc;
                loginTextBox.Text = funcionario.loginFunc;
                departamentoTextBox.Text = funcionario.deptFunc;

                ExibirFicha();
                confirmarAlterarButton.Visible = true;
                confirmarExclusaoButton.Visible = false;
                confirmarNovoButton.Visible = false;

            }
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nomeTextBox.Text))
            {
                mensagemLabel.Text = "Campo Nome é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(departamentoTextBox.Text))
            {
                mensagemLabel.Text = "Campo Departamento é de preenchimento obrigatório";
            }

            else if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                mensagemLabel.Text = "Campo Login é de preenchimento obrigatório";
            }

            else
            {
                var funcionario = new Funcionario();
                funcionario.IdFunc = Convert.ToInt32(idTextBox.Text);
                funcionario.nomeFunc = nomeTextBox.Text;
                funcionario.loginFunc = loginTextBox.Text;
                funcionario.deptFunc = departamentoTextBox.Text;


                var db = new FuncionarioDb();
                db.Alterar(funcionario);

                ExibirGrid();
            }

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

                Funcionario funcionario = (Funcionario)listaDataGridView.CurrentRow.DataBoundItem;

                nomeTextBox.ReadOnly = true;
                loginTextBox.ReadOnly = true;
                departamentoTextBox.ReadOnly = true;


                idTextBox.Text = funcionario.IdFunc.ToString();
                nomeTextBox.Text = funcionario.nomeFunc.ToString();
                loginTextBox.Text = funcionario.loginFunc.ToString();
                departamentoTextBox.Text = funcionario.deptFunc.ToString();

                ExibirFicha();
                confirmarAlterarButton.Visible = false;
                confirmarExclusaoButton.Visible = true;
                confirmarNovoButton.Visible = false;
                resetSenhaButton.Visible = false;

            }
        }

        private void confirmarExclusaoButton_Click(object sender, EventArgs e)
        {

            var funcionario = new Funcionario();
            funcionario.IdFunc = Convert.ToInt32(idTextBox.Text);

            var db = new FuncionarioDb();
            db.Excluir(funcionario.IdFunc);

            ExibirGrid();

            excluirAcionado = false;

            nomeTextBox.ReadOnly = false;
            loginTextBox.ReadOnly = false;
            departamentoTextBox.ReadOnly = false;

        }

        private void resetSenhaButton_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario();
            funcionario.IdFunc = Convert.ToInt32(idTextBox.Text);

            var db = new FuncionarioDb();
            db.resetSenha(funcionario.IdFunc);

            mensagemLabel.Text = "Senha do Colaborador foi Resetada com Sucesso";
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
