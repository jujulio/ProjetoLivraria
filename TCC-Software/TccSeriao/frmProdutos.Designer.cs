namespace TccSeriao
{
    partial class frmProdutos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutos));
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnoPubli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbConservacao = new System.Windows.Forms.ComboBox();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.gridProduto = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDProduto = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(102, 52);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(121, 21);
            this.txtEditora.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Editora/Gravadora";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(398, 13);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(349, 21);
            this.txtTitulo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ano de Publicação";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAnoPubli
            // 
            this.txtAnoPubli.Location = new System.Drawing.Point(352, 50);
            this.txtAnoPubli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnoPubli.Name = "txtAnoPubli";
            this.txtAnoPubli.Size = new System.Drawing.Size(100, 21);
            this.txtAnoPubli.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Estado de Conservação";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Preço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Descrição";
            // 
            // cbbConservacao
            // 
            this.cbbConservacao.AutoCompleteCustomSource.AddRange(new string[] {
            "Novo",
            "Semi-Novo",
            "Usado"});
            this.cbbConservacao.FormattingEnabled = true;
            this.cbbConservacao.Items.AddRange(new object[] {
            "Novo",
            "Usado"});
            this.cbbConservacao.Location = new System.Drawing.Point(598, 47);
            this.cbbConservacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbConservacao.Name = "cbbConservacao";
            this.cbbConservacao.Size = new System.Drawing.Size(100, 24);
            this.cbbConservacao.TabIndex = 37;
            this.cbbConservacao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.AutoCompleteCustomSource.AddRange(new string[] {
            "Novo",
            "Semi-Novo",
            "Usado"});
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Items.AddRange(new object[] {
            "CDs",
            "DVDs",
            "Livros",
            "Disco"});
            this.cbbCategoria.Location = new System.Drawing.Point(226, 13);
            this.cbbCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbbCategoria.TabIndex = 38;
            this.cbbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbbCategoria_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(69, 154);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(57, 21);
            this.txtQuantidade.TabIndex = 43;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(69, 126);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(57, 21);
            this.txtPreco.TabIndex = 40;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // gridProduto
            // 
            this.gridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduto.Location = new System.Drawing.Point(7, 245);
            this.gridProduto.Name = "gridProduto";
            this.gridProduto.Size = new System.Drawing.Size(924, 211);
            this.gridProduto.TabIndex = 44;
            this.gridProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduto_CellContentClick);
            this.gridProduto.SelectionChanged += new System.EventHandler(this.gridProduto_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "ID Produto";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Location = new System.Drawing.Point(60, 19);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(66, 21);
            this.txtIDProduto.TabIndex = 46;
            this.txtIDProduto.TextChanged += new System.EventHandler(this.txtIDProduto_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(180, 95);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(477, 89);
            this.txtDescricao.TabIndex = 50;
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Image = global::TccSeriao.Properties.Resources.novo2;
            this.btnAlterarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarProduto.Location = new System.Drawing.Point(684, 131);
            this.btnAlterarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(70, 33);
            this.btnAlterarProduto.TabIndex = 48;
            this.btnAlterarProduto.Text = "    Alterar";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Image = global::TccSeriao.Properties.Resources.download4;
            this.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirProduto.Location = new System.Drawing.Point(773, 131);
            this.btnExcluirProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(70, 33);
            this.btnExcluirProduto.TabIndex = 47;
            this.btnExcluirProduto.Text = "      Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.Image = global::TccSeriao.Properties.Resources.salvar;
            this.btnSalvarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarProduto.Location = new System.Drawing.Point(773, 90);
            this.btnSalvarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(70, 33);
            this.btnSalvarProduto.TabIndex = 27;
            this.btnSalvarProduto.Text = "       Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = true;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Image = global::TccSeriao.Properties.Resources.novo2;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.Location = new System.Drawing.Point(687, 90);
            this.btnNovoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(70, 33);
            this.btnNovoProduto.TabIndex = 26;
            this.btnNovoProduto.Text = "     Novo";
            this.btnNovoProduto.UseVisualStyleBackColor = true;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(137, 211);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(289, 21);
            this.txtPesquisar.TabIndex = 52;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::TccSeriao.Properties.Resources._1490129321_rounded10_82180;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(432, 206);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 33);
            this.btnPesquisar.TabIndex = 51;
            this.btnPesquisar.Text = "          Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 53;
            this.label10.Text = "Nome do Produto ";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 468);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gridProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.cbbConservacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnoPubli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvarProduto);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProdutos";
            this.Text = "Cadastrar Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnSalvarProduto;
        private System.Windows.Forms.DataGridView gridProduto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnAlterarProduto;
        public System.Windows.Forms.TextBox txtEditora;
        public System.Windows.Forms.TextBox txtTitulo;
        public System.Windows.Forms.TextBox txtAnoPubli;
        public System.Windows.Forms.ComboBox cbbConservacao;
        public System.Windows.Forms.ComboBox cbbCategoria;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.TextBox txtIDProduto;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label10;
    }
}