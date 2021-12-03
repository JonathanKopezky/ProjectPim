using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.model
{
   public class Cliente : Pessoa 
   {
        public void LimpaCliente()
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
        }
    }
}
