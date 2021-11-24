
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
            this.txtBoxBuscarReserva = new System.Windows.Forms.TextBox();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxDataNasc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.btnNovaReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxQuartIndDuplo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxNoites = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDataSaida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxNumQuartInd = new System.Windows.Forms.TextBox();
            this.txtBoxDataEntrada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxIDReserva = new System.Windows.Forms.TextBox();
            this.txtBoxStatus = new System.Windows.Forms.TextBox();
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
            // txtBoxBuscarReserva
            // 
            this.txtBoxBuscarReserva.Location = new System.Drawing.Point(510, 69);
            this.txtBoxBuscarReserva.Name = "txtBoxBuscarReserva";
            this.txtBoxBuscarReserva.Size = new System.Drawing.Size(130, 23);
            this.txtBoxBuscarReserva.TabIndex = 3;
            this.txtBoxBuscarReserva.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.panel2.Controls.Add(this.txtBoxStatus);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtBoxEndereco);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtBoxDataNasc);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtBoxEmail);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtBoxNome);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtBoxCPF);
            this.panel2.Controls.Add(this.btnNovaReserva);
            this.panel2.Controls.Add(this.btnEditarReserva);
            this.panel2.Controls.Add(this.btnCancelarReserva);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtBoxQuartIndDuplo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBoxNoites);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBoxDataSaida);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBoxNumQuartInd);
            this.panel2.Controls.Add(this.txtBoxDataEntrada);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBoxIDReserva);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 421);
            this.panel2.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Endereço:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(108, 276);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.ReadOnly = true;
            this.txtBoxEndereco.Size = new System.Drawing.Size(287, 23);
            this.txtBoxEndereco.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(548, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Nascimento:";
            // 
            // txtBoxDataNasc
            // 
            this.txtBoxDataNasc.Location = new System.Drawing.Point(624, 235);
            this.txtBoxDataNasc.Name = "txtBoxDataNasc";
            this.txtBoxDataNasc.ReadOnly = true;
            this.txtBoxDataNasc.Size = new System.Drawing.Size(82, 23);
            this.txtBoxDataNasc.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Email:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(482, 276);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.ReadOnly = true;
            this.txtBoxEmail.Size = new System.Drawing.Size(224, 23);
            this.txtBoxEmail.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(242, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Nome:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(291, 235);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.ReadOnly = true;
            this.txtBoxNome.Size = new System.Drawing.Size(239, 23);
            this.txtBoxNome.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "CPF:";
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Location = new System.Drawing.Point(79, 235);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.ReadOnly = true;
            this.txtBoxCPF.Size = new System.Drawing.Size(130, 23);
            this.txtBoxCPF.TabIndex = 26;
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
            // btnEditarReserva
            // 
            this.btnEditarReserva.Location = new System.Drawing.Point(312, 360);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(125, 31);
            this.btnEditarReserva.TabIndex = 24;
            this.btnEditarReserva.Text = "Editar Reserva";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
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
            // txtBoxQuartIndDuplo
            // 
            this.txtBoxQuartIndDuplo.Location = new System.Drawing.Point(375, 142);
            this.txtBoxQuartIndDuplo.Name = "txtBoxQuartIndDuplo";
            this.txtBoxQuartIndDuplo.ReadOnly = true;
            this.txtBoxQuartIndDuplo.Size = new System.Drawing.Size(72, 23);
            this.txtBoxQuartIndDuplo.TabIndex = 22;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "N° Quarto Individual Duplo:";
            // 
            // txtBoxNoites
            // 
            this.txtBoxNoites.Location = new System.Drawing.Point(552, 103);
            this.txtBoxNoites.Name = "txtBoxNoites";
            this.txtBoxNoites.ReadOnly = true;
            this.txtBoxNoites.Size = new System.Drawing.Size(68, 23);
            this.txtBoxNoites.TabIndex = 19;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Saída:";
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
            // txtBoxDataSaida
            // 
            this.txtBoxDataSaida.Location = new System.Drawing.Point(552, 64);
            this.txtBoxDataSaida.Name = "txtBoxDataSaida";
            this.txtBoxDataSaida.ReadOnly = true;
            this.txtBoxDataSaida.Size = new System.Drawing.Size(96, 23);
            this.txtBoxDataSaida.TabIndex = 11;
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
            // txtBoxNumQuartInd
            // 
            this.txtBoxNumQuartInd.Location = new System.Drawing.Point(375, 103);
            this.txtBoxNumQuartInd.Name = "txtBoxNumQuartInd";
            this.txtBoxNumQuartInd.ReadOnly = true;
            this.txtBoxNumQuartInd.Size = new System.Drawing.Size(72, 23);
            this.txtBoxNumQuartInd.TabIndex = 13;
            this.txtBoxNumQuartInd.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtBoxDataEntrada
            // 
            this.txtBoxDataEntrada.Location = new System.Drawing.Point(375, 64);
            this.txtBoxDataEntrada.Name = "txtBoxDataEntrada";
            this.txtBoxDataEntrada.ReadOnly = true;
            this.txtBoxDataEntrada.Size = new System.Drawing.Size(96, 23);
            this.txtBoxDataEntrada.TabIndex = 9;
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
            // txtBoxIDReserva
            // 
            this.txtBoxIDReserva.Location = new System.Drawing.Point(95, 64);
            this.txtBoxIDReserva.Name = "txtBoxIDReserva";
            this.txtBoxIDReserva.ReadOnly = true;
            this.txtBoxIDReserva.Size = new System.Drawing.Size(130, 23);
            this.txtBoxIDReserva.TabIndex = 7;
            // 
            // txtBoxStatus
            // 
            this.txtBoxStatus.Location = new System.Drawing.Point(552, 142);
            this.txtBoxStatus.Name = "txtBoxStatus";
            this.txtBoxStatus.ReadOnly = true;
            this.txtBoxStatus.Size = new System.Drawing.Size(68, 23);
            this.txtBoxStatus.TabIndex = 36;
            // 
            // FrmConsultarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.txtBoxBuscarReserva);
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
        private System.Windows.Forms.TextBox txtBoxBuscarReserva;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDataSaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDataEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxIDReserva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxNumQuartInd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxNoites;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxQuartIndDuplo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnNovaReserva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxDataNasc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.TextBox txtBoxStatus;
    }
}