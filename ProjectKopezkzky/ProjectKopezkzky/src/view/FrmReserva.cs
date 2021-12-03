using ProjectKopezkzky.src.controller;
using ProjectKopezkzky.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKopezkzky.src.view
{
    public partial class FrmReserva : Form
    {
        Reserva reserva = new Reserva();
        ReservaController reservaController = new ReservaController();
        List<Reserva> listReserva;

        public FrmReserva()
        {
            InitializeComponent();
            listReserva = reservaController.CarregarReservas();
            this.ReservationGridView.DataSource = listReserva;
        }
        DateTime today;
        private void FrmReserva_Load(object sender, EventArgs e)
        {
            today = Datein.Value;
        }

        private void Datein_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Datein.Value, today);
            if(res < 0)           
                MessageBox.Show("Data errada para reserva");   
        }

        private void Dateout_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(Dateout.Value, Datein.Value);
            if (res < 0)
                MessageBox.Show("DateOut errado, tente novamente");
        }

        private void AddReservaBtn_Click(object sender, EventArgs e)
        {
            reserva.id = int.Parse(ReservationIdTb.Text);
            reserva.responsavelId = int.Parse(ClientIdTb.Text);
            reserva.quartoId = int.Parse(RommNumberTb.Text);
            reserva.funcionarioId = int.Parse(funcionarioTb.Text);
            reserva.totalAcompanhante = int.Parse(totalAcompTb.Text);
            reserva.dataCheckIn = Datein.Value;
            reserva.dataCheckOut = Dateout.Value;
            reserva.dataReserva = DateTime.Now;
            TimeSpan date = Convert.ToDateTime(Dateout.Value) - Convert.ToDateTime(Datein.Value);
            int totalDias = date.Days;
            MessageBox.Show(totalDias.ToString());
            reserva.quantDiaria = totalDias;
            //Convert.ToInt32(Dateout.Value.Day - Datein.Value.Day);
            reserva.pagamentoId = int.Parse(pagamentoIdTb.Text);

            reservaController.CreateReserva(reserva);
            MessageBox.Show("Reserva Adicionada com sucesso");
        }

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
            listReserva = reservaController.CarregarReservas();

            ReservationGridView.DataSource = listReserva;
        }
    }
}
