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
        public String Message = "";
        public bool tem;
        SqlDataReader dr;
        SqlCommand Comando = new SqlCommand();
        Connection conn = new Connection(); 
       


        public String CriarCadCliente(Cliente Cliente) 
        {   // Comando para inserir os dados no banco 
            Comando.CommandText = "INSERT INTO Cliente VALUES(@Nome, @Sobrenome, @RG, @CPF, @Email, @Telefone, @Endereço, @CEP, @Numero, @Complemento, @Cidade, @Estado, @Genero, @Pais, @Data_nascimento, @Ativo ,@Senha";
            //fim 
            MessageBox.Show("chegou no criar cliente ");
            //Preenchendo os as colunas da tabelas
            Comando.Parameters.AddWithValue("@Nome",Cliente.nome);
            Comando.Parameters.AddWithValue("@Sobrenome", Cliente.sobrenome);
            Comando.Parameters.AddWithValue("@RG", Cliente.RG);
            Comando.Parameters.AddWithValue("@CPF", Cliente.CPF);
            Comando.Parameters.AddWithValue("@Email", Cliente.email);
            Comando.Parameters.AddWithValue("@Telefone", Cliente.telefone);
            Comando.Parameters.AddWithValue("@Endereço", Cliente.endereco);
            Comando.Parameters.AddWithValue("@CEP", Cliente.CEP);
            Comando.Parameters.AddWithValue("@Numero", Cliente.numero);
            Comando.Parameters.AddWithValue("@Complemento", Cliente.complemento);
            Comando.Parameters.AddWithValue("@Cidade", Cliente.cidade);
            Comando.Parameters.AddWithValue("@Estado", Cliente.estado);
            Comando.Parameters.AddWithValue("@Genero", Cliente.genero);
            Comando.Parameters.AddWithValue("@Pais", Cliente.pais);
            Comando.Parameters.AddWithValue("@Data_nascimento", Cliente.dataNascimento);
            Comando.Parameters.AddWithValue("@Ativo", Cliente.ativo);
            //FIM

            try
            {
                Comando.Connection = conn.connect();
                dr = Comando.ExecuteReader();
                if (dr.HasRows) 
                {
                   tem = true;
                }
            }
            catch (SqlException )
            {
                this.Message = "Erro Ao conectar com o banco!";
            }
            finally 
            {
                conn.disconnect();
                
            }

            return "Cadastrado com sucesso";
        }
        

       
        
    }
}
