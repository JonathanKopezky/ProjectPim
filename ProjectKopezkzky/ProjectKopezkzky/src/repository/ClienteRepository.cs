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
        SqlCommand Comando = new SqlCommand();
        Connection conn = new Connection();
        Cliente cliente = new Cliente();

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


        public Cliente AlteraCliente(Cliente cliente)
        { //Procurar no banco se existe  
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT * FROM Cliente WHERE CPF = @cpf";

            //PARAMETROS
            Comando.Parameters.AddWithValue("@cpf", cliente.CPF);
            MessageBox.Show(cliente.CPF);
            Comando.Connection = conn.connect();
            dr = Comando.ExecuteReader();

            if (dr.HasRows)
            {
               
                // verificando se tem linhas com os parametro 
                using (dr)
                {
                   
                    while (dr.Read())
                    {
                       
                        cliente.nome = dr[0].ToString();
                        cliente.sobrenome = dr[1].ToString();
                        cliente.RG = dr[2].ToString();
                        cliente.CPF = dr[3].ToString();
                        cliente.email = dr[4].ToString();
                        cliente.telefone = dr[5].ToString();
                        cliente.endereco = dr[6].ToString();
                        cliente.CEP = dr[7].ToString();
                        cliente.numero = dr.GetInt32(8);
                        cliente.complemento = dr[9].ToString();
                        cliente.cidade = dr[10].ToString();
                        cliente.estado = dr[11].ToString();
                        cliente.genero = dr[12].ToString();
                        cliente.pais = dr[13].ToString();
                        cliente.dataNascimento = dr[14].ToString();
                        cliente.senha = dr[16].ToString();
                    }
                    
                    return cliente;
                }
            }
            else
            {
                conn.disconnect();
                cliente.LimpaCliente();
                return cliente;
            }
          
        }
        public bool CriarCadCliente(Cliente cliente)
        {
            Comando = new SqlCommand();
            //Essa funcao ira pegar o texto das textbox criar no banco 
            // Comando para inserir os dados no banco 
            Comando.CommandText = "INSERT INTO Cliente VALUES(@Nome, @Sobrenome, @RG, @CPF, @Email, @Telefone, @Endereço, @CEP, @Numero, @Complemento, @Cidade, @Estado, @Genero, @Pais, @Data_nascimento, @Status ,@Senha)";
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
            Comando.Parameters.AddWithValue("@Status", int.Parse(cliente.status));
            Comando.Parameters.AddWithValue("@Senha", cliente.senha);
            //FIM

            try
            {

                Comando.Connection = conn.connect();

                Comando.ExecuteNonQuery();

            }

            finally
            {


                conn.disconnect();
            }
            return true;
            cliente.LimpaCliente();
        }

        public bool AtualizarCadCliente(Cliente cliente)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE Cliente SET Nome=@nome, Sobrenome=@sobrenome, Genero=@genero, Telefone=@telefone, Email=@email, Endereço=@endereco, CEP=@cep," +
                "Numero=@numero, Estado=@estado ,Cidade=@cidade ,Pais=@pais ,Complemento=@complemento ,Senha=@senha" +
                " WHERE CPF=@cpf";

            //parametros
            Comando.Parameters.AddWithValue("@nome",cliente.nome);
            Comando.Parameters.AddWithValue("@sobrenome",cliente.sobrenome);
            Comando.Parameters.AddWithValue("@nascimento",cliente.dataNascimento);
            Comando.Parameters.AddWithValue("@genero",cliente.genero);
            Comando.Parameters.AddWithValue("@telefone",cliente.telefone);
            Comando.Parameters.AddWithValue("@email",cliente.email);
            Comando.Parameters.AddWithValue("@endereco",cliente.endereco);
            Comando.Parameters.AddWithValue("@cep",cliente.CEP);
            Comando.Parameters.AddWithValue("@numero",cliente.numero);
            Comando.Parameters.AddWithValue("@estado",cliente.estado);
            Comando.Parameters.AddWithValue("@cidade",cliente.cidade);
            Comando.Parameters.AddWithValue("@pais",cliente.pais);
            Comando.Parameters.AddWithValue("@complemento",cliente.complemento);
            Comando.Parameters.AddWithValue("@senha",cliente.senha);
         
            Comando.Parameters.AddWithValue("@cpf",cliente.CPF);
            
            try
            {

                Comando.Connection = conn.connect();

                Comando.ExecuteNonQuery();

            }
            finally
            {
                conn.disconnect();
            }
            return true;
            cliente.LimpaCliente();
        }


        public bool DeletarCadCliente(Cliente cliente)
        {
            Comando = new SqlCommand();

            Comando.CommandText = "UPDATE Cliente  SET Status = @Status  WHERE  CPF = @cpf";
            Comando.Parameters.AddWithValue("@Status", int.Parse(cliente.status));
            Comando.Parameters.AddWithValue("@cpf", cliente.CPF);
            try
            {

                Comando.Connection = conn.connect();

                Comando.ExecuteNonQuery();

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
            cliente.LimpaCliente();
        }





    }
}
