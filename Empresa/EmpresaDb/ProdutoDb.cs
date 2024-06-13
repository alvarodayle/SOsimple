using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;

namespace Empresa.Db
{
    public class ProdutoDb
    {
        public void Incluir(Produto produto)
        {
            string sql = @"INSERT INTO TPROD(tipoProduto, modeloProduto, marcaProduto) VALUES(@tipoProduto, @modeloProduto, @marcaProduto)";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@tipoProduto", produto.tipoProduto);
            cmd.Parameters.AddWithValue("@modeloProduto", produto.modeloProduto);
            cmd.Parameters.AddWithValue("@marcaProduto", produto.marcaProduto);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void Alterar(Produto produto)
        {
            string sql = @"UPDATE TPROD SET tipoProduto=@tipoProduto, modeloProduto=@modeloProduto, marcaProduto=@marcaProduto WHERE IdProduto=@IdProduto";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
            cmd.Parameters.AddWithValue("@tipoProduto", produto.tipoProduto);
            cmd.Parameters.AddWithValue("@modeloProduto", produto.modeloProduto);
            cmd.Parameters.AddWithValue("@marcaProduto", produto.marcaProduto);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void Excluir(int Id)
        {
            string sql = @"DELETE TPROD WHERE IdProduto=@IdProduto";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdProduto", Id);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<Produto> Listar()
        {
            string sql = @"SELECT IdProduto, tipoProduto, modeloProduto, marcaProduto FROM TPROD";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            
            List<Produto> lista = new List<Produto>();

            connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                var produto = new Produto();
                produto.IdProduto = Convert.ToInt32(reader["IdProduto"]);
                produto.tipoProduto = reader["tipoProduto"].ToString();
                produto.modeloProduto = reader["modeloProduto"].ToString();
                produto.marcaProduto = reader["marcaProduto"].ToString();

                lista.Add(produto);
            }

            reader.Close();
            connect.Close();
            return lista;
        }

        int IdProdutoEncontrado;

        public int ProcurarID(string tipoProduto,string marcaProduto,string modeloProduto)
        {
            string sql = @"SELECT idProduto FROM TPROD WHERE tipoProduto=@tipoProduto and marcaProduto=@marcaProduto and modeloProduto=@modeloProduto";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@tipoProduto", tipoProduto);
            cmd.Parameters.AddWithValue("@marcaProduto", marcaProduto);
            cmd.Parameters.AddWithValue("@modeloProduto", modeloProduto);

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                IdProdutoEncontrado = Convert.ToInt32(reader["IdProduto"]);
            }

            reader.Close();
            connect.Close();

            return IdProdutoEncontrado;
        }
    }
}
