namespace Empresa.UI.Windows
{
    partial class NovoOsForm
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
            this.numOsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeClienteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aparenciaTextBox = new System.Windows.Forms.TextBox();
            this.numSerieTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numOsTextBox
            // 
            this.numOsTextBox.Location = new System.Drawing.Point(170, 27);
            this.numOsTextBox.Name = "numOsTextBox";
            this.numOsTextBox.ReadOnly = true;
            this.numOsTextBox.Size = new System.Drawing.Size(114, 22);
            this.numOsTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número da Os";
            // 
            // nomeClienteTextBox
            // 
            this.nomeClienteTextBox.Location = new System.Drawing.Point(170, 70);
            this.nomeClienteTextBox.Name = "nomeClienteTextBox";
            this.nomeClienteTextBox.Size = new System.Drawing.Size(518, 22);
            this.nomeClienteTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aparência do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de Serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Descrição do Defeito";
            // 
            // aparenciaTextBox
            // 
            this.aparenciaTextBox.Location = new System.Drawing.Point(170, 114);
            this.aparenciaTextBox.Name = "aparenciaTextBox";
            this.aparenciaTextBox.Size = new System.Drawing.Size(518, 22);
            this.aparenciaTextBox.TabIndex = 3;
            // 
            // numSerieTextBox
            // 
            this.numSerieTextBox.Location = new System.Drawing.Point(170, 157);
            this.numSerieTextBox.Name = "numSerieTextBox";
            this.numSerieTextBox.Size = new System.Drawing.Size(518, 22);
            this.numSerieTextBox.TabIndex = 4;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(170, 204);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(518, 119);
            this.descTextBox.TabIndex = 5;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(29, 405);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(186, 24);
            this.statusComboBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status da Os";
            // 
            // confirmarButton
            // 
            this.confirmarButton.Location = new System.Drawing.Point(526, 392);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(161, 63);
            this.confirmarButton.TabIndex = 7;
            this.confirmarButton.Text = "Confirmar";
            this.confirmarButton.UseVisualStyleBackColor = true;
            // 
            // NovoOsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 467);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.numSerieTextBox);
            this.Controls.Add(this.aparenciaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeClienteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOsTextBox);
            this.MaximizeBox = false;
            this.Name = "NovoOsForm";
            this.Text = "Criar Nova Os";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numOsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeClienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aparenciaTextBox;
        private System.Windows.Forms.TextBox numSerieTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button confirmarButton;
    }
}