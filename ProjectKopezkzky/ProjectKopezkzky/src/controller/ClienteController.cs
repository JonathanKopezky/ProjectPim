using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;

namespace ProjectKopezkzky.src.controller
{
    public class ClienteController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        Cliente cliente = new Cliente();

        public ClienteController() { }

        public bool CreateCadCliente(Cliente cliente)
        {
            if (clienteRepository.VerificaCad(cliente))
            {
                //se o verificador nao encontrar no banco ele cadastra
                return false;
            }
            else
            {
                return clienteRepository.CriarCadCliente(cliente);
            }
        }


        public bool AtualizaCad(Cliente cliente)
        {
            return false;
        }

        public bool DeletCad(Cliente cliente)
        {
            if (clienteRepository.DeletarCadCliente(cliente)) 
            {
                return true;
            }
            else
            {

            return false;
            }
        }

        public bool ConsultarCad(Cliente cliente)
        {   // consultar se tiver vai retornar true se não false
            if (clienteRepository.VerificaCad(cliente))
            {
                
                return true;
            }
            else
            {
                return false ;
            }


        }

    }
}
