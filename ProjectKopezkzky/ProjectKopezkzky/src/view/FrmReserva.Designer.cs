
namespace ProjectKopezkzky.src.view
{
    partial class FrmReserva
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
            this.ReservationIdTb = new System.Windows.Forms.TextBox();
            this.Datein = new System.Windows.Forms.DateTimePicker();
            this.AddReservaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.EditReservaBtn = new System.Windows.Forms.Button();
            this.DeleteReservaBtn = new System.Windows.Forms.Button();
            this.totalAcompTb = new System.Windows.Forms.TextBox();
            this.pagamentoIdTb = new System.Windows.Forms.TextBox();
            this.roomcb = new System.Windows.Forms.ComboBox();
            this.clientIdcb = new System.Windows.Forms.ComboBox();
            this.funcionarioIdcb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelDadosReserva = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            this.panelDadosReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReservationIdTb
            // 
            this.ReservationIdTb.Location = new System.Drawing.Point(10, 147);
            this.ReservationIdTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReservationIdTb.Name = "ReservationIdTb";
            this.ReservationIdTb.Size = new System.Drawing.Size(110, 23);
            this.ReservationIdTb.TabIndex = 6;
            // 
            // Datein
            // 
            this.Datein.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.CalendarForeColor = System.Drawing.Color.Crimson;
            this.Datein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.Location = new System.Drawing.Point(10, 27);
            this.Datein.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(214, 21);
            this.Datein.TabIndex = 1;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // AddReservaBtn
            // 
            this.AddReservaBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AddReservaBtn.Location = new System.Drawing.Point(613, 83);
            this.AddReservaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddReservaBtn.Name = "AddReservaBtn";
            this.AddReservaBtn.Size = new System.Drawing.Size(113, 40);
            this.AddReservaBtn.TabIndex = 9;
            this.AddReservaBtn.Text = "Adicionar Reserva";
            this.AddReservaBtn.UseVisualStyleBackColor = false;
            this.AddReservaBtn.Click += new System.EventHandler(this.AddReservaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data de Entrada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data de Saída:";
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.ReservationGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.GridColor = System.Drawing.Color.SeaGreen;
            this.ReservationGridView.Location = new System.Drawing.Point(7, 302);
            this.ReservationGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersWidth = 51;
            this.ReservationGridView.RowTemplate.Height = 29;
            this.ReservationGridView.Size = new System.Drawing.Size(788, 302);
            this.ReservationGridView.TabIndex = 12;
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // Dateout
            // 
            this.Dateout.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dateout.CalendarForeColor = System.Drawing.Color.Crimson;
            this.Dateout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dateout.Location = new System.Drawing.Point(245, 27);
            this.Dateout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(214, 21);
            this.Dateout.TabIndex = 2;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // EditReservaBtn
            // 
            this.EditReservaBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.EditReservaBtn.Location = new System.Drawing.Point(613, 141);
            this.EditReservaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditReservaBtn.Name = "EditReservaBtn";
            this.EditReservaBtn.Size = new System.Drawing.Size(113, 40);
            this.EditReservaBtn.TabIndex = 10;
            this.EditReservaBtn.Text = "Editar Reserva";
            this.EditReservaBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteReservaBtn
            // 
            this.DeleteReservaBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.DeleteReservaBtn.Location = new System.Drawing.Point(613, 198);
            this.DeleteReservaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteReservaBtn.Name = "DeleteReservaBtn";
            this.DeleteReservaBtn.Size = new System.Drawing.Size(113, 40);
            this.DeleteReservaBtn.TabIndex = 11;
            this.DeleteReservaBtn.Text = "Deletar Reserva";
            this.DeleteReservaBtn.UseVisualStyleBackColor = false;
            // 
            // totalAcompTb
            // 
            this.totalAcompTb.Location = new System.Drawing.Point(326, 147);
            this.totalAcompTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalAcompTb.Name = "totalAcompTb";
            this.totalAcompTb.Size = new System.Drawing.Size(133, 23);
            this.totalAcompTb.TabIndex = 8;
            // 
            // pagamentoIdTb
            // 
            this.pagamentoIdTb.Location = new System.Drawing.Point(172, 147);
            this.pagamentoIdTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagamentoIdTb.Name = "pagamentoIdTb";
            this.pagamentoIdTb.Size = new System.Drawing.Size(110, 23);
            this.pagamentoIdTb.TabIndex = 7;
            // 
            // roomcb
            // 
            this.roomcb.FormattingEnabled = true;
            this.roomcb.Location = new System.Drawing.Point(326, 83);
            this.roomcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomcb.Name = "roomcb";
            this.roomcb.Size = new System.Drawing.Size(133, 23);
            this.roomcb.TabIndex = 5;
            // 
            // clientIdcb
            // 
            this.clientIdcb.FormattingEnabled = true;
            this.clientIdcb.Location = new System.Drawing.Point(10, 83);
            this.clientIdcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientIdcb.Name = "clientIdcb";
            this.clientIdcb.Size = new System.Drawing.Size(133, 23);
            this.clientIdcb.TabIndex = 3;
            // 
            // funcionarioIdcb
            // 
            this.funcionarioIdcb.FormattingEnabled = true;
            this.funcionarioIdcb.Location = new System.Drawing.Point(172, 83);
            this.funcionarioIdcb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funcionarioIdcb.Name = "funcionarioIdcb";
            this.funcionarioIdcb.Size = new System.Drawing.Size(133, 23);
            this.funcionarioIdcb.TabIndex = 4;
            this.funcionarioIdcb.SelectedIndexChanged += new System.EventHandler(this.funcionarioIdcb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "N° do Quarto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "ID Funcionário:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID Pagamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Acompanhantes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Reservation ID:";
            // 
            // panelDadosReserva
            // 
            this.panelDadosReserva.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelDadosReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDadosReserva.Controls.Add(this.label8);
            this.panelDadosReserva.Controls.Add(this.label7);
            this.panelDadosReserva.Controls.Add(this.label6);
            this.panelDadosReserva.Controls.Add(this.label5);
            this.panelDadosReserva.Controls.Add(this.label4);
            this.panelDadosReserva.Controls.Add(this.label3);
            this.panelDadosReserva.Controls.Add(this.funcionarioIdcb);
            this.panelDadosReserva.Controls.Add(this.clientIdcb);
            this.panelDadosReserva.Controls.Add(this.roomcb);
            this.panelDadosReserva.Controls.Add(this.pagamentoIdTb);
            this.panelDadosReserva.Controls.Add(this.totalAcompTb);
            this.panelDadosReserva.Controls.Add(this.Dateout);
            this.panelDadosReserva.Controls.Add(this.label2);
            this.panelDadosReserva.Controls.Add(this.label1);
            this.panelDadosReserva.Controls.Add(this.Datein);
            this.panelDadosReserva.Controls.Add(this.ReservationIdTb);
            this.panelDadosReserva.Location = new System.Drawing.Point(12, 50);
            this.panelDadosReserva.Name = "panelDadosReserva";
            this.panelDadosReserva.Size = new System.Drawing.Size(517, 186);
            this.panelDadosReserva.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(23, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 30);
            this.label9.TabIndex = 37;
            this.label9.Text = "Reservas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(23, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 30);
            this.label10.TabIndex = 38;
            this.label10.Text = "Dados da Reserva";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(635, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 30);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ações";
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 615);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelDadosReserva);
            this.Controls.Add(this.DeleteReservaBtn);
            this.Controls.Add(this.EditReservaBtn);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.AddReservaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmReserva";
            this.Text = "FrmReserva";
            this.Load += new System.EventHandler(this.FrmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
            this.panelDadosReserva.ResumeLayout(false);
            this.panelDadosReserva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReservationIdTb;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.Button AddReservaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ReservationGridView;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.Button EditReservaBtn;
        private System.Windows.Forms.Button DeleteReservaBtn;
        private System.Windows.Forms.TextBox totalAcompTb;
        private System.Windows.Forms.TextBox pagamentoIdTb;
        private System.Windows.Forms.ComboBox roomcb;
        private System.Windows.Forms.ComboBox clientIdcb;
        private System.Windows.Forms.ComboBox funcionarioIdcb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelDadosReserva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}