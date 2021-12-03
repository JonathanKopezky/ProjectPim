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
    public partial class TesteReserva : Form
    {
        ReservaController reservaController = new ReservaController();
        Reserva reserva = new Reserva(); 

        public TesteReserva()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            reserva.id = int.Parse(textImputCPF.Text);
            reservaController.ConsultarReserva(reserva);
            if(reserva.id == 0)
            {
                MessageBox.Show("Reserva não encontrada!");
            }
            else
            {
                textQuartoId.Text = reserva.quartoId.ToString();
                textPagamentoId.Text = reserva.pagamentoId.ToString();
                textDataCheckIn.Text = reserva.dataCheckIn.ToString();
            }
        }
    }
}
