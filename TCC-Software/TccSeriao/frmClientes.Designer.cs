namespace TccSeriao
{
    partial class frmClientes
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
            this.btnSalvarCliente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvarCliente
            // 
            this.btnSalvarCliente.Location = new System.Drawing.Point(599, 33);
            this.btnSalvarCliente.Name = "btnSalvarCliente";
            this.btnSalvarCliente.Size = new System.Drawing.Size(70, 27);
            this.btnSalvarCliente.TabIndex = 27;
            this.btnSalvarCliente.Text = "Salvar";
            this.btnSalvarCliente.UseVisualStyleBackColor = true;
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(523, 33);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(70, 27);
            this.btnNovoCliente.TabIndex = 24;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(279, 54);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(220, 20);
            this.txtEmailCliente.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "E-mail";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(88, 54);
            this.txtTelefoneCliente.Mask = "(999) 00000-0000";
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTelefoneCliente.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefone";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(279, 16);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(220, 20);
            this.txtNomeCliente.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome do Cliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(66, 16);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Cliente";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 100);
            this.Controls.Add(this.btnSalvarCliente);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "Cadastro de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvarCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label1;
    }
}