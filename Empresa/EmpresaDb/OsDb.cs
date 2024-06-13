using Empresa.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    public class OsDb
    {

        public ClienteGerenciamentoDeOS ProcurarCliente(string cpfInformado)
        {
            string sql = @"SELECT IdCliente, nomeCliente, cpfCliente, telCliente, cepCliente, endCliente, numEndCliente, cidCliente, ufCliente FROM TCLIE WHERE cpfCliente=@cpfCliente";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@cpfCliente", cpfInformado);

            connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            ClienteGerenciamentoDeOS cliente = null;

            if (reader.Read())
            {
                cliente = new ClienteGerenciamentoDeOS();
                {
                    cliente.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                    cliente.nomeCliente = reader["nomeCliente"].ToString();
                    cliente.cpfCliente = reader["cpfCliente"].ToString();
                    cliente.telCliente = reader["telCliente"].ToString();
                    cliente.cepCliente = reader["cepCliente"].ToString();
                    cliente.endCliente = reader["endCliente"].ToString();
                    cliente.numEndCliente = reader["numEndCliente"].ToString();
                    cliente.cidCliente = reader["cidCliente"].ToString();
                    cliente.ufCliente = reader["ufCliente"].ToString();
                };
            }

            reader.Close();
            connect.Close();

            return cliente;
        }

        public void Incluir(int IdClienteArmazenado, int IdProdutoArmazenado, string aparencia, string numeroSerial, string descDefeito, string status)
        {
            string sql = @"INSERT INTO TORDE(idClienteOS, idProdutoOS, aparenciaProd, numSerieProd, descDefeitoProd, statusOS) VALUES(@idClienteOS, @idProdutoOS, @aparenciaProd, @numSerieProd, @descDefeitoProd, @statusOS )";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@idClienteOS", IdClienteArmazenado);
            cmd.Parameters.AddWithValue("@idProdutoOS", IdProdutoArmazenado);
            cmd.Parameters.AddWithValue("@aparenciaProd", aparencia);
            cmd.Parameters.AddWithValue("@numSerieProd", numeroSerial);
            cmd.Parameters.AddWithValue("@descDefeitoProd", descDefeito);
            cmd.Parameters.AddWithValue("@statusOS", status);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }















    }
}
