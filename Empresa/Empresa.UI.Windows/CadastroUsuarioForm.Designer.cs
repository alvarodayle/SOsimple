namespace Empresa.UI.Windows
{
    partial class CadastroUsuarioForm
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.departamentoLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.nomeCadastroTextBox = new System.Windows.Forms.TextBox();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.confirmarCadastroButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.confirSenhaTextBox = new System.Windows.Forms.TextBox();
            this.confirSenhaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(20, 31);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(47, 16);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome:";
            // 
            // departamentoLabel
            // 
            this.departamentoLabel.AutoSize = true;
            this.departamentoLabel.Location = new System.Drawing.Point(20, 75);
            this.departamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departamentoLabel.Name = "departamentoLabel";
            this.departamentoLabel.Size = new System.Drawing.Size(96, 16);
            this.departamentoLabel.TabIndex = 1;
            this.departamentoLabel.Text = "Departamento:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(23, 118);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(43, 16);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(23, 166);
            this.senhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(49, 16);
            this.senhaLabel.TabIndex = 3;
            this.senhaLabel.Text = "Senha:";
            // 
            // nomeCadastroTextBox
            // 
            this.nomeCadastroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeCadastroTextBox.Location = new System.Drawing.Point(145, 27);
            this.nomeCadastroTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeCadastroTextBox.Name = "nomeCadastroTextBox";
            this.nomeCadastroTextBox.Size = new System.Drawing.Size(364, 22);
            this.nomeCadastroTextBox.TabIndex = 1;
            // 
            // deptTextBox
            // 
            this.deptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deptTextBox.Location = new System.Drawing.Point(145, 71);
            this.deptTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(364, 22);
            this.deptTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTextBox.Location = new System.Drawing.Point(145, 114);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(364, 22);
            this.loginTextBox.TabIndex = 3;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaTextBox.Location = new System.Drawing.Point(145, 162);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(364, 22);
            this.senhaTextBox.TabIndex = 4;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // confirmarCadastroButton
            // 
            this.confirmarCadastroButton.Location = new System.Drawing.Point(232, 274);
            this.confirmarCadastroButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmarCadastroButton.Name = "confirmarCadastroButton";
            this.confirmarCadastroButton.Size = new System.Drawing.Size(128, 34);
            this.confirmarCadastroButton.TabIndex = 8;
            this.confirmarCadastroButton.Text = "Cadastrar";
            this.confirmarCadastroButton.UseVisualStyleBackColor = true;
            this.confirmarCadastroButton.Click += new System.EventHandler(this.confirmarCadastroButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(368, 274);
            this.voltarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(128, 34);
            this.voltarButton.TabIndex = 9;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // confirSenhaTextBox
            // 
            this.confirSenhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirSenhaTextBox.Location = new System.Drawing.Point(145, 215);
            this.confirSenhaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirSenhaTextBox.Name = "confirSenhaTextBox";
            this.confirSenhaTextBox.Size = new System.Drawing.Size(364, 22);
            this.confirSenhaTextBox.TabIndex = 5;
            this.confirSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // confirSenhaLabel
            // 
            this.confirSenhaLabel.AutoSize = true;
            this.confirSenhaLabel.Location = new System.Drawing.Point(20, 219);
            this.confirSenhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirSenhaLabel.Name = "confirSenhaLabel";
            this.confirSenhaLabel.Size = new System.Drawing.Size(109, 16);
            this.confirSenhaLabel.TabIndex = 11;
            this.confirSenhaLabel.Text = "Confirmar Senha:";
            // 
            // CadastroUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 324);
            this.Controls.Add(this.confirSenhaLabel);
            this.Controls.Add(this.confirSenhaTextBox);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.confirmarCadastroButton);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.nomeCadastroTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.departamentoLabel);
            this.Controls.Add(this.nomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroUsuarioForm";
            this.Text = "Cadastro de Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label departamentoLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox nomeCadastroTextBox;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button confirmarCadastroButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.TextBox confirSenhaTextBox;
        private System.Windows.Forms.Label confirSenhaLabel;
    }
}