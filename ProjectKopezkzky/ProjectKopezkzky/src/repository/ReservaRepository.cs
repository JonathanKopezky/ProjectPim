using ProjectKopezkzky.src.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.repository
{
    public class ReservaRepository
    {
        Reserva reserva = new Reserva();
        public List<Reserva> ConsultarReservasPorData(Reserva reserva)
        {
            //Fazer uma consulta para trazer todos os Reserva.quartoId que estejam entre as datas de checkin e chekout que recebere
            //adicionar a uma array
            //fazer um forech nessa array adcionando o valor do quartoID a lista quartosOcupados 
            var quartosOcupados = new List<Reserva>();
            return quartosOcupados;
        }

        public bool CriarReserva(Reserva reserva)
        {
            return true;
        }

        public Object ConsultarReserva(Reserva reserva)
        {
            return reserva;
        }

        public bool DeletarReserva()
        {
            return false;
        }

        public Object EditarReserva (Reserva reserva)
        {
            return reserva;
        }
    }
}
