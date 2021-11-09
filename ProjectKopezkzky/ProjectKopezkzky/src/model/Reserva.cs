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
        public DateTime dataChckIn { get; set; }
        public DateTime dataCheckOut { get; set; }
        public int totalAcompanhante { get; set; }
        public DateTime dataReserva { get; set; }
        public String status { get; set; } 
    }
}
