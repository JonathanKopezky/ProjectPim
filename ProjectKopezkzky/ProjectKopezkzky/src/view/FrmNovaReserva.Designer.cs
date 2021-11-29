
namespace ProjectKopezkzky.src.view
{
    partial class FrmNovaReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.listViewCliente = new System.Windows.Forms.ListView();
            this.columnHeaderCPF = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderNome = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderEndereco = new System.Windows.Forms.ColumnHeader();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.dateTimePickerEntrada = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxQartInd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerSaida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBoxCPF);
            this.panel2.Controls.Add(this.listViewCliente);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblCPF);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 196);
            this.panel2.TabIndex = 2;
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Location = new System.Drawing.Point(461, 35);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(126, 23);
            this.txtBoxCPF.TabIndex = 9;
            // 
            // listViewCliente
            // 
            this.listViewCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCPF,
            this.columnHeaderNome,
            this.columnHeaderEndereco});
            this.listViewCliente.GridLines = true;
            this.listViewCliente.HideSelection = false;
            this.listViewCliente.Location = new System.Drawing.Point(13, 91);
            this.listViewCliente.Name = "listViewCliente";
            this.listViewCliente.Size = new System.Drawing.Size(731, 85);
            this.listViewCliente.TabIndex = 6;
            this.listViewCliente.UseCompatibleStateImageBehavior = false;
            this.listViewCliente.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCPF
            // 
            this.columnHeaderCPF.Text = "CPF";
            this.columnHeaderCPF.Width = 111;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 255;
            // 
            // columnHeaderEndereco
            // 
            this.columnHeaderEndereco.Text = "Endereço";
            this.columnHeaderEndereco.Width = 360;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(462, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Ex: 555.666.777-89";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCPF.Location = new System.Drawing.Point(424, 38);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(31, 15);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // dateTimePickerEntrada
            // 
            this.dateTimePickerEntrada.Location = new System.Drawing.Point(35, 108);
            this.dateTimePickerEntrada.Name = "dateTimePickerEntrada";
            this.dateTimePickerEntrada.Size = new System.Drawing.Size(208, 23);
            this.dateTimePickerEntrada.TabIndex = 2;
            this.dateTimePickerEntrada.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnReservar);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dateTimePickerSaida);
            this.panel3.Controls.Add(this.dateTimePickerEntrada);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 278);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(96, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "ver data selecionada";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Location = new System.Drawing.Point(523, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(208, 134);
            this.panel5.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Número do quarto";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 38);
            this.label13.TabIndex = 19;
            this.label13.Text = "Quarto de Solteiro Duplo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(118, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Location = new System.Drawing.Point(597, 227);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(133, 36);
            this.btnReservar.TabIndex = 15;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.comboBoxQartInd);
            this.panel4.Location = new System.Drawing.Point(292, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 134);
            this.panel4.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número do quarto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(206, 38);
            this.label14.TabIndex = 19;
            this.label14.Text = "Quarto de Solteiro";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxQartInd
            // 
            this.comboBoxQartInd.FormattingEnabled = true;
            this.comboBoxQartInd.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQartInd.Location = new System.Drawing.Point(118, 51);
            this.comboBoxQartInd.Name = "comboBoxQartInd";
            this.comboBoxQartInd.Size = new System.Drawing.Size(45, 23);
            this.comboBoxQartInd.TabIndex = 4;
            this.comboBoxQartInd.SelectedIndexChanged += new System.EventHandler(this.comboBoxQartInd_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(35, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Saída:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(35, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Entrada:";
            // 
            // dateTimePickerSaida
            // 
            this.dateTimePickerSaida.Location = new System.Drawing.Point(35, 185);
            this.dateTimePickerSaida.Name = "dateTimePickerSaida";
            this.dateTimePickerSaida.Size = new System.Drawing.Size(208, 23);
            this.dateTimePickerSaida.TabIndex = 8;
            this.dateTimePickerSaida.Value = new System.DateTime(2022, 1, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Selecionar Quartos e Datas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 42);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nova Reserva";
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Right;
            this.label20.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(70, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 48);
            this.label20.TabIndex = 17;
            this.label20.Text = "R$ 105,00";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label20);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 48);
            this.panel6.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 84);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 48);
            this.panel7.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 48);
            this.label5.TabIndex = 17;
            this.label5.Text = "R$ 105,00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(13, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Busque e Selecione o cliente na lista abaixo";
            // 
            // FrmNovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNovaReserva";
            this.Text = "FrmNovaReserva";
            this.Load += new System.EventHandler(this.FrmNovaReserva_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntrada;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxQartInd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaida;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListView listViewCliente;
        private System.Windows.Forms.ColumnHeader columnHeaderCPF;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderEndereco;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
    }
}