using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;
using System.Collections;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Empresa.Db
{
    public class PecaDb
    {
        public List<string> MarcaComboBox()
        {
            string sql = @"SELECT DISTINCT(marcaProduto) FROM TPROD;";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);

            List<string> lista = new List<string>();

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(reader["marcaProduto"].ToString());
            }

            connect.Close();
            return lista;
        }

        public List<string> TipoComboBox(String marcaSelecionada)
        {
            string sql = @"SELECT tipoProduto FROM TPROD WHERE marcaProduto=@marcaProduto;";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("marcaProduto", marcaSelecionada);

            List<string> lista = new List<string>();

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                lista.Add(reader["tipoProduto"].ToString());
            }

            connect.Close();
            return lista;
        }

        public List<string> ModeloComboBox(String marcaSelecionada, String tipoSelecionado)
        {
            string sql = @"SELECT modeloProduto FROM TPROD WHERE marcaProduto=@marcaProduto AND tipoProduto=@tipoProduto;";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("marcaproduto", marcaSelecionada);
            cmd.Parameters.AddWithValue("tipoProduto", tipoSelecionado);

            List<string> lista = new List<string>();

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(reader["modeloProduto"].ToString());
            }

            connect.Close();
            return lista;
        }

        public void Incluir(Peca peca, String tipoSelecionado, String modeloSelecionado, String marcaSelecionada)
        {
            int idProduto;

            string sql = @"SELECT idProduto FROM TPROD WHERE tipoProduto=@tipoProduto AND modeloProduto=@modeloProduto AND marcaProduto=@marcaproduto";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("tipoProduto", tipoSelecionado);
            cmd.Parameters.AddWithValue("modeloProduto", modeloSelecionado);
            cmd.Parameters.AddWithValue("marcaProduto", marcaSelecionada);

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            idProduto = Convert.ToInt32(reader["idProduto"]);

            reader.Close();

            cmd.CommandText = @"INSERT INTO TPECA (idProduto, nomePeca, qtdPeca) VALUES (@idProduto, @nomePeca, @qtdPeca)";
            cmd.Parameters.AddWithValue("idProduto", idProduto);
            cmd.Parameters.AddWithValue("nomePeca", peca.nomePeca);
            cmd.Parameters.AddWithValue("qtdPeca", peca.qtdPeca);
            
            cmd.ExecuteNonQuery();
            connect.Close();

        }

        public void Alterar(Produto produto)
        {
            string sql = @"UPDATE TPROD SET tipoProduto=@tipoProduto, modeloProduto=@modeloProduto, marcaProduto=@marcaProduto, numSerie=@numSerie WHERE IdProduto=@IdProduto";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
            cmd.Parameters.AddWithValue("@tipoProduto", produto.tipoProduto);
            cmd.Parameters.AddWithValue("@modeloProduto", produto.modeloProduto);
            cmd.Parameters.AddWithValue("@marcaProduto", produto.marcaProduto);
            cmd.Parameters.AddWithValue("@numSerie", produto.numSerie);

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

        public List<Peca> Listar(String marcaProduto, String tipoProduto, String modeloProduto)
        {

            string sql = @"SELECT PD.marcaProduto,
	                    PD.tipoProduto,
	                    PD.modeloProduto,
	                    P.nomePeca,
	                    P.qtdPeca
                        From TPECA P INNER JOIN TPROD PD
                        ON P.idProduto = PD.idProduto
                        WHERE 1=1
                        ORDER BY PD.marcaProduto"
            ;

            if (!string.IsNullOrEmpty(tipoProduto))
            {
                sql += " AND tipoProduto = @TipoProduto";
            }

            if (!string.IsNullOrEmpty(modeloProduto))
            {
                sql += " AND modeloProduto = @Modelo";
            }

            if (!string.IsNullOrEmpty(marcaProduto))
            {
                sql += " AND marcaProduto = @Marca";
            }

            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);

            if (!string.IsNullOrEmpty(tipoProduto))
            {
                cmd.Parameters.AddWithValue("@TipoProduto", tipoProduto);
            }

            if (!string.IsNullOrEmpty(modeloProduto))
            {
                cmd.Parameters.AddWithValue("@Modelo", modeloProduto);
            }

            if (!string.IsNullOrEmpty(marcaProduto))
            {
                cmd.Parameters.AddWithValue("@Marca", marcaProduto);
            }

            List<Peca> lista = new List<Peca>();

            connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                var peca = new Peca();

                peca.marcaProduto = reader["marcaProduto"].ToString();
                peca.tipoProduto = reader["tipoProduto"].ToString();
                peca.modeloProduto = reader["modeloProduto"].ToString();
                peca.nomePeca = reader["nomePeca"].ToString();
                peca.qtdPeca = Convert.ToInt32(reader["qtdPeca"]);

                lista.Add(peca);
            }

            reader.Close();
            connect.Close();
            return lista;
        }
    }
}
