using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;

namespace Empresa.Db
{
    public class FuncionariosDb
    {
        public void Incluir(Funcionario funcionario)
        {
            string sql = @"INSERT INTO TFUNC (nomeFunc, loginFunc, senhaFunc, deptFunc) VALUES(@nomeFunc, @loginFunc, @senhaFunc, @deptFunc)";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@nomeFunc", funcionario.nomeFunc);
            cmd.Parameters.AddWithValue("@loginFunc", funcionario.loginFunc);
            cmd.Parameters.AddWithValue("@senhaFunc", funcionario.senhaFunc);
            cmd.Parameters.AddWithValue("@deptFunc", funcionario.deptFunc);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void Alterar(Funcionario funcionario)
        {
            string sql = @"UPDATE TFUNC SET nomeFunc=@nomeFunc, loginFunc=@loginFunc, senhaFunc=@senhaFunc, deptFunc=@deptFunc WHERE idFunc=@IdFunc";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdFunc", funcionario.IdFunc);
            cmd.Parameters.AddWithValue("@nomeFunc", funcionario.nomeFunc);
            cmd.Parameters.AddWithValue("@loginFunc", funcionario.loginFunc);
            cmd.Parameters.AddWithValue("@senhaFunc", funcionario.senhaFunc);
            cmd.Parameters.AddWithValue("@deptFunc", funcionario.deptFunc);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void Excluir(int Id)
        {
            string sql = @"DELETE TFUNC WHERE idFunc=@IdFunc";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdFunc", Id);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<Funcionario> Listar()
        {
            string sql = @"SELECT idFunc, nomeFunc, loginFunc, senhaFunc, deptFunc FROM TFUNC";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            
            List<Funcionario> lista = new List<Funcionario>();

            connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                var funcionario = new Funcionario();
                funcionario.IdFunc = Convert.ToInt32(reader["IdFunc"]);
                funcionario.nomeFunc = reader["nomeFunc"].ToString();
                funcionario.loginFunc = reader["loginFunc"].ToString();
                funcionario.senhaFunc = reader["senhaFunc"].ToString();
                funcionario.deptFunc = reader["deptFunc"].ToString();

                lista.Add(funcionario);
            }

            reader.Close();
            connect.Close();
            return lista;
        }
    }
}
