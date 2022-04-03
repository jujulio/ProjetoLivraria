namespace TccSeriao
{
    partial class frmConectar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConectar));
            this.txtServidorBanco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserServ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenhaServ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbBancos = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServidorBanco
            // 
            this.txtServidorBanco.Location = new System.Drawing.Point(88, 32);
            this.txtServidorBanco.Name = "txtServidorBanco";
            this.txtServidorBanco.Size = new System.Drawing.Size(317, 20);
            this.txtServidorBanco.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // txtConectar
            // 
            this.txtConectar.Location = new System.Drawing.Point(448, 89);
            this.txtConectar.Name = "txtConectar";
            this.txtConectar.Size = new System.Drawing.Size(75, 23);
            this.txtConectar.TabIndex = 2;
            this.txtConectar.Text = "Verificar";
            this.txtConectar.UseVisualStyleBackColor = true;
            this.txtConectar.Click += new System.EventHandler(this.btnConectarServ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // txtUserServ
            // 
            this.txtUserServ.Location = new System.Drawing.Point(88, 74);
            this.txtUserServ.Name = "txtUserServ";
            this.txtUserServ.Size = new System.Drawing.Size(122, 20);
            this.txtUserServ.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // txtSenhaServ
            // 
            this.txtSenhaServ.Location = new System.Drawing.Point(279, 75);
            this.txtSenhaServ.Name = "txtSenhaServ";
            this.txtSenhaServ.PasswordChar = '*';
            this.txtSenhaServ.Size = new System.Drawing.Size(126, 20);
            this.txtSenhaServ.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Banco de Dados";
            // 
            // cbbBancos
            // 
            this.cbbBancos.FormattingEnabled = true;
            this.cbbBancos.Location = new System.Drawing.Point(140, 118);
            this.cbbBancos.Name = "cbbBancos";
            this.cbbBancos.Size = new System.Drawing.Size(265, 21);
            this.cbbBancos.TabIndex = 9;
            this.cbbBancos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(448, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmConectar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 164);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbbBancos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaServ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserServ);
            this.Controls.Add(this.txtConectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServidorBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConectar";
            this.Text = "Conectar com o Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConectar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConectar_FormClosed);
            this.Load += new System.EventHandler(this.frmConectar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServidorBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserServ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenhaServ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbBancos;
        private System.Windows.Forms.Button btnSalvar;
    }
}