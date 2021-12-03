using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.model
{
    public class Funcionario : Pessoa
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

        public void LimpaFuncionario()
        {
            id = 0;
            nome = "";
            sobrenome = "";
            RG = "";
            CPF = "";
            email = "";
            telefone = "";
            endereco = "";
            CEP = "";
            numero = 0;
            complemento = "";
            cidade = "";
            estado = "";
            pais = "";
            genero = "";
            dataNascimento = "";
            status = "";
            senha = "";
            tituloEleitor = "";
            reservista = "";
            CNH = "";
            estadoCivil = "";
            observacoes = "";
            nomePai = "";
            nomeMae = "";
            dependentes = 0;
            formacaoAcademica = "";
        }
    }
}
