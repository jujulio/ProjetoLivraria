namespace TccSeriao
{
    partial class frmPainel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softBeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.servidorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fornecedoresToolStripMenuItem,
            this.pToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1});
            this.produtosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem.Image")));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.produtosToolStripMenuItem.Text = "Cadastros";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFornecedor});
            this.fornecedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresToolStripMenuItem.Image")));
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.fornecedoresToolStripMenuItem.Text = "Clientes/Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // cadastrarFornecedor
            // 
            this.cadastrarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarFornecedor.Image")));
            this.cadastrarFornecedor.Name = "cadastrarFornecedor";
            this.cadastrarFornecedor.Size = new System.Drawing.Size(180, 22);
            this.cadastrarFornecedor.Text = "Cadastrar";
            this.cadastrarFornecedor.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProduto});
            this.pToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pToolStripMenuItem.Image")));
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pToolStripMenuItem.Text = "Produtos";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // cadastrarProduto
            // 
            this.cadastrarProduto.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarProduto.Image")));
            this.cadastrarProduto.Name = "cadastrarProduto";
            this.cadastrarProduto.Size = new System.Drawing.Size(180, 22);
            this.cadastrarProduto.Text = "Cadastrar";
            this.cadastrarProduto.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem2,
            this.relatorioToolStripMenuItem});
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem3.Text = "Vendas";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // exibirToolStripMenuItem2
            // 
            this.exibirToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("exibirToolStripMenuItem2.Image")));
            this.exibirToolStripMenuItem2.Name = "exibirToolStripMenuItem2";
            this.exibirToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.exibirToolStripMenuItem2.Text = "Caixa";
            this.exibirToolStripMenuItem2.Click += new System.EventHandler(this.exibirToolStripMenuItem2_Click_1);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatorioToolStripMenuItem.Image")));
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            this.relatorioToolStripMenuItem.Click += new System.EventHandler(this.relatorioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softBeansToolStripMenuItem,
            this.manualDoUsuárioToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // softBeansToolStripMenuItem
            // 
            this.softBeansToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("softBeansToolStripMenuItem.Image")));
            this.softBeansToolStripMenuItem.Name = "softBeansToolStripMenuItem";
            this.softBeansToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.softBeansToolStripMenuItem.Text = "SoftBeans";
            this.softBeansToolStripMenuItem.Click += new System.EventHandler(this.softBeansToolStripMenuItem_Click);
            // 
            // manualDoUsuárioToolStripMenuItem
            // 
            this.manualDoUsuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualDoUsuárioToolStripMenuItem.Image")));
            this.manualDoUsuárioToolStripMenuItem.Name = "manualDoUsuárioToolStripMenuItem";
            this.manualDoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualDoUsuárioToolStripMenuItem.Text = "Manual do Usuário";
            this.manualDoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.manualDoUsuárioToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backupToolStripMenuItem.Image")));
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // servidorToolStripMenuItem
            // 
            this.servidorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("servidorToolStripMenuItem.Image")));
            this.servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            this.servidorToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.servidorToolStripMenuItem.Text = "Servidor";
            this.servidorToolStripMenuItem.Click += new System.EventHandler(this.servidorToolStripMenuItem_Click);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(443, 4);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(38, 20);
            this.lbHora.TabIndex = 3;
            this.lbHora.Text = "Hora";
            this.lbHora.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TccSeriao.Properties.Resources.livros;
            this.ClientSize = new System.Drawing.Size(518, 454);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frmPainel";
            this.Text = "Gerenciamento de Produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPainel_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFornecedor;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softBeansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem servidorToolStripMenuItem;
    }
}

