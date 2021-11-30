using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.model
{
    public class DisponibilidadeQuarto
    {
        public int id { get; set; }
        public int quartoId { get; set; }
        public int reservaId { get; set; }
        public int funcionarioId { get; set; }
        public DateTime dataQuartoOcupado { get; set; }

    }
}
