using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.UI.Windows.LoginConexao
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        { 
            con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=SoSimple;Integrated Security=True;Encrypt=False;";
        }

        public SqlConnection Conectar()
        { 
            if(con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}