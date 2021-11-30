
namespace ProjectKopezkzky.src.view
{
    partial class FrmConsultarCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnEditarReserva = new System.Windows.Forms.Button();
            this.btnNovaReserva = new System.Windows.Forms.Button();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPais = new System.Windows.Forms.TextBox();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbnumero = new System.Windows.Forms.TextBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.labelDatanasc = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(608, 528);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(125, 31);
            this.btnCancelarReserva.TabIndex = 26;
            this.btnCancelarReserva.Text = "Apagar Cliente";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEditarReserva
            // 
            this.btnEditarReserva.Location = new System.Drawing.Point(339, 528);
            this.btnEditarReserva.Name = "btnEditarReserva";
            this.btnEditarReserva.Size = new System.Drawing.Size(125, 31);
            this.btnEditarReserva.TabIndex = 27;
            this.btnEditarReserva.Text = "Editar Cliente";
            this.btnEditarReserva.UseVisualStyleBackColor = true;
            this.btnEditarReserva.Click += new System.EventHandler(this.btnEditarReserva_Click);
            // 
            // btnNovaReserva
            // 
            this.btnNovaReserva.Location = new System.Drawing.Point(70, 528);
            this.btnNovaReserva.Name = "btnNovaReserva";
            this.btnNovaReserva.Size = new System.Drawing.Size(125, 31);
            this.btnNovaReserva.TabIndex = 28;
            this.btnNovaReserva.Text = "Novo Cliente";
            this.btnNovaReserva.UseVisualStyleBackColor = true;
            this.btnNovaReserva.Click += new System.EventHandler(this.btnNovaReserva_Click);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(578, 128);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.ReadOnly = true;
            this.txbTelefone.Size = new System.Drawing.Size(160, 23);
            this.txbTelefone.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(578, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "Telefone :";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(296, 128);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.ReadOnly = true;
            this.txtGenero.Size = new System.Drawing.Size(263, 23);
            this.txtGenero.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(296, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "Gênero :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 84;
            this.label4.Text = "Rg :";
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(11, 128);
            this.txbRg.Name = "txbRg";
            this.txbRg.ReadOnly = true;
            this.txbRg.Size = new System.Drawing.Size(100, 23);
            this.txbRg.TabIndex = 61;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(296, 71);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.ReadOnly = true;
            this.txbSobrenome.Size = new System.Drawing.Size(263, 23);
            this.txbSobrenome.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(296, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Sobrenome :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 35);
            this.panel1.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(328, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 48;
            this.label7.Text = "Consultar Cliente";
            // 
            // txbPais
            // 
            this.txbPais.Location = new System.Drawing.Point(578, 247);
            this.txbPais.Name = "txbPais";
            this.txbPais.ReadOnly = true;
            this.txbPais.Size = new System.Drawing.Size(160, 23);
            this.txbPais.TabIndex = 71;
            // 
            // txbNascimento
            // 
            this.txbNascimento.Location = new System.Drawing.Point(133, 128);
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.ReadOnly = true;
            this.txbNascimento.Size = new System.Drawing.Size(141, 23);
            this.txbNascimento.TabIndex = 62;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(11, 186);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.ReadOnly = true;
            this.txbEmail.Size = new System.Drawing.Size(263, 23);
            this.txbEmail.TabIndex = 65;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(296, 186);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.ReadOnly = true;
            this.txbEndereco.Size = new System.Drawing.Size(263, 23);
            this.txbEndereco.TabIndex = 66;
            // 
            // txbnumero
            // 
            this.txbnumero.Location = new System.Drawing.Point(11, 247);
            this.txbnumero.Name = "txbnumero";
            this.txbnumero.ReadOnly = true;
            this.txbnumero.Size = new System.Drawing.Size(100, 23);
            this.txbnumero.TabIndex = 68;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(578, 186);
            this.txbCep.Name = "txbCep";
            this.txbCep.ReadOnly = true;
            this.txbCep.Size = new System.Drawing.Size(160, 23);
            this.txbCep.TabIndex = 67;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(133, 247);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.ReadOnly = true;
            this.txbEstado.Size = new System.Drawing.Size(33, 23);
            this.txbEstado.TabIndex = 69;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(578, 71);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.ReadOnly = true;
            this.txbCpf.Size = new System.Drawing.Size(160, 23);
            this.txbCpf.TabIndex = 60;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(296, 247);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.ReadOnly = true;
            this.txbCidade.Size = new System.Drawing.Size(263, 23);
            this.txbCidade.TabIndex = 70;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(11, 71);
            this.txbNome.Name = "txbNome";
            this.txbNome.ReadOnly = true;
            this.txbNome.Size = new System.Drawing.Size(263, 23);
            this.txbNome.TabIndex = 58;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPais.Location = new System.Drawing.Point(578, 229);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 15);
            this.lblPais.TabIndex = 81;
            this.lblPais.Text = "Pais :";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCidade.Location = new System.Drawing.Point(296, 229);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 15);
            this.lblCidade.TabIndex = 80;
            this.lblCidade.Text = "Cidade :";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCpf.Location = new System.Drawing.Point(578, 50);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(32, 15);
            this.lblCpf.TabIndex = 79;
            this.lblCpf.Text = "Cpf :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.SystemColors.Info;
            this.lblEstado.Location = new System.Drawing.Point(133, 229);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 78;
            this.lblEstado.Text = "Estado :";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCep.Location = new System.Drawing.Point(578, 168);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 15);
            this.lblCep.TabIndex = 77;
            this.lblCep.Text = "Cep :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(11, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 76;
            this.label8.Text = "Número :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl.Location = new System.Drawing.Point(296, 168);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 15);
            this.lbl.TabIndex = 75;
            this.lbl.Text = "Endereco :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.lblEmail.Location = new System.Drawing.Point(11, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 74;
            this.lblEmail.Text = "E-mail :";
            // 
            // labelDatanasc
            // 
            this.labelDatanasc.AutoSize = true;
            this.labelDatanasc.ForeColor = System.Drawing.SystemColors.Info;
            this.labelDatanasc.Location = new System.Drawing.Point(133, 110);
            this.labelDatanasc.Name = "labelDatanasc";
            this.labelDatanasc.Size = new System.Drawing.Size(120, 15);
            this.labelDatanasc.TabIndex = 73;
            this.labelDatanasc.Text = "Data de Nascimento :";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.SystemColors.Info;
            this.labelNome.Location = new System.Drawing.Point(11, 50);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 15);
            this.labelNome.TabIndex = 72;
            this.labelNome.Text = "Nome :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbTelefone);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtGenero);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbRg);
            this.panel2.Controls.Add(this.txbSobrenome);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbPais);
            this.panel2.Controls.Add(this.txbNascimento);
            this.panel2.Controls.Add(this.txbEmail);
            this.panel2.Controls.Add(this.txbEndereco);
            this.panel2.Controls.Add(this.txbnumero);
            this.panel2.Controls.Add(this.txbCep);
            this.panel2.Controls.Add(this.txbEstado);
            this.panel2.Controls.Add(this.txbCpf);
            this.panel2.Controls.Add(this.txbCidade);
            this.panel2.Controls.Add(this.txbNome);
            this.panel2.Controls.Add(this.lblPais);
            this.panel2.Controls.Add(this.lblCidade);
            this.panel2.Controls.Add(this.lblCpf);
            this.panel2.Controls.Add(this.lblEstado);
            this.panel2.Controls.Add(this.lblCep);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.labelDatanasc);
            this.panel2.Controls.Add(this.labelNome);
            this.panel2.Location = new System.Drawing.Point(12, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 382);
            this.panel2.TabIndex = 87;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(296, 305);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(442, 23);
            this.textBox3.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(296, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 91;
            this.label9.Text = "Complemento :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(11, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 88;
            this.label1.Text = "Status :";
            // 
            // FrmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnEditarReserva);
            this.Controls.Add(this.btnNovaReserva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarCliente";
            this.Text = "FrmBuscarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnEditarReserva;
        private System.Windows.Forms.Button btnNovaReserva;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbRg;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPais;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbnumero;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label labelDatanasc;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}