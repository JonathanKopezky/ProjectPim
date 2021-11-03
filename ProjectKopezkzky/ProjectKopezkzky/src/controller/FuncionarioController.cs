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
        Funcionario funcionario = new Funcionario();
        FuncionarioRepository funcionarioRepository = new FuncionarioRepository();

        public FuncionarioController() { }

        public bool createFuncionario(Funcionario funcionario)
        {
            return funcionarioRepository.createFuncionario(funcionario);
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
