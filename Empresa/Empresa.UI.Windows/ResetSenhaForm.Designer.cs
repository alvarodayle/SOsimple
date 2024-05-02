namespace Empresa.UI.Windows
{
    partial class ResetSenhaForm
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
            this.novaSenhaLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.novaSenhaTextBox = new System.Windows.Forms.TextBox();
            this.confirmarSenhaTextBox = new System.Windows.Forms.TextBox();
            this.confirmarCadastroButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.erroCadastroLabel = new System.Windows.Forms.Label();
            this.loginResetTextBox = new System.Windows.Forms.TextBox();
            this.loginResetLabel = new System.Windows.Forms.Label();
            this.senhaAtualLabel = new System.Windows.Forms.Label();
            this.senhaAtualTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // novaSenhaLabel
            // 
            this.novaSenhaLabel.AutoSize = true;
            this.novaSenhaLabel.Location = new System.Drawing.Point(24, 117);
            this.novaSenhaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.novaSenhaLabel.Name = "novaSenhaLabel";
            this.novaSenhaLabel.Size = new System.Drawing.Size(85, 16);
            this.novaSenhaLabel.TabIndex = 1;
            this.novaSenhaLabel.Text = "Nova Senha:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(24, 162);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(109, 16);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Confirmar Senha:";
            // 
            // novaSenhaTextBox
            // 
            this.novaSenhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.novaSenhaTextBox.Location = new System.Drawing.Point(149, 111);
            this.novaSenhaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.novaSenhaTextBox.Name = "novaSenhaTextBox";
            this.novaSenhaTextBox.Size = new System.Drawing.Size(184, 22);
            this.novaSenhaTextBox.TabIndex = 3;
            this.novaSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // confirmarSenhaTextBox
            // 
            this.confirmarSenhaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmarSenhaTextBox.Location = new System.Drawing.Point(149, 156);
            this.confirmarSenhaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmarSenhaTextBox.Name = "confirmarSenhaTextBox";
            this.confirmarSenhaTextBox.Size = new System.Drawing.Size(184, 22);
            this.confirmarSenhaTextBox.TabIndex = 4;
            this.confirmarSenhaTextBox.UseSystemPasswordChar = true;
            // 
            // confirmarCadastroButton
            // 
            this.confirmarCadastroButton.Location = new System.Drawing.Point(114, 298);
            this.confirmarCadastroButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmarCadastroButton.Name = "confirmarCadastroButton";
            this.confirmarCadastroButton.Size = new System.Drawing.Size(106, 34);
            this.confirmarCadastroButton.TabIndex = 5;
            this.confirmarCadastroButton.Text = "Confirmar";
            this.confirmarCadastroButton.UseVisualStyleBackColor = true;
            this.confirmarCadastroButton.Click += new System.EventHandler(this.confirmarCadastroButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(228, 298);
            this.voltarButton.Margin = new System.Windows.Forms.Padding(4);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(105, 34);
            this.voltarButton.TabIndex = 6;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // erroCadastroLabel
            // 
            this.erroCadastroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroCadastroLabel.ForeColor = System.Drawing.Color.Red;
            this.erroCadastroLabel.Location = new System.Drawing.Point(24, 194);
            this.erroCadastroLabel.Name = "erroCadastroLabel";
            this.erroCadastroLabel.Size = new System.Drawing.Size(309, 91);
            this.erroCadastroLabel.TabIndex = 12;
            this.erroCadastroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginResetTextBox
            // 
            this.loginResetTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginResetTextBox.Location = new System.Drawing.Point(149, 24);
            this.loginResetTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginResetTextBox.Name = "loginResetTextBox";
            this.loginResetTextBox.Size = new System.Drawing.Size(184, 22);
            this.loginResetTextBox.TabIndex = 1;
            // 
            // loginResetLabel
            // 
            this.loginResetLabel.AutoSize = true;
            this.loginResetLabel.Location = new System.Drawing.Point(24, 26);
            this.loginResetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginResetLabel.Name = "loginResetLabel";
            this.loginResetLabel.Size = new System.Drawing.Size(43, 16);
            this.loginResetLabel.TabIndex = 13;
            this.loginResetLabel.Text = "Login:";
            // 
            // senhaAtualLabel
            // 
            this.senhaAtualLabel.AutoSize = true;
            this.senhaAtualLabel.Location = new System.Drawing.Point(24, 75);
            this.senhaAtualLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.senhaAtualLabel.Name = "senhaAtualLabel";
            this.senhaAtualLabel.Size = new System.Drawing.Size(82, 16);
            this.senhaAtualLabel.TabIndex = 0;
            this.senhaAtualLabel.Text = "Senha Atual:";
            // 
            // senhaAtualTextBox
            // 
            this.senhaAtualTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaAtualTextBox.Location = new System.Drawing.Point(149, 69);
            this.senhaAtualTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.senhaAtualTextBox.Name = "senhaAtualTextBox";
            this.senhaAtualTextBox.Size = new System.Drawing.Size(184, 22);
            this.senhaAtualTextBox.TabIndex = 2;
            this.senhaAtualTextBox.UseSystemPasswordChar = true;
            // 
            // ResetSenhaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 345);
            this.Controls.Add(this.loginResetTextBox);
            this.Controls.Add(this.loginResetLabel);
            this.Controls.Add(this.erroCadastroLabel);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.confirmarCadastroButton);
            this.Controls.Add(this.confirmarSenhaTextBox);
            this.Controls.Add(this.novaSenhaTextBox);
            this.Controls.Add(this.senhaAtualTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.novaSenhaLabel);
            this.Controls.Add(this.senhaAtualLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetSenhaForm";
            this.Text = "Reset de Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label novaSenhaLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox novaSenhaTextBox;
        private System.Windows.Forms.TextBox confirmarSenhaTextBox;
        private System.Windows.Forms.Button confirmarCadastroButton;
        private System.Windows.Forms.Button voltarButton;
        private System.Windows.Forms.Label erroCadastroLabel;
        private System.Windows.Forms.TextBox loginResetTextBox;
        private System.Windows.Forms.Label loginResetLabel;
        private System.Windows.Forms.Label senhaAtualLabel;
        private System.Windows.Forms.TextBox senhaAtualTextBox;
    }
}