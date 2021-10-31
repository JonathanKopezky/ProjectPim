using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.config;
using System.Windows.Forms;
namespace ProjectKopezkzky.src.repository
{
    class ClienteRepository
    {
        Cliente cliente = new Cliente();
        public String Message = "";
        
        SqlDataReader dr;
        SqlCommand Comando = new SqlCommand();
        Connection conn = new Connection(); 
       
        //VERICAR 

        public bool CriarCadCliente(Cliente cliente) 
        {   // Comando para inserir os dados no banco 
            Comando.CommandText = "INSERT INTO Cliente VALUES(@Nome, @Sobrenome, @RG, @CPF, @Email, @Telefone, @Endereço, @CEP, @Numero, @Complemento, @Cidade, @Estado, @Genero, @Pais, @Data_nascimento, @Ativo ,@Senha";
            //fim 
            
            //Preenchendo os as colunas da tabelas
            Comando.Parameters.AddWithValue("@Nome",cliente.nome);
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
        //    if (cliente.ativo)
       ///     {
                Comando.Parameters.AddWithValue("@Ativo", 1);
         //   }
       //     else
       //     { 
         //       Comando.Parameters.AddWithValue("@Ativo", 0); 
          //  }

          //  Comando.Parameters.AddWithValue("@Ativo", cliente.ativo);
            Comando.Parameters.AddWithValue("@Senha", cliente.senha);
            //FIM

            try
            {
                Comando.Connection = conn.connect();
                dr = Comando.ExecuteReader();

                if (dr.HasRows) 
                {
                    Comando.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                this.Message = "Erro com o Banco de Dados ";
            }
            finally 
            {
                this.Message = "Cadastrado com sucesso";
                conn.disconnect();
            }
            return true;
        }


        

    }
}
