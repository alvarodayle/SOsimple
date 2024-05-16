namespace Empresa.UI.Windows
{
    partial class PecaForm
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
            this.filtrosPainel = new System.Windows.Forms.Panel();
            this.filtroMarcaTextBox = new System.Windows.Forms.TextBox();
            this.filtroMarcaLabel = new System.Windows.Forms.Label();
            this.filtroModeloTextBox = new System.Windows.Forms.TextBox();
            this.filtroModeloLabel = new System.Windows.Forms.Label();
            this.filtroTipoTextBox = new System.Windows.Forms.TextBox();
            this.filtroTipolabel = new System.Windows.Forms.Label();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.fichaPanel = new System.Windows.Forms.Panel();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloLabel = new System.Windows.Forms.Label();
            this.descPecaTextBox = new System.Windows.Forms.TextBox();
            this.descPecaLabel = new System.Windows.Forms.Label();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.marcaLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listaDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.qtdTextBox = new System.Windows.Forms.TextBox();
            this.qtdPecaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.conteudoPanel.SuspendLayout();
            this.filtrosPainel.SuspendLayout();
            this.fichaPanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.conteudoPanel.Controls.Add(this.filtrosPainel);
            this.conteudoPanel.Controls.Add(this.fichaPanel);
            this.conteudoPanel.Controls.Add(this.panel2);
            this.conteudoPanel.Controls.Add(this.idTextBox);
            this.conteudoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteudoPanel.Location = new System.Drawing.Point(0, 0);
            this.conteudoPanel.Name = "conteudoPanel";
            this.conteudoPanel.Padding = new System.Windows.Forms.Padding(10);
            this.conteudoPanel.Size = new System.Drawing.Size(1200, 393);
            this.conteudoPanel.TabIndex = 1;
            // 
            // filtrosPainel
            // 
            this.filtrosPainel.Controls.Add(this.filtroMarcaTextBox);
            this.filtrosPainel.Controls.Add(this.filtroMarcaLabel);
            this.filtrosPainel.Controls.Add(this.filtroModeloTextBox);
            this.filtrosPainel.Controls.Add(this.filtroModeloLabel);
            this.filtrosPainel.Controls.Add(this.filtroTipoTextBox);
            this.filtrosPainel.Controls.Add(this.filtroTipolabel);
            this.filtrosPainel.Controls.Add(this.pesquisarButton);
            this.filtrosPainel.Location = new System.Drawing.Point(13, 13);
            this.filtrosPainel.Name = "filtrosPainel";
            this.filtrosPainel.Size = new System.Drawing.Size(1174, 75);
            this.filtrosPainel.TabIndex = 13;
            // 
            // filtroMarcaTextBox
            // 
            this.filtroMarcaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filtroMarcaTextBox.Location = new System.Drawing.Point(711, 31);
            this.filtroMarcaTextBox.Name = "filtroMarcaTextBox";
            this.filtroMarcaTextBox.Size = new System.Drawing.Size(204, 22);
            this.filtroMarcaTextBox.TabIndex = 15;
            // 
            // filtroMarcaLabel
            // 
            this.filtroMarcaLabel.AutoSize = true;
            this.filtroMarcaLabel.Location = new System.Drawing.Point(657, 37);
            this.filtroMarcaLabel.Name = "filtroMarcaLabel";
            this.filtroMarcaLabel.Size = new System.Drawing.Size(48, 16);
            this.filtroMarcaLabel.TabIndex = 14;
            this.filtroMarcaLabel.Text = "Marca:";
            this.filtroMarcaLabel.UseWaitCursor = true;
            // 
            // filtroModeloTextBox
            // 
            this.filtroModeloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filtroModeloTextBox.Location = new System.Drawing.Point(426, 31);
            this.filtroModeloTextBox.Name = "filtroModeloTextBox";
            this.filtroModeloTextBox.Size = new System.Drawing.Size(204, 22);
            this.filtroModeloTextBox.TabIndex = 13;
            // 
            // filtroModeloLabel
            // 
            this.filtroModeloLabel.AutoSize = true;
            this.filtroModeloLabel.Location = new System.Drawing.Point(364, 37);
            this.filtroModeloLabel.Name = "filtroModeloLabel";
            this.filtroModeloLabel.Size = new System.Drawing.Size(56, 16);
            this.filtroModeloLabel.TabIndex = 12;
            this.filtroModeloLabel.Text = "Modelo:";
            this.filtroModeloLabel.UseWaitCursor = true;
            // 
            // filtroTipoTextBox
            // 
            this.filtroTipoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filtroTipoTextBox.Location = new System.Drawing.Point(129, 31);
            this.filtroTipoTextBox.Name = "filtroTipoTextBox";
            this.filtroTipoTextBox.Size = new System.Drawing.Size(204, 22);
            this.filtroTipoTextBox.TabIndex = 11;
            // 
            // filtroTipolabel
            // 
            this.filtroTipolabel.AutoSize = true;
            this.filtroTipolabel.Location = new System.Drawing.Point(11, 37);
            this.filtroTipolabel.Name = "filtroTipolabel";
            this.filtroTipolabel.Size = new System.Drawing.Size(107, 16);
            this.filtroTipolabel.TabIndex = 10;
            this.filtroTipolabel.Text = "Tipo do Porduto:";
            this.filtroTipolabel.UseWaitCursor = true;
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Location = new System.Drawing.Point(952, 20);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(206, 33);
            this.pesquisarButton.TabIndex = 0;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisarButton_Click);
            // 
            // fichaPanel
            // 
            this.fichaPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fichaPanel.Controls.Add(this.qtdPecaLabel);
            this.fichaPanel.Controls.Add(this.qtdTextBox);
            this.fichaPanel.Controls.Add(this.tipoTextBox);
            this.fichaPanel.Controls.Add(this.marcaTextBox);
            this.fichaPanel.Controls.Add(this.modeloLabel);
            this.fichaPanel.Controls.Add(this.descPecaTextBox);
            this.fichaPanel.Controls.Add(this.descPecaLabel);
            this.fichaPanel.Controls.Add(this.modeloTextBox);
            this.fichaPanel.Controls.Add(this.marcaLabel);
            this.fichaPanel.Controls.Add(this.tipoLabel);
            this.fichaPanel.Location = new System.Drawing.Point(13, 12);
            this.fichaPanel.Name = "fichaPanel";
            this.fichaPanel.Size = new System.Drawing.Size(420, 368);
            this.fichaPanel.TabIndex = 1;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marcaTextBox.Location = new System.Drawing.Point(162, 193);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(250, 22);
            this.marcaTextBox.TabIndex = 2;
            // 
            // modeloLabel
            // 
            this.modeloLabel.AutoSize = true;
            this.modeloLabel.Location = new System.Drawing.Point(11, 156);
            this.modeloLabel.Name = "modeloLabel";
            this.modeloLabel.Size = new System.Drawing.Size(125, 16);
            this.modeloLabel.TabIndex = 22;
            this.modeloLabel.Text = "Modelo do Produto:";
            // 
            // descPecaTextBox
            // 
            this.descPecaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descPecaTextBox.Location = new System.Drawing.Point(162, 230);
            this.descPecaTextBox.Name = "descPecaTextBox";
            this.descPecaTextBox.Size = new System.Drawing.Size(250, 22);
            this.descPecaTextBox.TabIndex = 3;
            // 
            // descPecaLabel
            // 
            this.descPecaLabel.AutoSize = true;
            this.descPecaLabel.Location = new System.Drawing.Point(11, 230);
            this.descPecaLabel.Name = "descPecaLabel";
            this.descPecaLabel.Size = new System.Drawing.Size(126, 16);
            this.descPecaLabel.TabIndex = 16;
            this.descPecaLabel.Text = "Descrição da Peça:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modeloTextBox.Location = new System.Drawing.Point(162, 156);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(250, 22);
            this.modeloTextBox.TabIndex = 1;
            // 
            // marcaLabel
            // 
            this.marcaLabel.AutoSize = true;
            this.marcaLabel.Location = new System.Drawing.Point(11, 193);
            this.marcaLabel.Name = "marcaLabel";
            this.marcaLabel.Size = new System.Drawing.Size(117, 16);
            this.marcaLabel.TabIndex = 11;
            this.marcaLabel.Text = "Marca do Produto:";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(11, 120);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(107, 16);
            this.tipoLabel.TabIndex = 9;
            this.tipoLabel.Text = "Tipo do Produto:";
            this.tipoLabel.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listaDataGridView);
            this.panel2.Location = new System.Drawing.Point(13, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 299);
            this.panel2.TabIndex = 14;
            // 
            // listaDataGridView
            // 
            this.listaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.listaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.listaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDataGridView.Location = new System.Drawing.Point(942, 10);
            this.listaDataGridView.Name = "listaDataGridView";
            this.listaDataGridView.RowHeadersWidth = 51;
            this.listaDataGridView.RowTemplate.Height = 24;
            this.listaDataGridView.Size = new System.Drawing.Size(216, 273);
            this.listaDataGridView.TabIndex = 0;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(493, 120);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 12;
            this.idTextBox.TabStop = false;
            this.idTextBox.Visible = false;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoTextBox.Location = new System.Drawing.Point(162, 114);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(250, 22);
            this.tipoTextBox.TabIndex = 23;
            // 
            // qtdTextBox
            // 
            this.qtdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtdTextBox.Location = new System.Drawing.Point(162, 267);
            this.qtdTextBox.Name = "qtdTextBox";
            this.qtdTextBox.Size = new System.Drawing.Size(250, 22);
            this.qtdTextBox.TabIndex = 24;
            // 
            // qtdPecaLabel
            // 
            this.qtdPecaLabel.AutoSize = true;
            this.qtdPecaLabel.Location = new System.Drawing.Point(11, 267);
            this.qtdPecaLabel.Name = "qtdPecaLabel";
            this.qtdPecaLabel.Size = new System.Drawing.Size(141, 16);
            this.qtdPecaLabel.TabIndex = 25;
            this.qtdPecaLabel.Text = "Quantidade de Peças:";
            // 
            // PecaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 493);
            this.Controls.Add(this.conteudoPanel);
            this.Controls.Add(this.panel1);
            this.Name = "PecaForm";
            this.Text = "Peças";
            this.Load += new System.EventHandler(this.PecaForm_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.conteudoPanel.ResumeLayout(false);
            this.conteudoPanel.PerformLayout();
            this.filtrosPainel.ResumeLayout(false);
            this.filtrosPainel.PerformLayout();
            this.fichaPanel.ResumeLayout(false);
            this.fichaPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label marcaLabel;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.Label modeloLabel;
        private System.Windows.Forms.TextBox descPecaTextBox;
        private System.Windows.Forms.Label descPecaLabel;
        private System.Windows.Forms.Panel filtrosPainel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label filtroTipolabel;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.TextBox filtroMarcaTextBox;
        private System.Windows.Forms.Label filtroMarcaLabel;
        private System.Windows.Forms.TextBox filtroModeloTextBox;
        private System.Windows.Forms.Label filtroModeloLabel;
        private System.Windows.Forms.TextBox filtroTipoTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.Label qtdPecaLabel;
        private System.Windows.Forms.TextBox qtdTextBox;
    }
}