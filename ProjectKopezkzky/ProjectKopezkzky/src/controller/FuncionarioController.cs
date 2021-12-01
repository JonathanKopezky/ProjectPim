using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using ProjectKopezkzky.src.repository;
using ProjectKopezkzky.src.model;

namespace ProjectKopezkzky.src.controller
{
    public class FuncionarioController
    {
        FuncionarioRepository funcionarioRepository = new FuncionarioRepository();
        public FuncionarioController()
        {

        }
        public bool verifica(Funcionario funcionario)
        {   // verifica se tem o cadastro 
           
            if (funcionarioRepository.consultaFuncionarioCadastro(funcionario))
            {
              
                return true;
            }
            else
            {
              
                return false;
            }

        }
        public bool createFuncionario(Funcionario funcionario)
        {

            if (funcionarioRepository.createFuncionario(funcionario))
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public bool updateFuncionario(Funcionario funcionario)
        {
            MessageBox.Show(funcionario.CPF);
            if (funcionarioRepository.updateFuncionario(funcionario))
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        public bool deleteFuncionario(Funcionario funcionario)
        {
            if (funcionarioRepository.deleteFuncionario(funcionario))
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public Funcionario getFuncionario(Funcionario funcionario)

        {// pega o funcionario no banco 
            Funcionario result = funcionarioRepository.getFuncionario(funcionario);
            return result;
        }

    }
}
