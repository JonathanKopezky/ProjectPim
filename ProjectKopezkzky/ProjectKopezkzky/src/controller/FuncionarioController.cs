using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.repository;

namespace ProjectKopezkzky.src.controller
{
    public class FuncionarioController
    {
        FuncionarioRepository funcionarioRepository = new FuncionarioRepository();

        public FuncionarioController() { }

        public bool createFuncionario(Funcionario funcionario)
        {
            return true;
        }
        public bool updateFuncionario(Funcionario funcionario)
        {
            return funcionarioRepository.updateFuncionario(funcionario);
        }
        public bool deleteFuncionario(Funcionario funcionario)
        {
            return funcionarioRepository.deleteFuncionario(funcionario);
        }
    }
}
