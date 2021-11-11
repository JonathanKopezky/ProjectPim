using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.model
{
        public  class Funcionario : Pessoa
    {
        public string tituloEleitor { get; set; }
        public string reservista { get; set; }
        public string CNH { get; set; }
        public string estadoCivil { get; set; }
        public string observacoes { get; set; }
        public string nomePai { get; set; }
        public string nomeMae { get; set; }
        public int dependentes { get; set; }
        public string formacaoAcademica { get; set; }
    }
}
