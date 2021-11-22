
namespace ProjectKopezkzky.src.view
{
    partial class FrmConsultarReserva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderCPF = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEndereco = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEmail = new System.Windows.Forms.ColumnHeader();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnNovaReserva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 42);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consultar Reserva";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(659, 69);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarReserva.TabIndex = 4;
            this.btnBuscarReserva.Text = "Buscar Reserva";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            this.btnBuscarReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID reserva:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnNovaReserva);
            this.panel2.Controls.Add(this.btnEditarReserva);
            this.panel2.Controls.Add(this.btnCancelarReserva);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 421);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reserva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID reserva:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Entrada:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(375, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 23);
            this.textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Saída:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(552, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 23);
            this.textBox4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "N° Quarto Individual:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(375, 103);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 23);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "N° Quarto Individual Duplo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Status:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(502, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Noites:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(552, 103);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(68, 23);
            this.textBox8.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aberta",
            "Fechada"});
            this.comboBox1.Location = new System.Drawing.Point(552, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 23);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(375, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(72, 23);
            this.textBox6.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 30);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cliente:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCPF,
            this.columnHeaderNome,
            this.columnHeaderEndereco,
            this.columnHeaderEmail});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 235);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(713, 85);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCPF
            // 
            this.columnHeaderCPF.Text = "CPF";
            this.columnHeaderCPF.Width = 111;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 210;
            // 
            // columnHeaderEndereco
            // 
            this.columnHeaderEndereco.Text = "Endereço";
            this.columnHeaderEndereco.Width = 235;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 153;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(581, 360);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(125, 31);
            this.btnCancelarReserva.TabIndex = 23;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Location = new System.Drawing.Point(322, 360);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(125, 31);
            this.btnEditarReserva.TabIndex = 24;
            this.btnEditarReserva.Text = "Editar Reserva";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.Location = new System.Drawing.Point(43, 360);
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(125, 31);
            this.btnNovaReserva.TabIndex = 25;
            this.btnNovaReserva.Text = "Nova Reserva";
            this.btnNovaReserva.UseVisualStyleBackColor = true;
            // 
            // FrmConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarReserva";
            this.Text = "FrmConsultarReserva";
            this.Load += new System.EventHandler(this.FrmConsultarReserva_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderCPF;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.Button btnNovaReserva;
    }
}