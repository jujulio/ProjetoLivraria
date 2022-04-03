namespace TccSeriao
{
    partial class frmVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.gridCarregar = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gridVenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridCarregar
            // 
            this.gridCarregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCarregar.Location = new System.Drawing.Point(12, 73);
            this.gridCarregar.Name = "gridCarregar";
            this.gridCarregar.Size = new System.Drawing.Size(826, 125);
            this.gridCarregar.TabIndex = 2;
            this.gridCarregar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCarregar_CellContentClick);
            this.gridCarregar.SelectionChanged += new System.EventHandler(this.gridVendas_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Produto ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Total ";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(10, 61);
            this.txtValorTotal.Multiline = true;
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(98, 38);
            this.txtValorTotal.TabIndex = 7;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::TccSeriao.Properties.Resources._1490129321_rounded10_82180;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(445, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 43);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "          Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Image = global::TccSeriao.Properties.Resources.Sem_título;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(641, 61);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(158, 43);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::TccSeriao.Properties.Resources.button_add_insert_new_14983;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(745, 20);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(93, 43);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "         Inserir ";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // gridVenda
            // 
            this.gridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenda.Location = new System.Drawing.Point(12, 217);
            this.gridVenda.Name = "gridVenda";
            this.gridVenda.Size = new System.Drawing.Size(826, 125);
            this.gridVenda.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Valor Recebido ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Troco ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTroco);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValorRecebido);
            this.groupBox1.Controls.Add(this.btnComprar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Location = new System.Drawing.Point(15, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 110);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fluxo de Caixa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.Location = new System.Drawing.Point(334, 61);
            this.txtTroco.Multiline = true;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(98, 38);
            this.txtTroco.TabIndex = 18;
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecebido.Location = new System.Drawing.Point(172, 61);
            this.txtValorRecebido.Multiline = true;
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(98, 38);
            this.txtValorRecebido.TabIndex = 17;
            this.txtValorRecebido.TextChanged += new System.EventHandler(this.txtValorRecebido_TextChanged);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridVenda);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridCarregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView gridVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtValorRecebido;
    }
}