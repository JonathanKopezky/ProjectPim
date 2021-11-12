using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;

namespace ProjectKopezkzky.src.controller
{
    public class ReservaController
    {
        Reserva reserva = new Reserva();
        Quarto quarto = new Quarto();
        ReservaRepository reservaRepository = new ReservaRepository();
 
        public bool CriarReserva()
        {

            return true;

        }
        public Object ConsultarReserva(Reserva reserva)
        {
            return reserva;
        } 
        
        public Object EditarReserva(Reserva reserva)
        {
            return reserva;
        }

        public bool DeletarReserva()
        {
            return true;
        }

        public List<Reserva> ConsultarQuartosOcupados(Reserva reserva)
        {
            var reservaOcupada = reservaRepository.ConsultarReservasPorData(reserva);


            var quartos = new List<Reserva>();

            return quartos;
        }     
    }
}
