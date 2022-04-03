namespace TccSeriao
{
    partial class frmManual1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvançar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(730, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 94);
            this.label3.TabIndex = 10;
            this.label3.Text = "1 - Selecione a Opção que Deseja usar";
            // 
            // label2
            // 
            this.label2.Image = global::TccSeriao.Properties.Resources.painel_2;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(371, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 241);
            this.label2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Image = global::TccSeriao.Properties.Resources.Painel;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 241);
            this.label1.TabIndex = 8;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(346, 283);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Text = "<<";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvançar
            // 
            this.btnAvançar.Location = new System.Drawing.Point(462, 283);
            this.btnAvançar.Name = "btnAvançar";
            this.btnAvançar.Size = new System.Drawing.Size(75, 23);
            this.btnAvançar.TabIndex = 15;
            this.btnAvançar.Text = ">>";
            this.btnAvançar.UseVisualStyleBackColor = true;
            this.btnAvançar.Click += new System.EventHandler(this.btnAvançar_Click);
            // 
            // frmManual1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 336);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAvançar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManual1";
            this.Text = "Manual Do Usuario ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvançar;
    }
}