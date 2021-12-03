﻿
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
            this.ReservationIdTb.Location = new System.Drawing.Point(47, 46);
            this.ReservationIdTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReservationIdTb.Name = "ReservationIdTb";
            this.ReservationIdTb.Size = new System.Drawing.Size(110, 23);
            this.ReservationIdTb.TabIndex = 0;
            this.ReservationIdTb.Text = "Reservation Id";
            // 
            // ClientIdTb
            // 
            this.ClientIdTb.Location = new System.Drawing.Point(47, 88);
            this.ClientIdTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientIdTb.Name = "ClientIdTb";
            this.ClientIdTb.Size = new System.Drawing.Size(110, 23);
            this.ClientIdTb.TabIndex = 1;
            this.ClientIdTb.Text = "Client Id";
            // 
            // RommNumberTb
            // 
            this.RommNumberTb.Location = new System.Drawing.Point(47, 130);
            this.RommNumberTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RommNumberTb.Name = "RommNumberTb";
            this.RommNumberTb.Size = new System.Drawing.Size(110, 23);
            this.RommNumberTb.TabIndex = 2;
            this.RommNumberTb.Text = "Romm Number";
            // 
            // Datein
            // 
            this.Datein.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.CalendarForeColor = System.Drawing.Color.Crimson;
            this.Datein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Datein.Location = new System.Drawing.Point(77, 220);
            this.Datein.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datein.Name = "Datein";
            this.Datein.Size = new System.Drawing.Size(214, 21);
            this.Datein.TabIndex = 11;
            this.Datein.ValueChanged += new System.EventHandler(this.Datein_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Reservation Search";
            // 
            // AddReservaBtn
            // 
            this.AddReservaBtn.Location = new System.Drawing.Point(10, 318);
            this.AddReservaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddReservaBtn.Name = "AddReservaBtn";
            this.AddReservaBtn.Size = new System.Drawing.Size(82, 22);
            this.AddReservaBtn.TabIndex = 13;
            this.AddReservaBtn.Text = "ADD";
            this.AddReservaBtn.UseVisualStyleBackColor = true;
            this.AddReservaBtn.Click += new System.EventHandler(this.AddReservaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "DateIn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "DateOut";
            // 
            // ReservationGridView
            // 
            this.ReservationGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ReservationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservationGridView.Location = new System.Drawing.Point(327, 72);
            this.ReservationGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReservationGridView.Name = "ReservationGridView";
            this.ReservationGridView.RowHeadersWidth = 51;
            this.ReservationGridView.RowTemplate.Height = 29;
            this.ReservationGridView.Size = new System.Drawing.Size(1070, 581);
            this.ReservationGridView.TabIndex = 18;
            this.ReservationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReservationGridView_CellContentClick);
            // 
            // Dateout
            // 
            this.Dateout.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dateout.CalendarForeColor = System.Drawing.Color.Crimson;
            this.Dateout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dateout.Location = new System.Drawing.Point(77, 266);
            this.Dateout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dateout.Name = "Dateout";
            this.Dateout.Size = new System.Drawing.Size(214, 21);
            this.Dateout.TabIndex = 20;
            this.Dateout.ValueChanged += new System.EventHandler(this.Dateout_ValueChanged);
            // 
            // EditReservaBtn
            // 
            this.EditReservaBtn.Location = new System.Drawing.Point(116, 318);
            this.EditReservaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditReservaBtn.Name = "EditReservaBtn";
            this.EditReservaBtn.Size = new System.Drawing.Size(82, 22);
            this.EditReservaBtn.TabIndex = 21;
            this.EditReservaBtn.Text = "EDIT";
            this.EditReservaBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteReservaBtn
            // 
            this.DeleteReservaBtn.Location = new System.Drawing.Point(218, 318);
            this.DeleteReservaBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteReservaBtn.Name = "DeleteReservaBtn";
            this.DeleteReservaBtn.Size = new System.Drawing.Size(82, 22);
            this.DeleteReservaBtn.TabIndex = 22;
            this.DeleteReservaBtn.Text = "DELETE";
            this.DeleteReservaBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 28);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 22);
            this.button4.TabIndex = 23;
            this.button4.Text = "Seach";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // funcionarioTb
            // 
            this.funcionarioTb.Location = new System.Drawing.Point(47, 172);
            this.funcionarioTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.funcionarioTb.Name = "funcionarioTb";
            this.funcionarioTb.Size = new System.Drawing.Size(110, 23);
            this.funcionarioTb.TabIndex = 24;
            this.funcionarioTb.Text = "Funcionario Id";
            // 
            // totalAcompTb
            // 
            this.totalAcompTb.Location = new System.Drawing.Point(191, 130);
            this.totalAcompTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalAcompTb.Name = "totalAcompTb";
            this.totalAcompTb.Size = new System.Drawing.Size(110, 23);
            this.totalAcompTb.TabIndex = 25;
            this.totalAcompTb.Text = "Total Acomp";
            // 
            // pagamentoIdTb
            // 
            this.pagamentoIdTb.Location = new System.Drawing.Point(191, 172);
            this.pagamentoIdTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pagamentoIdTb.Name = "pagamentoIdTb";
            this.pagamentoIdTb.Size = new System.Drawing.Size(110, 23);
            this.pagamentoIdTb.TabIndex = 26;
            this.pagamentoIdTb.Text = "Pagagemnto Id";
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 781);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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