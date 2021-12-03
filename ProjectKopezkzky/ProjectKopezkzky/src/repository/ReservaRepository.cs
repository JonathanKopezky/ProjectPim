﻿using ProjectKopezkzky.src.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectKopezkzky.src.model;
using ProjectKopezkzky.src.view;
using System.Windows.Forms;
using System.Data;

namespace ProjectKopezkzky.src.repository
{
    public class ReservaRepository
    {
        SqlDataReader dr;
        SqlCommand Comando;
        Connection conn = new Connection();
        Reserva reserva = new Reserva();
        SqlCommand objCommand;

        //VERICAR 
        public Reserva VerificaReserva(Reserva reserva)
        {
            //Procurar no banco se existe  
            Comando = new SqlCommand();
            Comando.CommandText = "SELECT * FROM Reserva WHERE ID = @id";

            //PARAMETROS
            Comando.Parameters.AddWithValue("@id", reserva.id);

            Comando.Connection = conn.connect();
            dr = Comando.ExecuteReader();

            if (dr.HasRows)
            {
                // verificando se tem linhas com os parametro 
                using (dr)
                {
                    while (dr.Read())
                    {
                        reserva.quartoId = int.Parse(dr[1].ToString());
                        reserva.pagamentoId = int.Parse(dr[2].ToString());
                        reserva.quantDiaria = int.Parse(dr[3].ToString());
                        reserva.responsavelId = int.Parse(dr[4].ToString());
                        reserva.dataCheckIn = DateTime.Parse(dr[5].ToString());
                        reserva.dataCheckOut = DateTime.Parse(dr[6].ToString());
                        reserva.totalAcompanhante = int.Parse(dr[7].ToString());
                        reserva.dataReserva = DateTime.Parse(dr[8].ToString());
                        reserva.status = dr[9].ToString();
                    }
                    return reserva;
                }
            }
            else
            {
                conn.disconnect();
                reserva.LimparReserva();
                return reserva;
            }
        }

        public bool AdicionarReserva(Reserva reserva)
        {
            Comando = new SqlCommand();
            //Essa funcao ira pegar o texto das textbox criar no banco 
            // Comando para inserir os dados no banco 
            Comando.CommandText = "INSERT INTO Reserva VALUES(@ID, @Quarto_ID, @Pagamento_ID, @Quant_Diaria, @Responsavel_ID, @Data_CheckIn," +
                " @Data_CheckOut, @Funcionario_ID, @Total_Acompanhante, @Data_Reserva, @Status)";

            //Preenchendo os as colunas da tabelas
            Comando.Parameters.AddWithValue("@ID", reserva.id);
            Comando.Parameters.AddWithValue("@Quarto_ID", reserva.quartoId);
            Comando.Parameters.AddWithValue("@Pagamento_ID", reserva.pagamentoId);
            Comando.Parameters.AddWithValue("@Quant_Diaria", reserva.quantDiaria);
            Comando.Parameters.AddWithValue("@Responsavel_ID", reserva.responsavelId);
            Comando.Parameters.AddWithValue("@Data_CheckIn", reserva.dataCheckIn);
            Comando.Parameters.AddWithValue("@Data_CheckOut", reserva.dataCheckOut);
            Comando.Parameters.AddWithValue("@Funcionario_ID", reserva.funcionarioId);
            Comando.Parameters.AddWithValue("@Total_Acompanhante", reserva.totalAcompanhante);
            Comando.Parameters.AddWithValue("@Data_Reserva", reserva.dataReserva);
            Comando.Parameters.AddWithValue("@Status", reserva.status);

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
        }

        public bool AtualizarReservaValida(Reserva reserva)
        {
            Comando = new SqlCommand();
            Comando.CommandText = "UPDATE Reserva SET Quarto_ID =@quartoId, Pagamento_ID =@pagamentoId, Quant_Diaria =@quantDiaria," +
                " Responsavel_ID =@responsavelId, Data_CheckIn =@dataCheckIn, Data_CheckOut =@dataCheckOut, Total_Acompanhante =@totalAcompanhante," +
                " Data_Reserva =@dataReserva, Status =@status";

            //parametros
            Comando.Parameters.AddWithValue("@quartoId", reserva.id);
            Comando.Parameters.AddWithValue("@pagamentoId", reserva.pagamentoId);
            Comando.Parameters.AddWithValue("@quantDiaria", reserva.quantDiaria);
            Comando.Parameters.AddWithValue("@responsavelId", reserva.responsavelId);
            Comando.Parameters.AddWithValue("@dataCheckIn", reserva.dataCheckIn);
            Comando.Parameters.AddWithValue("@dataCheckOut", reserva.dataCheckOut);
            Comando.Parameters.AddWithValue("@totalAcompanhante", reserva.totalAcompanhante);
            Comando.Parameters.AddWithValue("@dataReserva", reserva.dataReserva);
            Comando.Parameters.AddWithValue("@status", reserva.status);
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
        }


        public DataTable Grid() 
        {   
            string StrSql = "SELECT* FROM Reserva";
            //Conexao com banco 
            
            //comando e conecta com o banco
            objCommand = new SqlCommand(StrSql, conn.connect());

            conn.connect();
            SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);

            DataTable dtLista = new DataTable();

            objAdp.Fill(dtLista);

            return dtLista;


        }
        public List<Reserva> CarregarReservas()
        {
            Comando = new SqlCommand();
            //Essa funcao ira pegar o texto das textbox criar no banco 
            // Comando para inserir os dados no banco 

            List<Reserva> ListaReserva = new List<Reserva>();
            
            String myquery = "SELECT * FROM Reserva";
            Comando.CommandText = myquery;

            try
            {
                Comando.Connection = conn.connect();
                Comando.ExecuteNonQuery();
                dr = Comando.ExecuteReader();

                while (dr.Read())
                {
                    ListaReserva.Add(new Reserva()
                    {
                        id = Convert.ToInt16(dr["ID"]),
                        quartoId = Convert.ToInt16(dr["Quarto_ID"]),
                        pagamentoId = Convert.ToInt16(dr["Pagamento_ID"]),
                        quantDiaria = Convert.ToInt16(dr["Quant_Diaria"]),
                        responsavelId = Convert.ToInt16(dr["Responsavel_ID"]),
                        dataCheckIn = Convert.ToDateTime(dr["Data_CheckIn"]),
                        dataCheckOut = Convert.ToDateTime(dr["Data_CheckOut"]),
                        funcionarioId = Convert.ToInt16(dr["Funcionario_ID"]),
                        totalAcompanhante = Convert.ToInt16(dr["Total_Acompanhante"]),
                        dataReserva = Convert.ToDateTime(dr["Data_Reserva"]),
                        status = Convert.ToString(dr["Status"])
                    });

                    
                } 
                  SqlDataAdapter da = new SqlDataAdapter();
                // SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                // DataTable ba = new DataTable();
                // da.Fill(ba);
                //da.Dispose();

                if (ListaReserva.Count() > 0)
                {
                    return ListaReserva;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                conn.disconnect();
            }
        }

    }
}