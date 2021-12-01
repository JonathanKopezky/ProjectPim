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
using System.Data;

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
            cmd.CommandText = "SELECT CPF FROM Funcionario WHERE CPF = @cpf";
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);

            try
            {
                cmd.Connection = conn.connect();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("tem" + funcionario.CPF);
                    return true;
                }
                else
                {
                    MessageBox.Show("nao tem" + funcionario.CPF);
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
            cmd = new SqlCommand();
           

           
            cmd.CommandText = "UPDATE Funcionario  SET Status = @Status  WHERE  CPF = @cpf";
            cmd.Parameters.AddWithValue("@Status", funcionario.status);
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);

            try
            {

                cmd.Connection = conn.connect();

                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                return false;
            }
            finally 
            {
                conn.disconnect();
                
            }
            

             return true;
        }
     
        public bool updateFuncionario(Funcionario funcionario)
        {
            cmd = new SqlCommand();

            cmd.Connection = conn.connect();

            cmd.CommandText =
                "UPDATE Funcionario SET Nome=@nome, Sobrenome=@sobrenome, Titulo_eleitor=@tituloEleitor, Reservista=@reservista, CNH=@cnh, Telefone=@telefone, " +
                "Endereco=@endereco, CEP=@cep, Numero=@numero, Complemento=@complemento, Cidade=@cidade, Estado=@estado, Pais=@pais, Email=@email, Genero=@genero, " +
                "Estado_civil=@estadiCivil, Observacoes=@observacoes, Nome_pai=@nomePai, Nome_mae=@nomeMae, Dependentes=@dependentes, FormacaoAcademica=@formacaoAcademica, Data_nascimento@dataNascimento," +
                " Senha=@senha WHERE CPF =@cpf";



            cmd.Parameters.AddWithValue("@nome", funcionario.nome);
            cmd.Parameters.AddWithValue("@sobrenome", funcionario.sobrenome);
            cmd.Parameters.AddWithValue("@rg", funcionario.RG);
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
            cmd.Parameters.AddWithValue("@senha", funcionario.senha);
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
           
            cmd.ExecuteNonQuery();
            MessageBox.Show(funcionario.CPF);
            return true;
        }

        public Funcionario getFuncionario(Funcionario funcionario)
        { //Procurar no banco se existe  
            cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Funcionario WHERE CPF = @cpf";

            //PARAMETROS
            cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
          
            cmd.Connection = conn.connect();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {

                // verificando se tem linhas com os parametro 
                using (dr)
                {

                    while (dr.Read())
                    {

                        funcionario.nome = dr[0].ToString();
                        funcionario.sobrenome = dr[1].ToString();
                        funcionario.RG = dr[2].ToString();
                        funcionario.CPF = dr[3].ToString();
                        funcionario.tituloEleitor = dr[4].ToString();
                        funcionario.reservista = dr[5].ToString();
                        funcionario.CNH = dr[6].ToString();
                        funcionario.telefone = dr[7].ToString();
                        funcionario.endereco = dr[8].ToString();
                        funcionario.CEP = dr[9].ToString();
                        funcionario.numero = Convert.ToInt32(dr[10]);
                        funcionario.complemento = dr[11].ToString();
                        funcionario.cidade = dr[12].ToString();
                        funcionario.estado = dr[13].ToString();
                        funcionario.pais = dr[14].ToString();
                        funcionario.email = dr[15].ToString();
                        funcionario.genero = dr[16].ToString();
                        funcionario.estadoCivil = dr[17].ToString();
                        funcionario.observacoes = dr[18].ToString();
                        funcionario.nomePai = dr[19].ToString();
                        funcionario.nomeMae = dr[20].ToString();
                        funcionario.dependentes = dr.GetInt32(21);
                        funcionario.formacaoAcademica = dr[22].ToString();
                        funcionario.dataNascimento = dr[23].ToString();
                        funcionario.senha = dr[25].ToString();
                    }

                    return funcionario;
                }
            }
            else
            {
                conn.disconnect();
                
                return funcionario;
            }

        }


    }
}
