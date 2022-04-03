namespace TccSeriao
{
    partial class frmManual3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManual3));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvançar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 165);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 120);
            this.label4.TabIndex = 14;
            this.label4.Text = "1 - Para Gerar um Relatorio de Vendas, Basta Informar a Data Desejada e Apertar o" +
    " Botão Pesquisar\r\n \r\n";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(249, 419);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "<<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvançar
            // 
            this.btnAvançar.Location = new System.Drawing.Point(365, 419);
            this.btnAvançar.Name = "btnAvançar";
            this.btnAvançar.Size = new System.Drawing.Size(75, 23);
            this.btnAvançar.TabIndex = 19;
            this.btnAvançar.Text = ">>";
            this.btnAvançar.UseVisualStyleBackColor = true;
            this.btnAvançar.Click += new System.EventHandler(this.btnAvançar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::TccSeriao.Properties.Resources.Formulario_vendas1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(403, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 204);
            this.label1.TabIndex = 12;
            this.label1.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::TccSeriao.Properties.Resources.Vendas;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 212);
            this.label3.TabIndex = 11;
            this.label3.Text = "\r\n";
            // 
            // frmManual3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 449);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAvançar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManual3";
            this.Text = "Manual Do Usuario  ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvançar;
    }
}