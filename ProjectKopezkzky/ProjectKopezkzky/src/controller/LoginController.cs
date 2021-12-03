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
    class LoginController
    {
        LoginRepository loginRepository;

        public LoginController() { }

        public bool verifyLogin(Funcionario funcionario)
        {
            loginRepository = new LoginRepository();

            if (!string.IsNullOrEmpty(funcionario.CPF) || !string.IsNullOrEmpty(funcionario.senha))
            {
                return loginRepository.getOneLogin(funcionario);
            }
            else
            {
                return false;          
            }
        }
    }
}
