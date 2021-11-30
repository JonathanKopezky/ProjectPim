using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.controller;
using System.Data.SqlClient;

using ProjectKopezkzky.src.config;

namespace ProjectKopezkzky.src.repository
{
    class FuncionarioRepository
    {
        Funcionario funcionario = new Funcionario();

        SqlDataReader dr;
        SqlCommand cmd;
        Connection conn = new Connection();


        public FuncionarioRepository()
        {
            
        }

        public bool consultaFuncionarioCadastro(Funcionario funcionario)
        {

            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Funcionario WHERE CPF = @cpf";
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);

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
            finally
            {
                conn.disconnect();
            }
        }

        public bool createFuncionario(Funcionario funcionario)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn.connect();

            cmd.CommandText =
                "INSERT INTO Funcionario VALUES(@nome, @sobrenome, @rg, @cpf, @tituloEleitor, @reservista, @cnh, @telefone, " +
                "@endereco, @cep, @numero, @complemento, @cidade, @estado, @pais, @email, @genero, " +
                "@estadiCivil, @observacoes, @nomePai, @nomeMae, @dependentes, @formacaoAcademica, @dataNascimento," +
                "@status, @senha)";



            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@sobrenome", funcionario.sobrenome);
            cmd.Parameters.AddWithValue("@rg", funcionario.RG);
             cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
             cmd.Parameters.AddWithValue("@tituloEleitor", funcionario.tituloEleitor);
             cmd.Parameters.AddWithValue("@reservista", funcionario.reservista);
             cmd.Parameters.AddWithValue("@cnh", funcionario.CNH);
             cmd.Parameters.AddWithValue("@telefone", funcionario.telefone);
             cmd.Parameters.AddWithValue("@endereco", funcionario.endereco);
             cmd.Parameters.AddWithValue("@cep", funcionario.CEP);
             cmd.Parameters.AddWithValue("@numero", funcionario.numero);
             cmd.Parameters.AddWithValue("@complemento", funcionario.complemento);
             cmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
             cmd.Parameters.AddWithValue("@estado", funcionario.estado);
             cmd.Parameters.AddWithValue("@pais", funcionario.pais);
             cmd.Parameters.AddWithValue("@email", funcionario.email);
             cmd.Parameters.AddWithValue("@genero", funcionario.genero);
             cmd.Parameters.AddWithValue("@estadiCivil", funcionario.estadoCivil);
             cmd.Parameters.AddWithValue("@observacoes", funcionario.observacoes);
             cmd.Parameters.AddWithValue("@nomePai", funcionario.nomePai);
             cmd.Parameters.AddWithValue("@nomeMae", funcionario.nomeMae);
             cmd.Parameters.AddWithValue("@dependentes", funcionario.dependentes);
             cmd.Parameters.AddWithValue("@formacaoAcademica", funcionario.formacaoAcademica);
             cmd.Parameters.AddWithValue("@dataNascimento", funcionario.dataNascimento);
             cmd.Parameters.AddWithValue("@status", funcionario.status);
             cmd.Parameters.AddWithValue("@senha", funcionario.senha);


            MessageBox.Show(cmd.CommandText.ToString());

            
            int rows = cmd.ExecuteNonQuery();
            MessageBox.Show(rows.ToString());
            conn.disconnect();
            return true;
        }

        public bool deleteFuncionario(Funcionario funcionario)
        {
            return true;
        }
     
        public bool updateFuncionario(Funcionario funcionario)
        {
            return true;
        }
            





    }
}
