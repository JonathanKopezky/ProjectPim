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
        


        public ClienteController() 
        {
            
        }

        public bool VerificaCad(Cliente Cliente) 
        {
            ClienteRepository ClienteRepository = new ClienteRepository();
            MessageBox.Show("chegou no Controle");
            // Se nao forem vazio , eu mando para o repository  
            if (!string.IsNullOrEmpty(Cliente.nome) ||
                !string.IsNullOrEmpty(Cliente.dataNascimento) ||
                !string.IsNullOrEmpty(Cliente.email) ||
                !string.IsNullOrEmpty(Cliente.endereco) ||
                !string.IsNullOrEmpty(Cliente.numero) ||
                !string.IsNullOrEmpty(Cliente.CEP) ||
                !string.IsNullOrEmpty(Cliente.estado) ||
                !string.IsNullOrEmpty(Cliente.CPF) ||
                !string.IsNullOrEmpty(Cliente.telefone) ||
                !string.IsNullOrEmpty(Cliente.complemento) ||
                !string.IsNullOrEmpty(Cliente.cidade) ||
                !string.IsNullOrEmpty(Cliente.pais)
               )
            {
                 ClienteRepository.CriarCadCliente(Cliente);
            }
            else
            {
                return false;
            }

            return true;
        }

       
    }

}
