using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ProjectKopezkzky.src.controller
{
    public class ReservaController
    {
        Reserva reserva = new Reserva();
        ReservaRepository reservaRepository = new ReservaRepository();
        List<Reserva> listReservas;
        public ReservaController() { }

        public bool CreateReserva(Reserva reserva)
        {
            reserva.status = "ATIVO";
            MessageBox.Show(reserva.quartoId.ToString());
            if (reservaRepository.AdicionarReserva(reserva))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Reserva ConsultarReserva(Reserva reserva)
        {   // consultar se tiver vai retornar true se não false
            Reserva result = reservaRepository.VerificaReserva(reserva);
            return result;   
        }

        public DataTable grid() 
        {
            return reservaRepository.Grid();
        }

        public List<Reserva> CarregarReservas()
        {
            listReservas = reservaRepository.CarregarReservas();

            return listReservas;
        }

    }
}
