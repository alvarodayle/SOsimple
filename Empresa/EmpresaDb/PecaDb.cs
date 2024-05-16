﻿using System;
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
        public void Incluir(Produto produto)
        {
            string sql = @"INSERT INTO TPROD(tipoProduto, modeloProduto, marcaProduto, numSerie) VALUES(@tipoProduto, @modeloProduto, @marcaProduto, @numSerie)";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@tipoProduto", produto.tipoProduto);
            cmd.Parameters.AddWithValue("@modeloProduto", produto.modeloProduto);
            cmd.Parameters.AddWithValue("@marcaProduto", produto.marcaProduto);
            cmd.Parameters.AddWithValue("@numSerie", produto.numSerie);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<Produto> comboBoxTipo()
        {
            string sql = @"Select tipoProduto FROM TPROD";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);

            List<Produto> lista = new List<Produto>();
            
            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var produto = new Produto();

                produto.tipoProduto = reader["tipoProduto"].ToString();

                lista.Add(produto);
            }

            reader.Close();
            connect.Close();
            return lista;

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

        public List<Peca> Listar(String tipoProduto, String modeloProduto, String marcaProduto, bool considerarTipo, bool considerarModelo, bool considerarMarca)
        {

            string sql = @"SELECT PD.tipoProduto,
	                    PD.modeloProduto,
	                    PD.marcaProduto,
	                    P.nomePeca,
	                    P.qtdPeca
                        From TPECA P INNER JOIN TPROD PD
                        ON P.idProduto = PD.idProduto
                        WHERE 1=1"
            ;

            if (considerarTipo == true)
            {
                sql += " AND tipoProduto = @TipoProduto";
            }

            if (considerarModelo == true)
            {
                sql += " AND modeloProduto = @Modelo";
            }

            if (considerarMarca == true)
            {
                sql += " AND marcaProduto = @Marca";
            }

            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);

            if (considerarTipo == true)
            {
                cmd.Parameters.AddWithValue("@TipoProduto", tipoProduto);
            }

            if (considerarModelo == true)
            {
                cmd.Parameters.AddWithValue("@Modelo", modeloProduto);
            }

            if (considerarMarca == true)
            {
                cmd.Parameters.AddWithValue("@Marca", marcaProduto);
            }

            List<Peca> lista = new List<Peca>();

            connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                var peca = new Peca();

                peca.tipoProduto = reader["tipoProduto"].ToString();
                peca.modeloProduto = reader["modeloProduto"].ToString();
                peca.marcaProduto = reader["marcaProduto"].ToString();
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
