using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;
using System.Xml.Schema;

namespace Empresa.Db
{
    public class FuncionarioDb
    {
        public String senha = "SOSIMPLEUSER";
        public bool tem = false;
        public String mensagem;
        SqlDataReader dados;

        public bool Incluir(Funcionario funcionario)
        {
            string sql = @"SELECT * FROM TFUNC WHERE loginFunc=@loginFunc";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@loginFunc", funcionario.loginFunc);

            try
            {
                cmd.Connection = connect;
                connect.Open();
                dados = cmd.ExecuteReader();

                if (dados.HasRows)
                {
                    tem = true;
                    this.mensagem = "Login de Usuário já existe na base";
                }
                else
                {
                    dados.Close();

                    cmd.CommandText = @"INSERT INTO TFUNC(nomeFunc, loginFunc, senhaFunc, deptFunc) VALUES(@nomeFunc, @loginFunc, @senhaFunc, @deptFunc)";
                    cmd.Parameters.AddWithValue("@nomeFunc", funcionario.nomeFunc);
                    cmd.Parameters.AddWithValue("@senhaFunc", senha);
                    cmd.Parameters.AddWithValue("@deptFunc", funcionario.deptFunc);

                    
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return true;
        }

        public void Alterar(Funcionario funcionario)
        {
            string sql = @"UPDATE TFUNC SET nomeFunc=@nomeFunc, loginFunc=@loginFunc, deptFunc=@deptFunc WHERE idFunc=@idFunc";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdFunc", funcionario.IdFunc);
            cmd.Parameters.AddWithValue("@nomeFunc", funcionario.nomeFunc);
            cmd.Parameters.AddWithValue("@loginFunc", funcionario.loginFunc);
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

        public void resetSenha(int Id)
        {
            string sql = @"UPDATE TFUNC SET senhaFunc=@senhaFunc WHERE idFunc=@idFunc";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdFunc", Id);
            cmd.Parameters.AddWithValue("@senhaFunc", senha);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<Funcionario> Listar()
        {
            string sql = @"SELECT idFunc, nomeFunc, loginFunc, deptFunc FROM TFUNC";
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
                funcionario.deptFunc = reader["deptFunc"].ToString();

                lista.Add(funcionario);
            }

            reader.Close();
            connect.Close();
            return lista;
        }
    }
}
