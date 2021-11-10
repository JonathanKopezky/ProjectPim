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
        public bool createFuncionario(Funcionario funcionario)
        {

            if (!funcionarioRepository.consultaFuncionarioCadastro(funcionario))
            {
                return funcionarioRepository.createFuncionario(funcionario);
            }
            else
            {
                MessageBox.Show("User already exists");
                return false;
            }
        }
        public bool updateFuncionario(Funcionario funcionario)
        {
            return true;
        }
        public bool deleteFuncionario(Funcionario funcionario)
        {
            return true;
        }

    }
}
