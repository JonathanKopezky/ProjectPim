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
    public class ClienteController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        Cliente cliente = new Cliente();

        public ClienteController() { }

        public bool VerificaCad(Cliente cliente)
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
            return false;
        }

    }

}
