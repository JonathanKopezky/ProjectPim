
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
            this.ClientIdTb = new System.Windows.Forms.TextBox();
            this.RommNumberTb = new System.Windows.Forms.TextBox();
            this.Datein = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddReservaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReservationGridView = new System.Windows.Forms.DataGridView();
            this.Dateout = new System.Windows.Forms.DateTimePicker();
            this.EditReservaBtn = new System.Windows.Forms.Button();
            this.DeleteReservaBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.funcionarioTb = new System.Windows.Forms.TextBox();
            this.totalAcompTb = new System.Windows.Forms.TextBox();
            this.pagamentoIdTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReservationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservationIdTb
            // 
            this.ReservationIdTb.Location = new System.Drawing.Point(54, 62);
            this.ReservationIdTb.Name = "ReservationIdTb";
            this.ReservationIdTb.Size = new System.Drawing.Size(125, 27);
            this.ReservationIdTb.TabIndex = 0;
            this.ReservationIdTb.Text = "Reservation Id";
            // 
            // ClientIdTb
            // 
            this.ClientIdTb.Location = new System.Drawing.Point(54, 118);
            this.ClientIdTb.Name = "ClientIdTb";
            this.ClientIdTb.Size = new System.Drawing.Size(125, 27);
            this.ClientIdTb.TabIndex = 1;
            this.ClientIdTb.Text = "Client Id";
            // 
            // RommNumberTb
            // 
            this.RommNumberTb.Location = new System.Drawing.Point(54, 173);
            this.RommNumberTb.Name = "RommNumberTb";
            this.RommNumberTb.Size = new System.Drawing.Size(125, 27);
            this.RommNumberTb.TabIndex = 2;
            this.RommNumberTb.Text = "Romm Number";
            // 
            // Datein
            // 
            this.Datein.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.CalendarForeColor = System.Drawing.Color.Crimson;
            this.Datein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.Location = new System.Drawing.Point(88, 294);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(244, 24);
            this.Datein.TabIndex = 11;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 27);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Reservation Search";
            // 
            // AddReservaBtn
            // 
            this.AddReservaBtn.Location = new System.Drawing.Point(12, 424);
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
            this.label2.Location = new System.Drawing.Point(12, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "DateOut";
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.Location = new System.Drawing.Point(374, 96);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersWidth = 51;
            this.ReservationGridView.RowTemplate.Height = 29;
            this.ReservationGridView.Size = new System.Drawing.Size(480, 343);
            this.ReservationGridView.TabIndex = 18;
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
            this.EditReservaBtn.Location = new System.Drawing.Point(132, 424);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(679, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 23;
            this.button4.Text = "Seach";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // funcionarioTb
            // 
            this.funcionarioTb.Location = new System.Drawing.Point(54, 229);
            this.funcionarioTb.Name = "funcionarioTb";
            this.funcionarioTb.Size = new System.Drawing.Size(125, 27);
            this.funcionarioTb.TabIndex = 24;
            this.funcionarioTb.Text = "Funcionario Id";
            // 
            // totalAcompTb
            // 
            this.totalAcompTb.Location = new System.Drawing.Point(218, 173);
            this.totalAcompTb.Name = "totalAcompTb";
            this.totalAcompTb.Size = new System.Drawing.Size(125, 27);
            this.totalAcompTb.TabIndex = 25;
            this.totalAcompTb.Text = "Total Acomp";
            // 
            // pagamentoIdTb
            // 
            this.pagamentoIdTb.Location = new System.Drawing.Point(218, 229);
            this.pagamentoIdTb.Name = "pagamentoIdTb";
            this.pagamentoIdTb.Size = new System.Drawing.Size(125, 27);
            this.pagamentoIdTb.TabIndex = 26;
            this.pagamentoIdTb.Text = "Pagagemnto Id";
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 482);
            this.Controls.Add(this.pagamentoIdTb);
            this.Controls.Add(this.totalAcompTb);
            this.Controls.Add(this.funcionarioTb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DeleteReservaBtn);
            this.Controls.Add(this.EditReservaBtn);
            this.Controls.Add(this.Dateout);
            this.Controls.Add(this.ReservationGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddReservaBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Datein);
            this.Controls.Add(this.RommNumberTb);
            this.Controls.Add(this.ClientIdTb);
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
        private System.Windows.Forms.TextBox ClientIdTb;
        private System.Windows.Forms.TextBox RommNumberTb;
        private System.Windows.Forms.DateTimePicker Datein;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddReservaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ReservationGridView;
        private System.Windows.Forms.DateTimePicker Dateout;
        private System.Windows.Forms.Button EditReservaBtn;
        private System.Windows.Forms.Button DeleteReservaBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox funcionarioTb;
        private System.Windows.Forms.TextBox totalAcompTb;
        private System.Windows.Forms.TextBox pagamentoIdTb;
    }
}