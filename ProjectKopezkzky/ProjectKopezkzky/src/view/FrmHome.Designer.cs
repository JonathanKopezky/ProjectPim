
namespace ProjectKopezkzky.src.view
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.btnHomeSair = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.reservaToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // reservaToolStripMenuItem
            // 
            this.reservaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarReservaToolStripMenuItem,
            this.consultarReservaToolStripMenuItem1,
            this.consultarReservaToolStripMenuItem2});
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
            // consultarReservaToolStripMenuItem2
            // 
            this.consultarReservaToolStripMenuItem2.Name = "consultarReservaToolStripMenuItem2";
            this.consultarReservaToolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.consultarReservaToolStripMenuItem2.Text = "Consultar Reserva ";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Clientes";
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
            // panelHome
            // 
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 24);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(784, 587);
            this.panelHome.TabIndex = 4;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmHome";
            this.ShowIcon = false;
            this.Text = " Kopesky";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHomeSair;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservaToolStripMenuItem2;
    }
}