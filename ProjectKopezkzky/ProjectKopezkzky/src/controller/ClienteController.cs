using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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


        public Cliente getCadCliente(Cliente cliente)
        {   //funcao pega o cliente da consulta do banco
            Cliente result = clienteRepository.AlteraCliente(cliente);
           
            return result;


        }


        public bool setCadCliente(Cliente cliente)
        {   //funcao insere o cliente no baco 
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

        public DataTable grid()
        {
            return clienteRepository.Grid();
        }
    }
}
