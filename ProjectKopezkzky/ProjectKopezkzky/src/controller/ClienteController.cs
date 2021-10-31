using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKopezkzky.src.controller
{
    class ClienteController

    {
        public String message = "";


        ClienteRepository clienteRepository;

        public ClienteController()
        {
            new ClienteRepository();
        }

        public bool VerificaCad(Cliente cliente)
        {
            if (!cliente.nome.Equals("") && !cliente.sobrenome.Equals("") &&
               !cliente.CPF.Equals("") && !cliente.RG.Equals("") &&
               !cliente.dataNascimento.Equals("") && !cliente.genero.Equals("") &&
               !cliente.telefone.Equals("") && !cliente.email.Equals("") &&
               !cliente.email.Equals("") && !cliente.endereco.Equals("") &&
               !cliente.CEP.Equals("") && !cliente.numero.Equals("") &&
               !cliente.estado.Equals("") && !cliente.cidade.Equals("") &&
               !cliente.pais.Equals("") && !cliente.complemento.Equals("") &&
               !cliente.senha.Equals(""))
            {
                clienteRepository.CriarCadCliente(cliente);
            }
            else 
            {
                this.message = "Preencha todos os campos !";
            }

            return true;
        }



    }

}
