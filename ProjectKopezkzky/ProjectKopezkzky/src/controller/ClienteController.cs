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
        ClienteRepository clienteRepository = new ClienteRepository();
        Cliente cliente = new Cliente();

        public ClienteController() { }

        public bool VerificaCad(Cliente cliente)
        {
            bool verifica = clienteRepository.VerificaCad(cliente);
            
            if (verifica == false)
            {
                //se o verificador nao encontrar no banco ele cadastra
                clienteRepository.CriarCadCliente(cliente);
            }
            
                
            return false;
            
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
