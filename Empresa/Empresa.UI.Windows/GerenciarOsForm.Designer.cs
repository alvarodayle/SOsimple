namespace Empresa.UI.Windows
{
    partial class GerenciarOsForm
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
            this.buscarOsTabControl = new System.Windows.Forms.TabControl();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.osDataGridView = new System.Windows.Forms.DataGridView();
            this.pesquisarButton = new System.Windows.Forms.Button();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.tabOrdemDeServico = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.numeroSerialTextBox = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.produtoPecaTabControl = new System.Windows.Forms.TabControl();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.aparenciaTextBox = new System.Windows.Forms.TextBox();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.descDefeitoTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPecas = new System.Windows.Forms.TabPage();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.solicitarPecaButton = new System.Windows.Forms.Button();
            this.pecaSolDataGridView = new System.Windows.Forms.DataGridView();
            this.pecaDispDataGridView = new System.Windows.Forms.DataGridView();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ufTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.alterarOsButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.gravarButton = new System.Windows.Forms.Button();
            this.confAlterarButton = new System.Windows.Forms.Button();
            this.novaOsButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buscarOsTabControl.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osDataGridView)).BeginInit();
            this.tabOrdemDeServico.SuspendLayout();
            this.produtoPecaTabControl.SuspendLayout();
            this.tabProduto.SuspendLayout();
            this.tabPecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pecaSolDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecaDispDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarOsTabControl
            // 
            this.buscarOsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarOsTabControl.Controls.Add(this.tabBuscar);
            this.buscarOsTabControl.Controls.Add(this.tabOrdemDeServico);
            this.buscarOsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarOsTabControl.ItemSize = new System.Drawing.Size(45, 40);
            this.buscarOsTabControl.Location = new System.Drawing.Point(9, 75);
            this.buscarOsTabControl.Name = "buscarOsTabControl";
            this.buscarOsTabControl.SelectedIndex = 0;
            this.buscarOsTabControl.Size = new System.Drawing.Size(980, 428);
            this.buscarOsTabControl.TabIndex = 0;
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.tabBuscar.Controls.Add(this.osDataGridView);
            this.tabBuscar.Controls.Add(this.pesquisarButton);
            this.tabBuscar.Controls.Add(this.filtroTextBox);
            this.tabBuscar.Controls.Add(this.filtroComboBox);
            this.tabBuscar.Location = new System.Drawing.Point(4, 44);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabBuscar.Size = new System.Drawing.Size(972, 380);
            this.tabBuscar.TabIndex = 0;
            this.tabBuscar.Text = "Buscar";
            // 
            // osDataGridView
            // 
            this.osDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.osDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.osDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.osDataGridView.Location = new System.Drawing.Point(6, 41);
            this.osDataGridView.Name = "osDataGridView";
            this.osDataGridView.RowHeadersWidth = 51;
            this.osDataGridView.Size = new System.Drawing.Size(962, 323);
            this.osDataGridView.TabIndex = 0;
            // 
            // pesquisarButton
            // 
            this.pesquisarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarButton.Location = new System.Drawing.Point(832, 6);
            this.pesquisarButton.Name = "pesquisarButton";
            this.pesquisarButton.Size = new System.Drawing.Size(136, 24);
            this.pesquisarButton.TabIndex = 3;
            this.pesquisarButton.Text = "Pesquisar";
            this.pesquisarButton.UseVisualStyleBackColor = true;
            this.pesquisarButton.Click += new System.EventHandler(this.pesquisarButton_Click);
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.filtroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filtroTextBox.Location = new System.Drawing.Point(163, 8);
            this.filtroTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(663, 23);
            this.filtroTextBox.TabIndex = 2;
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Location = new System.Drawing.Point(6, 6);
            this.filtroComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(148, 24);
            this.filtroComboBox.TabIndex = 1;
            // 
            // tabOrdemDeServico
            // 
            this.tabOrdemDeServico.BackColor = System.Drawing.Color.SteelBlue;
            this.tabOrdemDeServico.Controls.Add(this.label1);
            this.tabOrdemDeServico.Controls.Add(this.numeroTextBox);
            this.tabOrdemDeServico.Controls.Add(this.numeroSerialTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label31);
            this.tabOrdemDeServico.Controls.Add(this.produtoPecaTabControl);
            this.tabOrdemDeServico.Controls.Add(this.statusComboBox);
            this.tabOrdemDeServico.Controls.Add(this.label17);
            this.tabOrdemDeServico.Controls.Add(this.osTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label18);
            this.tabOrdemDeServico.Controls.Add(this.ufTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label19);
            this.tabOrdemDeServico.Controls.Add(this.cidadeTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label20);
            this.tabOrdemDeServico.Controls.Add(this.enderecoTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label21);
            this.tabOrdemDeServico.Controls.Add(this.cepTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label22);
            this.tabOrdemDeServico.Controls.Add(this.telefoneTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label23);
            this.tabOrdemDeServico.Controls.Add(this.nomeTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label24);
            this.tabOrdemDeServico.Controls.Add(this.cpfTextBox);
            this.tabOrdemDeServico.Controls.Add(this.label25);
            this.tabOrdemDeServico.Location = new System.Drawing.Point(4, 44);
            this.tabOrdemDeServico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabOrdemDeServico.Name = "tabOrdemDeServico";
            this.tabOrdemDeServico.Size = new System.Drawing.Size(972, 380);
            this.tabOrdemDeServico.TabIndex = 3;
            this.tabOrdemDeServico.Text = "Ordem de Serviço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(14, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Numero:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroTextBox.Location = new System.Drawing.Point(80, 136);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(114, 23);
            this.numeroTextBox.TabIndex = 39;
            // 
            // numeroSerialTextBox
            // 
            this.numeroSerialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroSerialTextBox.Location = new System.Drawing.Point(797, 136);
            this.numeroSerialTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numeroSerialTextBox.Name = "numeroSerialTextBox";
            this.numeroSerialTextBox.Size = new System.Drawing.Size(165, 23);
            this.numeroSerialTextBox.TabIndex = 38;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label31.Location = new System.Drawing.Point(596, 141);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(210, 17);
            this.label31.TabIndex = 37;
            this.label31.Text = "Número de Identificação / Série:";
            // 
            // produtoPecaTabControl
            // 
            this.produtoPecaTabControl.Controls.Add(this.tabProduto);
            this.produtoPecaTabControl.Controls.Add(this.tabPecas);
            this.produtoPecaTabControl.Location = new System.Drawing.Point(14, 174);
            this.produtoPecaTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.produtoPecaTabControl.Name = "produtoPecaTabControl";
            this.produtoPecaTabControl.SelectedIndex = 0;
            this.produtoPecaTabControl.Size = new System.Drawing.Size(947, 188);
            this.produtoPecaTabControl.TabIndex = 36;
            // 
            // tabProduto
            // 
            this.tabProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tabProduto.Controls.Add(this.label32);
            this.tabProduto.Controls.Add(this.aparenciaTextBox);
            this.tabProduto.Controls.Add(this.modeloComboBox);
            this.tabProduto.Controls.Add(this.marcaComboBox);
            this.tabProduto.Controls.Add(this.tipoComboBox);
            this.tabProduto.Controls.Add(this.descDefeitoTextBox);
            this.tabProduto.Controls.Add(this.label26);
            this.tabProduto.Controls.Add(this.label27);
            this.tabProduto.Controls.Add(this.label28);
            this.tabProduto.Controls.Add(this.label29);
            this.tabProduto.Location = new System.Drawing.Point(4, 25);
            this.tabProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabProduto.Size = new System.Drawing.Size(939, 159);
            this.tabProduto.TabIndex = 0;
            this.tabProduto.Text = "Produto";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(452, 45);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(150, 17);
            this.label32.TabIndex = 39;
            this.label32.Text = "Aparência do Produto:";
            // 
            // aparenciaTextBox
            // 
            this.aparenciaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aparenciaTextBox.Location = new System.Drawing.Point(609, 45);
            this.aparenciaTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aparenciaTextBox.Multiline = true;
            this.aparenciaTextBox.Name = "aparenciaTextBox";
            this.aparenciaTextBox.Size = new System.Drawing.Size(318, 101);
            this.aparenciaTextBox.TabIndex = 38;
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(768, 9);
            this.modeloComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(159, 24);
            this.modeloComboBox.TabIndex = 31;
            this.modeloComboBox.SelectedIndexChanged += new System.EventHandler(this.modeloComboBox_SelectedIndexChanged);
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(144, 9);
            this.marcaComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(180, 24);
            this.marcaComboBox.TabIndex = 30;
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(455, 9);
            this.tipoComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(170, 24);
            this.tipoComboBox.TabIndex = 32;
            this.tipoComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoComboBox_SelectedIndexChanged_1);
            // 
            // descDefeitoTextBox
            // 
            this.descDefeitoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descDefeitoTextBox.Location = new System.Drawing.Point(160, 45);
            this.descDefeitoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descDefeitoTextBox.Multiline = true;
            this.descDefeitoTextBox.Name = "descDefeitoTextBox";
            this.descDefeitoTextBox.Size = new System.Drawing.Size(288, 101);
            this.descDefeitoTextBox.TabIndex = 37;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.Control;
            this.label26.Location = new System.Drawing.Point(16, 11);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(125, 17);
            this.label26.TabIndex = 34;
            this.label26.Text = "Marca do Produto:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 45);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(144, 17);
            this.label27.TabIndex = 35;
            this.label27.Text = "Descrição do Defeito:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(630, 11);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(132, 17);
            this.label28.TabIndex = 36;
            this.label28.Text = "Modelo do Produto:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(328, 11);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 17);
            this.label29.TabIndex = 33;
            this.label29.Text = "Tipo do Produto:";
            this.label29.UseWaitCursor = true;
            // 
            // tabPecas
            // 
            this.tabPecas.BackColor = System.Drawing.SystemColors.Control;
            this.tabPecas.Controls.Add(this.quantidadeTextBox);
            this.tabPecas.Controls.Add(this.label34);
            this.tabPecas.Controls.Add(this.solicitarPecaButton);
            this.tabPecas.Controls.Add(this.pecaSolDataGridView);
            this.tabPecas.Controls.Add(this.pecaDispDataGridView);
            this.tabPecas.Location = new System.Drawing.Point(4, 25);
            this.tabPecas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPecas.Name = "tabPecas";
            this.tabPecas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPecas.Size = new System.Drawing.Size(939, 159);
            this.tabPecas.TabIndex = 1;
            this.tabPecas.Text = "Peças";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantidadeTextBox.Location = new System.Drawing.Point(94, 7);
            this.quantidadeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(36, 23);
            this.quantidadeTextBox.TabIndex = 41;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(4, 12);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(86, 17);
            this.label34.TabIndex = 40;
            this.label34.Text = "Quantidade:";
            // 
            // solicitarPecaButton
            // 
            this.solicitarPecaButton.Location = new System.Drawing.Point(306, 7);
            this.solicitarPecaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.solicitarPecaButton.Name = "solicitarPecaButton";
            this.solicitarPecaButton.Size = new System.Drawing.Size(86, 27);
            this.solicitarPecaButton.TabIndex = 39;
            this.solicitarPecaButton.Text = "Solicitar";
            this.solicitarPecaButton.UseVisualStyleBackColor = true;
            // 
            // pecaSolDataGridView
            // 
            this.pecaSolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pecaSolDataGridView.Location = new System.Drawing.Point(552, 44);
            this.pecaSolDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pecaSolDataGridView.Name = "pecaSolDataGridView";
            this.pecaSolDataGridView.RowHeadersWidth = 51;
            this.pecaSolDataGridView.RowTemplate.Height = 24;
            this.pecaSolDataGridView.Size = new System.Drawing.Size(387, 115);
            this.pecaSolDataGridView.TabIndex = 38;
            // 
            // pecaDispDataGridView
            // 
            this.pecaDispDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pecaDispDataGridView.Location = new System.Drawing.Point(4, 41);
            this.pecaDispDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pecaDispDataGridView.Name = "pecaDispDataGridView";
            this.pecaDispDataGridView.RowHeadersWidth = 51;
            this.pecaDispDataGridView.RowTemplate.Height = 24;
            this.pecaDispDataGridView.Size = new System.Drawing.Size(387, 115);
            this.pecaDispDataGridView.TabIndex = 37;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(732, 13);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(230, 24);
            this.statusComboBox.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(642, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "Status da OS:";
            // 
            // osTextBox
            // 
            this.osTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.osTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.osTextBox.Location = new System.Drawing.Point(51, 15);
            this.osTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(161, 23);
            this.osTextBox.TabIndex = 33;
            this.osTextBox.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(11, 20);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "OS:";
            // 
            // ufTextBox
            // 
            this.ufTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ufTextBox.Location = new System.Drawing.Point(531, 136);
            this.ufTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ufTextBox.Name = "ufTextBox";
            this.ufTextBox.Size = new System.Drawing.Size(52, 23);
            this.ufTextBox.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(489, 138);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 17);
            this.label19.TabIndex = 30;
            this.label19.Text = "UF:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cidadeTextBox.Location = new System.Drawing.Point(266, 136);
            this.cidadeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(216, 23);
            this.cidadeTextBox.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(198, 138);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 17);
            this.label20.TabIndex = 28;
            this.label20.Text = "Cidade:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enderecoTextBox.Location = new System.Drawing.Point(284, 93);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(678, 23);
            this.enderecoTextBox.TabIndex = 27;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(216, 98);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "Endereço:";
            // 
            // cepTextBox
            // 
            this.cepTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cepTextBox.Location = new System.Drawing.Point(51, 93);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(161, 23);
            this.cepTextBox.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(10, 98);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 17);
            this.label22.TabIndex = 24;
            this.label22.Text = "CEP:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefoneTextBox.Location = new System.Drawing.Point(801, 55);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(161, 23);
            this.telefoneTextBox.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(738, 60);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 17);
            this.label23.TabIndex = 22;
            this.label23.Text = "Telefone:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeTextBox.Location = new System.Drawing.Point(266, 55);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(468, 23);
            this.nomeTextBox.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(216, 60);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 17);
            this.label24.TabIndex = 20;
            this.label24.Text = "Nome:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpfTextBox.Location = new System.Drawing.Point(51, 55);
            this.cpfTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpfTextBox.MaxLength = 11;
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(161, 23);
            this.cpfTextBox.TabIndex = 19;
            this.cpfTextBox.TextChanged += new System.EventHandler(this.cpfTextBox_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(10, 60);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 17);
            this.label25.TabIndex = 18;
            this.label25.Text = "CPF:";
            // 
            // alterarOsButton
            // 
            this.alterarOsButton.Location = new System.Drawing.Point(82, 2);
            this.alterarOsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alterarOsButton.Name = "alterarOsButton";
            this.alterarOsButton.Size = new System.Drawing.Size(76, 50);
            this.alterarOsButton.TabIndex = 14;
            this.alterarOsButton.Text = "Alterar";
            this.alterarOsButton.UseVisualStyleBackColor = true;
            this.alterarOsButton.Click += new System.EventHandler(this.alterarOsButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(162, 2);
            this.sairButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(76, 50);
            this.sairButton.TabIndex = 15;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(242, 2);
            this.gravarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(76, 50);
            this.gravarButton.TabIndex = 17;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // confAlterarButton
            // 
            this.confAlterarButton.Location = new System.Drawing.Point(322, 2);
            this.confAlterarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confAlterarButton.Name = "confAlterarButton";
            this.confAlterarButton.Size = new System.Drawing.Size(76, 50);
            this.confAlterarButton.TabIndex = 16;
            this.confAlterarButton.Text = "Confirmar";
            this.confAlterarButton.UseVisualStyleBackColor = true;
            this.confAlterarButton.Click += new System.EventHandler(this.confAlterarButton_Click);
            // 
            // novaOsButton
            // 
            this.novaOsButton.Location = new System.Drawing.Point(2, 2);
            this.novaOsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.novaOsButton.Name = "novaOsButton";
            this.novaOsButton.Size = new System.Drawing.Size(76, 50);
            this.novaOsButton.TabIndex = 13;
            this.novaOsButton.Text = "Novo";
            this.novaOsButton.UseVisualStyleBackColor = true;
            this.novaOsButton.Click += new System.EventHandler(this.novaOsButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(402, 2);
            this.voltarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(76, 50);
            this.voltarButton.TabIndex = 18;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.novaOsButton);
            this.flowLayoutPanel1.Controls.Add(this.alterarOsButton);
            this.flowLayoutPanel1.Controls.Add(this.sairButton);
            this.flowLayoutPanel1.Controls.Add(this.gravarButton);
            this.flowLayoutPanel1.Controls.Add(this.confAlterarButton);
            this.flowLayoutPanel1.Controls.Add(this.voltarButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 68);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // GerenciarOsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.buscarOsTabControl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1016, 559);
            this.Name = "GerenciarOsForm";
            this.Text = "Gerenciamento de Ordens de Serviço";
            this.Load += new System.EventHandler(this.GerenciarOsForm_Load_1);
            this.buscarOsTabControl.ResumeLayout(false);
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osDataGridView)).EndInit();
            this.tabOrdemDeServico.ResumeLayout(false);
            this.tabOrdemDeServico.PerformLayout();
            this.produtoPecaTabControl.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            this.tabPecas.ResumeLayout(false);
            this.tabPecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pecaSolDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecaDispDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl buscarOsTabControl;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.DataGridView osDataGridView;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.Button pesquisarButton;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.TabPage tabOrdemDeServico;
        private System.Windows.Forms.TabControl produtoPecaTabControl;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.TabPage tabPecas;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ufTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox numeroSerialTextBox;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.TextBox descDefeitoTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button solicitarPecaButton;
        private System.Windows.Forms.DataGridView pecaSolDataGridView;
        private System.Windows.Forms.DataGridView pecaDispDataGridView;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox aparenciaTextBox;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Button novaOsButton;
        private System.Windows.Forms.Button confAlterarButton;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button alterarOsButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numeroTextBox;
    }
}