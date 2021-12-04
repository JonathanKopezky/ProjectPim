using ProjectKopezkzky.src.config;
using ProjectKopezkzky.src.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKopezkzky.src.repository
{
    public class QuartoRepository
    {
        SqlDataReader dr;
        Connection conn = new Connection();
        Quarto quarto = new Quarto();
        SqlCommand objCommand;

        public DataTable Grid()
        {
            conn.connect();
            string StrSql = "SELECT ID FROM Quarto";
            objCommand = new SqlCommand(StrSql, conn.connect());
            dr = objCommand.ExecuteReader();
            SqlDataAdapter objAdp = new SqlDataAdapter(objCommand);
            DataTable dtLista = new DataTable();
            dtLista.Columns.Add("ID", typeof(int));          
            dtLista.Load(dr);
            //objAdp.Fill(dtLista);
            return dtLista;
        }
    }
}
