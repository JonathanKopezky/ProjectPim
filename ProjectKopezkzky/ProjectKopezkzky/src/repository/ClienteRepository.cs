using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.config;
using System.Windows.Forms;
using ProjectKopezkzky.src.controller;

namespace ProjectKopezkzky.src.repository
{
    public class ClienteRepository
    {
        SqlDataReader dr;
        SqlCommand Comando;
        Connection conn = new Connection();

        //VERICAR 
        public bool VerificaCad(Cliente cliente)
        {
            //Procurar no banco se existe  
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT * FROM Cliente WHERE CPF = @cpf";

            //PARAMETROS
            Comando.Parameters.AddWithValue("@cpf", cliente.CPF);

            try
            {
                Comando.Connection = conn.connect();
                // verificando se tem linhas com os parametro 
                dr = Comando.ExecuteReader();
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
        public bool CriarCadCliente(Cliente cliente)
        {
            Comando = new SqlCommand();
            //Essa funcao ira pegar o texto das textbox criar no banco 
            // Comando para inserir os dados no banco 
            Comando.CommandText = "INSERT INTO Cliente VALUES(@Nome, @Sobrenome, @RG, @CPF, @Email, @Telefone, @Endereço, @CEP, @Numero, @Complemento, @Cidade, @Estado, @Genero, @Pais, @Data_nascimento, @Ativo ,@Senha)";
            //fim 

            //Preenchendo os as colunas da tabelas
            Comando.Parameters.AddWithValue("@Nome", cliente.nome);
            Comando.Parameters.AddWithValue("@Sobrenome", cliente.sobrenome);
            Comando.Parameters.AddWithValue("@RG", cliente.RG);
            Comando.Parameters.AddWithValue("@CPF", cliente.CPF);
            Comando.Parameters.AddWithValue("@Email", cliente.email);
            Comando.Parameters.AddWithValue("@Telefone", cliente.telefone);
            Comando.Parameters.AddWithValue("@Endereço", cliente.endereco);
            Comando.Parameters.AddWithValue("@CEP", cliente.CEP);
            Comando.Parameters.AddWithValue("@Numero", cliente.numero);
            Comando.Parameters.AddWithValue("@Complemento", cliente.complemento);
            Comando.Parameters.AddWithValue("@Cidade", cliente.cidade);
            Comando.Parameters.AddWithValue("@Estado", cliente.estado);
            Comando.Parameters.AddWithValue("@Genero", cliente.genero);
            Comando.Parameters.AddWithValue("@Pais", cliente.pais);
            Comando.Parameters.AddWithValue("@Data_nascimento", cliente.dataNascimento);
            Comando.Parameters.AddWithValue("@Ativo", 1);
            Comando.Parameters.AddWithValue("@Senha", cliente.senha);
            //FIM

            try
            {

                Comando.Connection = conn.connect();

                Comando.ExecuteNonQuery();

            }
            catch (SqlException)
            {

            }
            finally
            {


                conn.disconnect();
            }
            return true;
        }

        public bool AtualizarCadCliente(Cliente cliente) { return false; }
        public bool DeletarCadCliente(Cliente cliente) { return false; }
        public bool ConsultaCadCliente(Cliente cliente) { return false; }



    }
}
