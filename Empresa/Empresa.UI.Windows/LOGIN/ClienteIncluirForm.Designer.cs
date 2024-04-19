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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteIncluirForm));
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(118, 196);
            this.telefoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(224, 20);
            this.telefoneTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(118, 157);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(57, 237);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(85, 28);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(257, 237);
            this.sairButton.Margin = new System.Windows.Forms.Padding(2);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(85, 28);
            this.sairButton.TabIndex = 5;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.Location = new System.Drawing.Point(160, 237);
            this.cadastrarButton.Margin = new System.Windows.Forms.Padding(2);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(85, 28);
            this.cadastrarButton.TabIndex = 4;
            this.cadastrarButton.Text = "Cadastrar";
            this.cadastrarButton.UseVisualStyleBackColor = true;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(67, 160);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(46, 13);
            this.usuarioLabel.TabIndex = 11;
            this.usuarioLabel.Text = "Usuário:";
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(67, 199);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(41, 13);
            this.senhaLabel.TabIndex = 12;
            this.senhaLabel.Text = "Senha:";
            // 
            // ClienteIncluirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 279);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.cadastrarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefoneTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteIncluirForm";
            this.Text = "SoSimple - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cadastrarButton;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label senhaLabel;
    }
}