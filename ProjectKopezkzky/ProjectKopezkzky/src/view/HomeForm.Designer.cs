
namespace ProjectKopezkzky.src.view
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastralClienteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.btnHomeSair = new System.Windows.Forms.Button();
            this.panelCadCliente = new System.Windows.Forms.Panel();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbNascimento = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.labelDatanasc = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCadCliente.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservaToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarReservaToolStripMenuItem,
            this.consultarReservaToolStripMenuItem1});
            this.reservaToolStripMenuItem.Name = "reservaToolStripMenuItem";
            this.reservaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reservaToolStripMenuItem.Text = "Reserva";
            // 
            // consultarReservaToolStripMenuItem
            // 
            this.consultarReservaToolStripMenuItem.Name = "consultarReservaToolStripMenuItem";
            this.consultarReservaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consultarReservaToolStripMenuItem.Text = "Nova Reserva";
            // 
            // consultarReservaToolStripMenuItem1
            // 
            this.consultarReservaToolStripMenuItem1.Name = "consultarReservaToolStripMenuItem1";
            this.consultarReservaToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.consultarReservaToolStripMenuItem1.Text = "Consultar Reserva ";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastralClienteMenu,
            this.consultarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // CadastralClienteMenu
            // 
            this.CadastralClienteMenu.Name = "CadastralClienteMenu";
            this.CadastralClienteMenu.Size = new System.Drawing.Size(167, 22);
            this.CadastralClienteMenu.Text = "Cadastrar Cliente ";
            this.CadastralClienteMenu.Click += new System.EventHandler(this.CadastralClienteMenu_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.labelCargo);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Controls.Add(this.btnHomeSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(784, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 587);
            this.panel1.TabIndex = 3;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(77, 108);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(0, 15);
            this.labelCargo.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(77, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 15);
            this.labelName.TabIndex = 3;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(26, 108);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(45, 15);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo :";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.ForeColor = System.Drawing.Color.White;
            this.LblNome.Location = new System.Drawing.Point(26, 83);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(46, 15);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome :";
            // 
            // btnHomeSair
            // 
            this.btnHomeSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeSair.BackgroundImage")));
            this.btnHomeSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHomeSair.FlatAppearance.BorderSize = 0;
            this.btnHomeSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeSair.ForeColor = System.Drawing.Color.White;
            this.btnHomeSair.Location = new System.Drawing.Point(99, 555);
            this.btnHomeSair.Name = "btnHomeSair";
            this.btnHomeSair.Size = new System.Drawing.Size(101, 32);
            this.btnHomeSair.TabIndex = 0;
            this.btnHomeSair.Text = "Sair";
            this.btnHomeSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomeSair.UseVisualStyleBackColor = true;
            // 
            // panelCadCliente
            // 
            this.panelCadCliente.Controls.Add(this.panelConsulta);
            this.panelCadCliente.Controls.Add(this.label1);
            this.panelCadCliente.Controls.Add(this.btnSalvar);
            this.panelCadCliente.Controls.Add(this.btnCancelar);
            this.panelCadCliente.Controls.Add(this.textBox1);
            this.panelCadCliente.Controls.Add(this.txbNascimento);
            this.panelCadCliente.Controls.Add(this.textBox10);
            this.panelCadCliente.Controls.Add(this.txbEndereco);
            this.panelCadCliente.Controls.Add(this.txbNumero);
            this.panelCadCliente.Controls.Add(this.txbCep);
            this.panelCadCliente.Controls.Add(this.txbEstado);
            this.panelCadCliente.Controls.Add(this.txbCpf);
            this.panelCadCliente.Controls.Add(this.txbTelefone);
            this.panelCadCliente.Controls.Add(this.txtComplemento);
            this.panelCadCliente.Controls.Add(this.textBox2);
            this.panelCadCliente.Controls.Add(this.txbNome);
            this.panelCadCliente.Controls.Add(this.lblPais);
            this.panelCadCliente.Controls.Add(this.lblCidade);
            this.panelCadCliente.Controls.Add(this.lblComplemento);
            this.panelCadCliente.Controls.Add(this.label9);
            this.panelCadCliente.Controls.Add(this.lblCpf);
            this.panelCadCliente.Controls.Add(this.lblEstado);
            this.panelCadCliente.Controls.Add(this.lblCep);
            this.panelCadCliente.Controls.Add(this.label5);
            this.panelCadCliente.Controls.Add(this.lbl);
            this.panelCadCliente.Controls.Add(this.lblEmail);
            this.panelCadCliente.Controls.Add(this.labelDatanasc);
            this.panelCadCliente.Controls.Add(this.labelNome);
            this.panelCadCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadCliente.Location = new System.Drawing.Point(0, 24);
            this.panelCadCliente.Name = "panelCadCliente";
            this.panelCadCliente.Size = new System.Drawing.Size(784, 587);
            this.panelCadCliente.TabIndex = 4;
            this.panelCadCliente.Visible = false;
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.lblConsulta);
            this.panelConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta.Location = new System.Drawing.Point(0, 0);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(784, 587);
            this.panelConsulta.TabIndex = 24;
            this.panelConsulta.Visible = false;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConsulta.Location = new System.Drawing.Point(286, 266);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(75, 21);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Consulta ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(310, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cadastrar Clientes";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(362, 457);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 457);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Limpar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 23);
            this.textBox1.TabIndex = 12;
            // 
            // txbNascimento
            // 
            this.txbNascimento.Location = new System.Drawing.Point(67, 129);
            this.txbNascimento.Name = "txbNascimento";
            this.txbNascimento.Size = new System.Drawing.Size(100, 23);
            this.txbNascimento.TabIndex = 2;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(67, 175);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(220, 23);
            this.textBox10.TabIndex = 3;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(67, 219);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(263, 23);
            this.txbEndereco.TabIndex = 4;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(67, 263);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 23);
            this.txbNumero.TabIndex = 20;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(67, 307);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(106, 23);
            this.txbCep.TabIndex = 19;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(67, 360);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(100, 23);
            this.txbEstado.TabIndex = 18;
            // 
            // txbCpf
            // 
            this.txbCpf.Location = new System.Drawing.Point(470, 83);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(160, 23);
            this.txbCpf.TabIndex = 8;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(470, 134);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(160, 23);
            this.txbTelefone.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(470, 178);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(135, 23);
            this.txtComplemento.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(470, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 23);
            this.textBox2.TabIndex = 11;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(67, 83);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(263, 23);
            this.txbNome.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(470, 248);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 15);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "Pais :";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(470, 204);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 15);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade :";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(470, 160);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(90, 15);
            this.lblComplemento.TabIndex = 9;
            this.lblComplemento.Text = "Complemento :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefone :";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(470, 66);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(32, 15);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "Cpf :";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(67, 342);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado :";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(67, 289);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(34, 15);
            this.lblCep.TabIndex = 5;
            this.lblCep.Text = "Cep :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(67, 201);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 15);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Endereco :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(67, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail :";
            // 
            // labelDatanasc
            // 
            this.labelDatanasc.AutoSize = true;
            this.labelDatanasc.Location = new System.Drawing.Point(67, 111);
            this.labelDatanasc.Name = "labelDatanasc";
            this.labelDatanasc.Size = new System.Drawing.Size(120, 15);
            this.labelDatanasc.TabIndex = 1;
            this.labelDatanasc.Text = "Data de Nascimento :";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(67, 65);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(46, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome :";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panelCadCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomeForm";
            this.ShowIcon = false;
            this.Text = " Kopesky";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCadCliente.ResumeLayout(false);
            this.panelCadCliente.PerformLayout();
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastralClienteMenu;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHomeSair;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Panel panelCadCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txbNascimento;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label labelDatanasc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConsulta;
    }
}