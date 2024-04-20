using Empresa.UI.Windows.LoginConexao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.UI.Windows.LoginAcesso
{
    class Acesso
    {
        public bool tem = false;
        public String mensagem = "";
        public String departamento = "";
        public String nomeFuncionario = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dados;
        SqlDataReader alcada;

        public void verificarAlcada(String loginFunc, String senhaFunc)
        {
            cmd.CommandText = @"SELECT nomeFunc, deptFunc FROM TFUNC WHERE loginFunc=@loginFunc and senhaFunc=@senhaFunc";
            cmd.Parameters.AddWithValue("@loginFunc", loginFunc);
            cmd.Parameters.AddWithValue("@senhaFunc", senhaFunc);

            try
            {
                cmd.Connection = con.Conectar();
                alcada = cmd.ExecuteReader();

                while (alcada.Read())
                {
                    nomeFuncionario = alcada["nomeFunc"].ToString();
                    departamento = alcada["deptFunc"].ToString();
                  
                }
                con.Desconectar();
                alcada.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }

        }

        public bool verificarLogin(String loginFunc, String senhaFunc)
        {
            // procurar no banco login e senha
            cmd.CommandText = @"SELECT * FROM TFUNC WHERE loginFunc=@loginFunc and senhaFunc=@senhaFunc";
            cmd.Parameters.AddWithValue("@loginFunc", loginFunc);
            cmd.Parameters.AddWithValue("@senhaFunc", senhaFunc);
            try
            {
                cmd.Connection = con.Conectar();
                dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    tem = true;
                }
                con.Desconectar();
                dados.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

        public String Cadastrar(String nomeFunc, String loginFunc, String senhaFunc, String deptFunc, String confSenha)
        {
            tem = false;

            cmd.CommandText = @"SELECT * FROM TFUNC WHERE loginFunc=@loginFunc";
            cmd.Parameters.AddWithValue("@loginFunc", loginFunc);
            try
            {
                cmd.Connection = con.Conectar();
                dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    this.mensagem = "Login de usuário já cadastrado";
                }
                else
                {
                    dados.Close();

                    if (senhaFunc.Equals(confSenha) && !senhaFunc.Equals("") && !confSenha.Equals(""))
                    {
                        cmd.CommandText = @"INSERT INTO TFUNC VALUES (@nomeFunc, @loginFunc, @senhaFunc, @deptFunc)";
                        cmd.Parameters.AddWithValue("@nomeFunc", nomeFunc);
                        cmd.Parameters.AddWithValue("@senhaFunc", senhaFunc);
                        cmd.Parameters.AddWithValue("@deptFunc", deptFunc);

                        try
                        {
                            cmd.Connection = con.Conectar();
                            cmd.ExecuteNonQuery();
                            con.Desconectar();
                            this.mensagem = "Cadastrado com Sucesso!";
                            tem = true;
                        }
                        catch (SqlException)
                        {
                            this.mensagem = "Erro com Banco de Dados";
                        }
                    }
                    else
                    {
                        this.mensagem = "Senhas não correspondem";
                    }
                }
          

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }

            return mensagem;
            
        }
    }
}
