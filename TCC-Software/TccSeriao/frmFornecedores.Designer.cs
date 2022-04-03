namespace TccSeriao
{
    partial class frmFornecedoresCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedoresCadastrar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.cbbFornecedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcnpjFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcpfFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.gridFornecedor = new System.Windows.Forms.DataGridView();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.btnAlterarFornecedor = new System.Windows.Forms.Button();
            this.btnSalvarFornecedor = new System.Windows.Forms.Button();
            this.btnNovoFornecedor = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Fornecedor";
            // 
            // txtIDFornecedor
            // 
            this.txtIDFornecedor.Enabled = false;
            this.txtIDFornecedor.Location = new System.Drawing.Point(93, 15);
            this.txtIDFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDFornecedor.Name = "txtIDFornecedor";
            this.txtIDFornecedor.Size = new System.Drawing.Size(65, 21);
            this.txtIDFornecedor.TabIndex = 1;
            this.txtIDFornecedor.TextChanged += new System.EventHandler(this.txtIDFornecedor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(244, 15);
            this.txtNomeFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(220, 21);
            this.txtNomeFornecedor.TabIndex = 3;
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(67, 59);
            this.txtTelefoneFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefoneFornecedor.Mask = "(999) 00000-0000";
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(100, 21);
            this.txtTelefoneFornecedor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail";
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Location = new System.Drawing.Point(244, 62);
            this.txtEmailFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(220, 21);
            this.txtEmailFornecedor.TabIndex = 7;
            // 
            // cbbFornecedor
            // 
            this.cbbFornecedor.FormattingEnabled = true;
            this.cbbFornecedor.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbbFornecedor.Location = new System.Drawing.Point(67, 121);
            this.cbbFornecedor.Name = "cbbFornecedor";
            this.cbbFornecedor.Size = new System.Drawing.Size(80, 24);
            this.cbbFornecedor.TabIndex = 12;
            this.cbbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbbFornecedor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pessoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "CNPJ";
            // 
            // txtcnpjFornecedor
            // 
            this.txtcnpjFornecedor.Location = new System.Drawing.Point(232, 124);
            this.txtcnpjFornecedor.Mask = "00000000/0000";
            this.txtcnpjFornecedor.Name = "txtcnpjFornecedor";
            this.txtcnpjFornecedor.Size = new System.Drawing.Size(70, 21);
            this.txtcnpjFornecedor.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "CPF";
            // 
            // txtcpfFornecedor
            // 
            this.txtcpfFornecedor.Location = new System.Drawing.Point(232, 157);
            this.txtcpfFornecedor.Mask = "000-000-000-00";
            this.txtcpfFornecedor.Name = "txtcpfFornecedor";
            this.txtcpfFornecedor.Size = new System.Drawing.Size(70, 21);
            this.txtcpfFornecedor.TabIndex = 17;
            // 
            // gridFornecedor
            // 
            this.gridFornecedor.AllowUserToAddRows = false;
            this.gridFornecedor.AllowUserToDeleteRows = false;
            this.gridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFornecedor.Location = new System.Drawing.Point(10, 247);
            this.gridFornecedor.Name = "gridFornecedor";
            this.gridFornecedor.ReadOnly = true;
            this.gridFornecedor.Size = new System.Drawing.Size(751, 216);
            this.gridFornecedor.TabIndex = 18;
            this.gridFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFornecedor_CellContentClick);
            this.gridFornecedor.SelectionChanged += new System.EventHandler(this.gridFornecedor_SelectionChanged);
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.Image = global::TccSeriao.Properties.Resources.download3;
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(613, 82);
            this.btnExcluirFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(70, 33);
            this.btnExcluirFornecedor.TabIndex = 20;
            this.btnExcluirFornecedor.Text = "Excluir";
            this.btnExcluirFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirFornecedor.UseVisualStyleBackColor = true;
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // btnAlterarFornecedor
            // 
            this.btnAlterarFornecedor.Image = global::TccSeriao.Properties.Resources.novo2;
            this.btnAlterarFornecedor.Location = new System.Drawing.Point(521, 82);
            this.btnAlterarFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarFornecedor.Name = "btnAlterarFornecedor";
            this.btnAlterarFornecedor.Size = new System.Drawing.Size(70, 33);
            this.btnAlterarFornecedor.TabIndex = 19;
            this.btnAlterarFornecedor.Text = "Alterar";
            this.btnAlterarFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarFornecedor.UseVisualStyleBackColor = true;
            this.btnAlterarFornecedor.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvarFornecedor
            // 
            this.btnSalvarFornecedor.Image = global::TccSeriao.Properties.Resources.salvar;
            this.btnSalvarFornecedor.Location = new System.Drawing.Point(613, 18);
            this.btnSalvarFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarFornecedor.Name = "btnSalvarFornecedor";
            this.btnSalvarFornecedor.Size = new System.Drawing.Size(70, 33);
            this.btnSalvarFornecedor.TabIndex = 11;
            this.btnSalvarFornecedor.Text = "Salvar";
            this.btnSalvarFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvarFornecedor.UseVisualStyleBackColor = true;
            this.btnSalvarFornecedor.Click += new System.EventHandler(this.btnSalvarFornecedor_Click);
            // 
            // btnNovoFornecedor
            // 
            this.btnNovoFornecedor.Image = global::TccSeriao.Properties.Resources.novo2;
            this.btnNovoFornecedor.Location = new System.Drawing.Point(521, 18);
            this.btnNovoFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovoFornecedor.Name = "btnNovoFornecedor";
            this.btnNovoFornecedor.Size = new System.Drawing.Size(70, 33);
            this.btnNovoFornecedor.TabIndex = 8;
            this.btnNovoFornecedor.Text = "Novo";
            this.btnNovoFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoFornecedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoFornecedor.UseVisualStyleBackColor = true;
            this.btnNovoFornecedor.Click += new System.EventHandler(this.btnNovoFornecedor_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::TccSeriao.Properties.Resources._1490129321_rounded10_82180;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(448, 208);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 33);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "          Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(153, 213);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(289, 21);
            this.txtPesquisar.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nome do Fornecedor";
            // 
            // frmFornecedoresCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 482);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluirFornecedor);
            this.Controls.Add(this.btnAlterarFornecedor);
            this.Controls.Add(this.gridFornecedor);
            this.Controls.Add(this.txtcpfFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcnpjFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbFornecedor);
            this.Controls.Add(this.btnSalvarFornecedor);
            this.Controls.Add(this.btnNovoFornecedor);
            this.Controls.Add(this.txtEmailFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefoneFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDFornecedor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFornecedoresCadastrar";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmFornecedoresCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailFornecedor;
        private System.Windows.Forms.Button btnNovoFornecedor;
        private System.Windows.Forms.ComboBox cbbFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtcnpjFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcpfFornecedor;
        public System.Windows.Forms.Button btnSalvarFornecedor;
        private System.Windows.Forms.DataGridView gridFornecedor;
        private System.Windows.Forms.Button btnAlterarFornecedor;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label8;
    }
}