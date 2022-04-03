namespace TccSeriao
{
    partial class frmRelatorioVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioVenda));
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRelatorio = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(135, 30);
            this.txtDataVenda.Mask = "00/00/0000";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(100, 20);
            this.txtDataVenda.TabIndex = 0;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data da Venda";
            // 
            // gridRelatorio
            // 
            this.gridRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelatorio.Location = new System.Drawing.Point(12, 78);
            this.gridRelatorio.Name = "gridRelatorio";
            this.gridRelatorio.Size = new System.Drawing.Size(440, 389);
            this.gridRelatorio.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::TccSeriao.Properties.Resources._1490129321_rounded10_82180;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(250, 26);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 26);
            this.btnPesquisar.TabIndex = 52;
            this.btnPesquisar.Text = "          Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 479);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gridRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDataVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioVenda";
            this.Text = "frmRelatorioVenda";
            this.Load += new System.EventHandler(this.frmRelatorioVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridRelatorio;
        private System.Windows.Forms.Button btnPesquisar;
    }
}