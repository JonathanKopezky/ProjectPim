using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.controller
{
    public class ReservaController
    {
        Reserva reserva = new Reserva();
        ReservaRepository reservaRepository = new ReservaRepository();

        public ReservaController() { }

        public bool CreateReserva(Reserva reserva)
        {
            if (reservaRepository.AdicionarReserva(reserva))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AtualizarReserva(Reserva reserva)
        {
            if (reservaRepository.AtualizarReservaValida(reserva))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public bool DeletReserva(Reserva reserva)
       // {
         //   if (reservaRepository.DeletarReserva(reserva))
          //  {
           //     return true;
          //  else
           // {

           //     return false;
           // }
       // }

        public Reserva ConsultarReserva(Reserva reserva)
        {   // consultar se tiver vai retornar true se não false
            Reserva result = reservaRepository.VerificaReserva(reserva);
            return result;   
        }
    }
}
