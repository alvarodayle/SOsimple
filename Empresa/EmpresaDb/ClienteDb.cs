using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;
using System.Drawing;

namespace Empresa.Db
{
    public class ClienteDb
    {

        public bool verificaClienteExistente(String cpfCliente)
        {
            string sql = @"SELECT * FROM TCLIE WHERE cpfCliente=@cpfCliente";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            var tem = false;
            cmd.Parameters.AddWithValue("@cpfCliente", cpfCliente);

            connect.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                tem = true;
                    
            }

            reader.Close();
            connect.Close();
            
            return tem;
        }

        public void Incluir(Cliente cliente)
        {
            string sql = @"INSERT INTO TCLIE(nomeCliente, cpfCliente, telCliente, cepCliente, endCliente, numEndCliente, cidCliente, ufCliente) VALUES(@nomeCliente, @cpfCliente, @telCliente, @cepCliente, @endCliente, @numEndCliente, @cidCliente, @ufCliente)";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@nomeCliente", cliente.nomeCliente);
            cmd.Parameters.AddWithValue("@cpfCliente", cliente.cpfCliente);
            cmd.Parameters.AddWithValue("@telCliente", cliente.telCliente);
            cmd.Parameters.AddWithValue("@cepCliente", cliente.cepCliente);
            cmd.Parameters.AddWithValue("@endCliente", cliente.endCliente);
            cmd.Parameters.AddWithValue("@numEndCliente", cliente.numEndCliente);
            cmd.Parameters.AddWithValue("@cidCliente", cliente.cidCliente);
            cmd.Parameters.AddWithValue("@ufCliente", cliente.ufCliente);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void Alterar(Cliente cliente)
        {
            string sql = @"UPDATE TCLIE SET nomeCliente=@nomeCliente, cpfCliente=@cpfCliente, telCliente=@telCliente, cepCliente=@cepCliente,endCliente=@endCliente, numEndCliente=@numEndCliente, cidCliente=@cidCliente, ufCliente=@ufCliente WHERE IdCliente=@IdCliente";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
            cmd.Parameters.AddWithValue("@nomeCliente", cliente.nomeCliente);
            cmd.Parameters.AddWithValue("@cpfCliente", cliente.cpfCliente);
            cmd.Parameters.AddWithValue("@telCliente", cliente.telCliente);
            cmd.Parameters.AddWithValue("@cepCliente", cliente.cepCliente);
            cmd.Parameters.AddWithValue("@endCliente", cliente.endCliente);
            cmd.Parameters.AddWithValue("@numEndCliente", cliente.numEndCliente);
            cmd.Parameters.AddWithValue("@cidCliente", cliente.cidCliente);
            cmd.Parameters.AddWithValue("@ufCliente", cliente.ufCliente);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void Excluir(int Id)
        {
            string sql = @"DELETE TCLIE WHERE IdCliente=@IdCliente";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddWithValue("@IdCliente", Id);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public List<Cliente> Listar()
        {
            string sql = @"SELECT IdCliente, nomeCliente, cpfCliente, telCliente, cepCliente, endCliente, numEndCliente, cidCliente, ufCliente FROM TCLIE";
            var connect = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, connect);
            
            List<Cliente> lista = new List<Cliente>();

            connect.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) 
            {
                var cliente = new Cliente();
                cliente.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                cliente.nomeCliente = reader["nomeCliente"].ToString();
                cliente.cpfCliente = reader["cpfCliente"].ToString();
                cliente.telCliente = reader["telCliente"].ToString();
                cliente.cepCliente = reader["cepCliente"].ToString();
                cliente.endCliente = reader["endCliente"].ToString();
                cliente.numEndCliente = reader["numEndCliente"].ToString();
                cliente.cidCliente = reader["cidCliente"].ToString();
                cliente.ufCliente = reader["ufCliente"].ToString();

                lista.Add(cliente);
            }

            reader.Close();
            connect.Close();
            return lista;
        }
    }
}
