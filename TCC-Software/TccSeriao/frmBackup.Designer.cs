namespace TccSeriao
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioBak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSenhaBak = new System.Windows.Forms.TextBox();
            this.cbbBancoDados = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocalPatch = new System.Windows.Forms.TextBox();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnLocalPatch = new System.Windows.Forms.Button();
            this.groupBackup = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.groupRestauracao = new System.Windows.Forms.GroupBox();
            this.groupBackup.SuspendLayout();
            this.groupRestauracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor ";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(62, 40);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(318, 20);
            this.txtServidor.TabIndex = 1;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(393, 37);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 2;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(393, 72);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(75, 23);
            this.btnDesconectar.TabIndex = 3;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario";
            // 
            // txtUsuarioBak
            // 
            this.txtUsuarioBak.Location = new System.Drawing.Point(62, 75);
            this.txtUsuarioBak.Name = "txtUsuarioBak";
            this.txtUsuarioBak.Size = new System.Drawing.Size(132, 20);
            this.txtUsuarioBak.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "SQL Server Autentificação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selecione o Banco de Dados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Servidor ";
            // 
            // txtSenhaBak
            // 
            this.txtSenhaBak.Location = new System.Drawing.Point(244, 77);
            this.txtSenhaBak.Name = "txtSenhaBak";
            this.txtSenhaBak.PasswordChar = '*';
            this.txtSenhaBak.Size = new System.Drawing.Size(136, 20);
            this.txtSenhaBak.TabIndex = 11;
            // 
            // cbbBancoDados
            // 
            this.cbbBancoDados.FormattingEnabled = true;
            this.cbbBancoDados.Location = new System.Drawing.Point(63, 160);
            this.cbbBancoDados.Name = "cbbBancoDados";
            this.cbbBancoDados.Size = new System.Drawing.Size(241, 21);
            this.cbbBancoDados.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Backup Patch";
            // 
            // txtLocalPatch
            // 
            this.txtLocalPatch.Location = new System.Drawing.Point(95, 30);
            this.txtLocalPatch.Name = "txtLocalPatch";
            this.txtLocalPatch.Size = new System.Drawing.Size(285, 21);
            this.txtLocalPatch.TabIndex = 20;
            this.txtLocalPatch.TextChanged += new System.EventHandler(this.txtLocalPatch_TextChanged);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(393, 54);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(75, 23);
            this.btnRestaurar.TabIndex = 22;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnLocalPatch
            // 
            this.btnLocalPatch.Location = new System.Drawing.Point(393, 25);
            this.btnLocalPatch.Name = "btnLocalPatch";
            this.btnLocalPatch.Size = new System.Drawing.Size(75, 23);
            this.btnLocalPatch.TabIndex = 21;
            this.btnLocalPatch.Text = "Browse";
            this.btnLocalPatch.UseVisualStyleBackColor = true;
            this.btnLocalPatch.Click += new System.EventHandler(this.btnLocalPatch_Click);
            // 
            // groupBackup
            // 
            this.groupBackup.Controls.Add(this.label11);
            this.groupBackup.Controls.Add(this.txtLocal);
            this.groupBackup.Controls.Add(this.btnBackup);
            this.groupBackup.Controls.Add(this.btnLocal);
            this.groupBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBackup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBackup.Location = new System.Drawing.Point(0, 204);
            this.groupBackup.Name = "groupBackup";
            this.groupBackup.Size = new System.Drawing.Size(494, 100);
            this.groupBackup.TabIndex = 23;
            this.groupBackup.TabStop = false;
            this.groupBackup.Text = "Banco de Dados Backup";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(46, 26);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(334, 21);
            this.txtLocal.TabIndex = 2;
            this.txtLocal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(393, 53);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click_1);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(393, 24);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(75, 23);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Browse";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click_1);
            // 
            // groupRestauracao
            // 
            this.groupRestauracao.Controls.Add(this.txtLocalPatch);
            this.groupRestauracao.Controls.Add(this.label10);
            this.groupRestauracao.Controls.Add(this.btnRestaurar);
            this.groupRestauracao.Controls.Add(this.btnLocalPatch);
            this.groupRestauracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRestauracao.Location = new System.Drawing.Point(0, 290);
            this.groupRestauracao.Name = "groupRestauracao";
            this.groupRestauracao.Size = new System.Drawing.Size(494, 120);
            this.groupRestauracao.TabIndex = 24;
            this.groupRestauracao.TabStop = false;
            this.groupRestauracao.Text = "Banco de Dados Restauração";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 374);
            this.Controls.Add(this.groupRestauracao);
            this.Controls.Add(this.groupBackup);
            this.Controls.Add(this.cbbBancoDados);
            this.Controls.Add(this.txtSenhaBak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsuarioBak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackup";
            this.Text = "SQL Server Backup e Restauração";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.groupBackup.ResumeLayout(false);
            this.groupBackup.PerformLayout();
            this.groupRestauracao.ResumeLayout(false);
            this.groupRestauracao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioBak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSenhaBak;
        private System.Windows.Forms.ComboBox cbbBancoDados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLocalPatch;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnLocalPatch;
        private System.Windows.Forms.GroupBox groupBackup;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.GroupBox groupRestauracao;
    }
}