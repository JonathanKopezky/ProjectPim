
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
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationIdTb
            // 
            this.ReservationIdTb.Location = new System.Drawing.Point(19, 23);
            this.ReservationIdTb.Name = "ReservationIdTb";
            this.ReservationIdTb.Size = new System.Drawing.Size(125, 27);
            this.ReservationIdTb.TabIndex = 0;
            this.ReservationIdTb.Text = "Reservation Id";
            // 
            // Datein
            // 
            this.Datein.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.CalendarForeColor = System.Drawing.Color.Crimson;
            this.Datein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.Location = new System.Drawing.Point(88, 293);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(244, 24);
            this.Datein.TabIndex = 11;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // AddReservaBtn
            // 
            this.AddReservaBtn.Location = new System.Drawing.Point(11, 424);
            this.AddReservaBtn.Name = "AddReservaBtn";
            this.AddReservaBtn.Size = new System.Drawing.Size(94, 29);
            this.AddReservaBtn.TabIndex = 13;
            this.AddReservaBtn.Text = "ADD";
            this.AddReservaBtn.UseVisualStyleBackColor = true;
            this.AddReservaBtn.Click += new System.EventHandler(this.AddReservaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "DateIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "DateOut";
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.Location = new System.Drawing.Point(397, 95);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersWidth = 51;
            this.ReservationGridView.RowTemplate.Height = 29;
            this.ReservationGridView.Size = new System.Drawing.Size(499, 293);
            this.ReservationGridView.TabIndex = 18;
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // Dateout
            // 
            this.Dateout.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dateout.CalendarForeColor = System.Drawing.Color.Crimson;
            this.Dateout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dateout.Location = new System.Drawing.Point(88, 355);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(244, 24);
            this.Dateout.TabIndex = 20;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // EditReservaBtn
            // 
            this.EditReservaBtn.Location = new System.Drawing.Point(133, 424);
            this.EditReservaBtn.Name = "EditReservaBtn";
            this.EditReservaBtn.Size = new System.Drawing.Size(94, 29);
            this.EditReservaBtn.TabIndex = 21;
            this.EditReservaBtn.Text = "EDIT";
            this.EditReservaBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteReservaBtn
            // 
            this.DeleteReservaBtn.Location = new System.Drawing.Point(249, 424);
            this.DeleteReservaBtn.Name = "DeleteReservaBtn";
            this.DeleteReservaBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteReservaBtn.TabIndex = 22;
            this.DeleteReservaBtn.Text = "DELETE";
            this.DeleteReservaBtn.UseVisualStyleBackColor = true;
            // 
            // totalAcompTb
            // 
            this.totalAcompTb.Location = new System.Drawing.Point(207, 247);
            this.totalAcompTb.Name = "totalAcompTb";
            this.totalAcompTb.Size = new System.Drawing.Size(125, 27);
            this.totalAcompTb.TabIndex = 25;
            this.totalAcompTb.Text = "Total Acomp";
            // 
            // pagamentoIdTb
            // 
            this.pagamentoIdTb.Location = new System.Drawing.Point(150, 210);
            this.pagamentoIdTb.Name = "pagamentoIdTb";
            this.pagamentoIdTb.Size = new System.Drawing.Size(125, 27);
            this.pagamentoIdTb.TabIndex = 26;
            // 
            // roomcb
            // 
            this.roomcb.FormattingEnabled = true;
            this.roomcb.Location = new System.Drawing.Point(182, 112);
            this.roomcb.Name = "roomcb";
            this.roomcb.Size = new System.Drawing.Size(151, 28);
            this.roomcb.TabIndex = 27;
            // 
            // clientIdcb
            // 
            this.clientIdcb.FormattingEnabled = true;
            this.clientIdcb.Location = new System.Drawing.Point(119, 69);
            this.clientIdcb.Name = "clientIdcb";
            this.clientIdcb.Size = new System.Drawing.Size(151, 28);
            this.clientIdcb.TabIndex = 28;
            // 
            // funcionarioIdcb
            // 
            this.funcionarioIdcb.FormattingEnabled = true;
            this.funcionarioIdcb.Location = new System.Drawing.Point(150, 161);
            this.funcionarioIdcb.Name = "funcionarioIdcb";
            this.funcionarioIdcb.Size = new System.Drawing.Size(151, 28);
            this.funcionarioIdcb.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cliente Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Numero do Quarto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Funcionario Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Pagamento Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Total Acompanhantes";
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.funcionarioIdcb);
            this.Controls.Add(this.clientIdcb);
            this.Controls.Add(this.roomcb);
            this.Controls.Add(this.pagamentoIdTb);
            this.Controls.Add(this.totalAcompTb);
            this.Controls.Add(this.DeleteReservaBtn);
            this.Controls.Add(this.EditReservaBtn);
            this.Controls.Add(this.Dateout);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddReservaBtn);
            this.Controls.Add(this.Datein);
            this.Controls.Add(this.ReservationIdTb);
            this.Name = "FrmReserva";
            this.Text = "FrmReserva";
            this.Load += new System.EventHandler(this.FrmReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).EndInit();
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
    }
}