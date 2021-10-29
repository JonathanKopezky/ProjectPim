using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.config;

namespace ProjectKopezkzky.src.repository
{
    class LoginRepository
    {
        public string message;
        SqlDataReader dr;

        SqlCommand cmd = new SqlCommand();
        Connection conn = new Connection();

        public bool getOneLogin(Funcionario funcionario)
        {
            MessageBox.Show(funcionario.CPF);
            MessageBox.Show(funcionario.senha);

            cmd.CommandText = "SELECT * FROM Funcionarios WHERE CPF = @cpf and senha = @senha ";

            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);

            try
            {
                cmd.Connection = conn.connect();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                conn.disconnect();
            }
        }
    }
}
