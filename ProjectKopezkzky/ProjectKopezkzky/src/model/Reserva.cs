using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.model
{
    public class Reserva
    {
        public int id { get; set; }
        public int quartoId { get; set; }
        public int pagamentoId { get; set; }
        public int quantDiaria { get; set; }
        public int responsavelId { get; set; }
        public DateTime dataCheckIn { get; set; }
        public DateTime dataCheckOut { get; set; }
        public int totalAcompanhante { get; set; }
        public DateTime dataReserva { get; set; }
        public String status { get; set; }

        public void LimparReserva()
        {
            id = 0;
            quartoId = 0;
            pagamentoId = 0;
            quantDiaria = 0;
            responsavelId = 0;
            //dataCheckIn = DateTime.Parse("0000-00-00 00:00:00");
            //dataCheckOut = DateTime.Parse("0000-00-00 00:00:00");
            totalAcompanhante = 0;
            //dataReserva = DateTime.Parse("0000-00-00 00:00:00");
            status = "";
        }
    }
}
