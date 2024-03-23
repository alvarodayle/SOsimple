namespace Empresa.UI.Windows
{
    partial class ClienteIncluirForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefoneLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.incluirButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(34, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 16);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id:";
            this.idLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(34, 70);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(47, 16);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome:";
            this.nomeLabel.UseWaitCursor = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(34, 110);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 16);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // telefoneLabel
            // 
            this.telefoneLabel.AutoSize = true;
            this.telefoneLabel.Location = new System.Drawing.Point(34, 153);
            this.telefoneLabel.Name = "telefoneLabel";
            this.telefoneLabel.Size = new System.Drawing.Size(64, 16);
            this.telefoneLabel.TabIndex = 3;
            this.telefoneLabel.Text = "Telefone:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(104, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 4;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(104, 150);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(365, 22);
            this.telefoneTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(104, 107);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(365, 22);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(104, 67);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(365, 22);
            this.nomeTextBox.TabIndex = 7;
            // 
            // incluirButton
            // 
            this.incluirButton.Location = new System.Drawing.Point(237, 215);
            this.incluirButton.Name = "incluirButton";
            this.incluirButton.Size = new System.Drawing.Size(113, 35);
            this.incluirButton.TabIndex = 8;
            this.incluirButton.Text = "Incluir";
            this.incluirButton.UseVisualStyleBackColor = true;
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(356, 215);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(113, 35);
            this.voltarButton.TabIndex = 9;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteIncluirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 265);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.incluirButton);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.telefoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.idLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteIncluirForm";
            this.Text = "Inclusão de Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telefoneLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button incluirButton;
        private System.Windows.Forms.Button voltarButton;
    }
}