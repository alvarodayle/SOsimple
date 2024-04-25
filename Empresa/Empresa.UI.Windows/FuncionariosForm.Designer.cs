namespace Empresa.UI.Windows
{
    partial class FuncionariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.confirmarNovoButton = new System.Windows.Forms.Button();
            this.confirmarAlterarButton = new System.Windows.Forms.Button();
            this.confirmarExclusaoButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.conteudoPanel = new System.Windows.Forms.Panel();
            this.fichaPanel = new System.Windows.Forms.Panel();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.conteudoPanel.SuspendLayout();
            this.fichaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.novoButton);
            this.flowLayoutPanel1.Controls.Add(this.alterarButton);
            this.flowLayoutPanel1.Controls.Add(this.excluirButton);
            this.flowLayoutPanel1.Controls.Add(this.sairButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarNovoButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarAlterarButton);
            this.flowLayoutPanel1.Controls.Add(this.confirmarExclusaoButton);
            this.flowLayoutPanel1.Controls.Add(this.voltarButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 7, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(13, 10);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 0;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(94, 10);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 1;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(175, 10);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 2;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(256, 10);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 3;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // confirmarNovoButton
            // 
            this.confirmarNovoButton.Location = new System.Drawing.Point(337, 10);
            this.confirmarNovoButton.Name = "confirmarNovoButton";
            this.confirmarNovoButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarNovoButton.TabIndex = 4;
            this.confirmarNovoButton.Text = "Gravar";
            this.confirmarNovoButton.UseVisualStyleBackColor = true;
            this.confirmarNovoButton.Click += new System.EventHandler(this.confirmarNovoButton_Click);
            // 
            // confirmarAlterarButton
            // 
            this.confirmarAlterarButton.Location = new System.Drawing.Point(418, 10);
            this.confirmarAlterarButton.Name = "confirmarAlterarButton";
            this.confirmarAlterarButton.Size = new System.Drawing.Size(133, 23);
            this.confirmarAlterarButton.TabIndex = 5;
            this.confirmarAlterarButton.Text = "Confirmar Alterar";
            this.confirmarAlterarButton.UseVisualStyleBackColor = true;
            this.confirmarAlterarButton.Click += new System.EventHandler(this.confirmarAlterarButton_Click);
            // 
            // confirmarExclusaoButton
            // 
            this.confirmarExclusaoButton.Location = new System.Drawing.Point(557, 10);
            this.confirmarExclusaoButton.Name = "confirmarExclusaoButton";
            this.confirmarExclusaoButton.Size = new System.Drawing.Size(133, 23);
            this.confirmarExclusaoButton.TabIndex = 6;
            this.confirmarExclusaoButton.Text = "Confirmar Exclusão";
            this.confirmarExclusaoButton.UseVisualStyleBackColor = true;
            this.confirmarExclusaoButton.Click += new System.EventHandler(this.confirmarExclusaoButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(696, 10);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(75, 23);
            this.voltarButton.TabIndex = 7;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // conteudoPanel
            // 
            this.conteudoPanel.Controls.Add(this.fichaPanel);
            this.conteudoPanel.Controls.Add(this.idTextBox);
            this.conteudoPanel.Controls.Add(this.listaDataGridView);
            this.conteudoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteudoPanel.Location = new System.Drawing.Point(0, 0);
            this.conteudoPanel.Name = "conteudoPanel";
            this.conteudoPanel.Padding = new System.Windows.Forms.Padding(10);
            this.conteudoPanel.Size = new System.Drawing.Size(1200, 393);
            this.conteudoPanel.TabIndex = 1;
            // 
            // fichaPanel
            // 
            this.fichaPanel.Controls.Add(this.senhaTextBox);
            this.fichaPanel.Controls.Add(this.loginLabel);
            this.fichaPanel.Controls.Add(this.departamentoTextBox);
            this.fichaPanel.Controls.Add(this.departamentoLabel);
            this.fichaPanel.Controls.Add(this.nomeTextBox);
            this.fichaPanel.Controls.Add(this.loginTextBox);
            this.fichaPanel.Controls.Add(this.senhaLabel);
            this.fichaPanel.Controls.Add(this.nomeLabel);
            this.fichaPanel.Location = new System.Drawing.Point(13, 13);
            this.fichaPanel.Name = "fichaPanel";
            this.fichaPanel.Size = new System.Drawing.Size(461, 367);
            this.fichaPanel.TabIndex = 1;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.Location = new System.Drawing.Point(81, 174);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(365, 22);
            this.senhaTextBox.TabIndex = 2;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(11, 141);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(43, 16);
            this.loginLabel.TabIndex = 22;
            this.loginLabel.Text = "Login:";
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departamentoTextBox.Location = new System.Drawing.Point(113, 213);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(333, 22);
            this.departamentoTextBox.TabIndex = 3;
            // 
            // departamentoLabel
            // 
            this.departamentoLabel.AutoSize = true;
            this.departamentoLabel.Location = new System.Drawing.Point(11, 219);
            this.departamentoLabel.Name = "departamentoLabel";
            this.departamentoLabel.Size = new System.Drawing.Size(96, 16);
            this.departamentoLabel.TabIndex = 16;
            this.departamentoLabel.Text = "Departamento:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Location = new System.Drawing.Point(81, 97);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(365, 22);
            this.nomeTextBox.TabIndex = 0;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Location = new System.Drawing.Point(81, 135);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(365, 22);
            this.loginTextBox.TabIndex = 1;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(11, 180);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(49, 16);
            this.senhaLabel.TabIndex = 11;
            this.senhaLabel.Text = "Senha:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(11, 103);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(47, 16);
            this.nomeLabel.TabIndex = 9;
            this.nomeLabel.Text = "Nome:";
            this.nomeLabel.UseWaitCursor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(480, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 12;
            this.idTextBox.TabStop = false;
            this.idTextBox.Visible = false;
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.listaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Location = new System.Drawing.Point(806, 12);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.RowHeadersWidth = 51;
            this.listaDataGridView.RowTemplate.Height = 24;
            this.listaDataGridView.Size = new System.Drawing.Size(381, 368);
            this.listaDataGridView.TabIndex = 0;
            // 
            // FuncionariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 493);
            this.Controls.Add(this.conteudoPanel);
            this.Controls.Add(this.panel1);
            this.Name = "FuncionariosForm";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.FuncionariosForm_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.conteudoPanel.ResumeLayout(false);
            this.conteudoPanel.PerformLayout();
            this.fichaPanel.ResumeLayout(false);
            this.fichaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button confirmarNovoButton;
        private System.Windows.Forms.Button confirmarAlterarButton;
        private System.Windows.Forms.Button confirmarExclusaoButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Panel conteudoPanel;
        private System.Windows.Forms.Panel fichaPanel;
        private System.Windows.Forms.DataGridView listaDataGridView;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.Label departamentoLabel;
    }
}