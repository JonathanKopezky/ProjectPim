
namespace ProjectKopezkzky.src.view
{
    partial class FrmUpdateCliente
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
            this.lblAlterar = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.comboxGenero = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPais = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.labelDatanasc = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbRg = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.lblAlterar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAlterar.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAlterar.Location = new System.Drawing.Point(331, 9);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(108, 19);
            this.lblAlterar.TabIndex = 1;
            this.lblAlterar.Text = "Atualizar Cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(700, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 92;
            this.btnSalvar.Text = "Atualizar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 93;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // comboxGenero
            // 
            this.comboxGenero.FormattingEnabled = true;
            this.comboxGenero.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.comboxGenero.Location = new System.Drawing.Point(352, 165);
            this.comboxGenero.Name = "comboxGenero";
            this.comboxGenero.Size = new System.Drawing.Size(121, 23);
            this.comboxGenero.TabIndex = 125;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(634, 223);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(101, 23);
            this.maskedTextBoxCep.TabIndex = 102;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(523, 165);
            this.maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(101, 23);
            this.maskedTextBoxTelefone.TabIndex = 99;
            // 
            // maskedTextBoxDataNasc
            // 
            this.maskedTextBoxDataNasc.Location = new System.Drawing.Point(210, 165);
            this.maskedTextBoxDataNasc.Mask = "00/00/0000";
            this.maskedTextBoxDataNasc.Name = "maskedTextBoxDataNasc";
            this.maskedTextBoxDataNasc.Size = new System.Drawing.Size(101, 23);
            this.maskedTextBoxDataNasc.TabIndex = 98;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(352, 341);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(117, 23);
            this.txbSenha.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 124;
            this.label7.Text = "Senha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 123;
            this.label2.Text = "Telefone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 122;
            this.label6.Text = "Gênero :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 121;
            this.label4.Text = "Rg :";
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(352, 108);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(263, 23);
            this.txbSobrenome.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 120;
            this.label3.Text = "Sobrenome :";
            // 
            // txbPais
            // 
            this.txbPais.Location = new System.Drawing.Point(545, 284);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(160, 23);
            this.txbPais.TabIndex = 106;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(67, 223);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(263, 23);
            this.txbEmail.TabIndex = 100;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(352, 223);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(263, 23);
            this.txbEndereco.TabIndex = 101;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(67, 284);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 23);
            this.txbNumero.TabIndex = 103;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(189, 284);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(33, 23);
            this.txbEstado.TabIndex = 104;
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(67, 341);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(263, 23);
            this.txbComplemento.TabIndex = 107;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(263, 284);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(263, 23);
            this.txbCidade.TabIndex = 105;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(67, 108);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(263, 23);
            this.txbNome.TabIndex = 94;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(545, 266);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 15);
            this.lblPais.TabIndex = 119;
            this.lblPais.Text = "Pais :";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(263, 266);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 15);
            this.lblCidade.TabIndex = 118;
            this.lblCidade.Text = "Cidade :";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(67, 323);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(90, 15);
            this.lblComplemento.TabIndex = 117;
            this.lblComplemento.Text = "Complemento :";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(634, 87);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(32, 15);
            this.lblCpf.TabIndex = 116;
            this.lblCpf.Text = "Cpf :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(189, 266);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 115;
            this.lblEstado.Text = "Estado :";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(634, 205);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 15);
            this.lblCep.TabIndex = 114;
            this.lblCep.Text = "Cep :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 113;
            this.label5.Text = "Número :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(352, 205);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 15);
            this.lbl.TabIndex = 112;
            this.lbl.Text = "Endereco :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(67, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 111;
            this.lblEmail.Text = "E-mail :";
            // 
            // labelDatanasc
            // 
            this.labelDatanasc.AutoSize = true;
            this.labelDatanasc.Location = new System.Drawing.Point(210, 147);
            this.labelDatanasc.Name = "labelDatanasc";
            this.labelDatanasc.Size = new System.Drawing.Size(120, 15);
            this.labelDatanasc.TabIndex = 110;
            this.labelDatanasc.Text = "Data de Nascimento :";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(67, 87);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 15);
            this.labelNome.TabIndex = 109;
            this.labelNome.Text = "Nome :";
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(634, 108);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(101, 23);
            this.txbCpf.TabIndex = 126;
            // 
            // txbRg
            // 
            this.txbRg.Location = new System.Drawing.Point(66, 165);
            this.txbRg.Name = "txbRg";
            this.txbRg.Size = new System.Drawing.Size(117, 23);
            this.txbRg.TabIndex = 127;
            // 
            // FrmUpdateCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbRg);
            this.Controls.Add(this.txbCpf);
            this.Controls.Add(this.comboxGenero);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxDataNasc);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPais);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.txbComplemento);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.labelDatanasc);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmUpdateCliente";
            this.Text = "FrmUpdateCliente";
            this.Load += new System.EventHandler(this.FrmUpdateCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox comboxGenero;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataNasc;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPais;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label labelDatanasc;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbRg;
    }
}