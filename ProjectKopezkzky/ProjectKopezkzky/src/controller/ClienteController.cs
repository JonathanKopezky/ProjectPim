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
        public ClienteRepository clienteRepository = new ClienteRepository();
        public Cliente cliente = new Cliente();

        public ClienteController()
        {


        }

        public bool CreateCadCliente(Cliente cliente)
        {


            if (clienteRepository.CriarCadCliente(cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool AtualizaCad(Cliente cliente)
        {
            if (clienteRepository.AtualizarCadCliente(cliente))
            {
                return true;
            }
            else
            {
                return false;
            }
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
                return false;
            }


        }

    }
}
