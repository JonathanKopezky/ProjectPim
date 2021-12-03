
namespace ProjectKopezkzky.src.view
{
    partial class TesteReserva
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
            this.textImputCPF = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textQuartoId = new System.Windows.Forms.TextBox();
            this.textPagamentoId = new System.Windows.Forms.TextBox();
            this.textDataCheckIn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textImputCPF
            // 
            this.textImputCPF.Location = new System.Drawing.Point(191, 77);
            this.textImputCPF.Name = "textImputCPF";
            this.textImputCPF.Size = new System.Drawing.Size(125, 27);
            this.textImputCPF.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(451, 77);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(94, 29);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // textQuartoId
            // 
            this.textQuartoId.Location = new System.Drawing.Point(72, 214);
            this.textQuartoId.Name = "textQuartoId";
            this.textQuartoId.Size = new System.Drawing.Size(125, 27);
            this.textQuartoId.TabIndex = 2;
            // 
            // textPagamentoId
            // 
            this.textPagamentoId.Location = new System.Drawing.Point(229, 214);
            this.textPagamentoId.Name = "textPagamentoId";
            this.textPagamentoId.Size = new System.Drawing.Size(125, 27);
            this.textPagamentoId.TabIndex = 3;
            // 
            // textDataCheckIn
            // 
            this.textDataCheckIn.Location = new System.Drawing.Point(369, 214);
            this.textDataCheckIn.Name = "textDataCheckIn";
            this.textDataCheckIn.Size = new System.Drawing.Size(125, 27);
            this.textDataCheckIn.TabIndex = 4;
            // 
            // TesteReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textDataCheckIn);
            this.Controls.Add(this.textPagamentoId);
            this.Controls.Add(this.textQuartoId);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.textImputCPF);
            this.Name = "TesteReserva";
            this.Text = "TesteReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textImputCPF;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textQuartoId;
        private System.Windows.Forms.TextBox textPagamentoId;
        private System.Windows.Forms.TextBox textDataCheckIn;
    }
}