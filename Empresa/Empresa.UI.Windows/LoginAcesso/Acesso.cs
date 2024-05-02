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

        public String validasenha;

        public String resetSenha(String loginFunc, String senhaAtualFunc, String novaSenhaFunc, String confirSenhaFunc)
        {
            tem = false;

            cmd.CommandText = @"SELECT senhaFunc FROM TFUNC WHERE loginFunc=@loginFunc";
            cmd.Parameters.AddWithValue("@loginFunc", loginFunc);
            try
            {
                cmd.Connection = con.Conectar();
                dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        validasenha = dados["senhaFunc"].ToString();
                    }
                    if (senhaAtualFunc.Equals(validasenha))
                    {
                        if (validasenha != novaSenhaFunc)
                        {

                            if (novaSenhaFunc.Equals(confirSenhaFunc) && !novaSenhaFunc.Equals("") && !confirSenhaFunc.Equals(""))
                            {
                                dados.Close();

                                cmd.CommandText = @"UPDATE TFUNC SET senhaFunc=@novaSenhaFunc WHERE loginFunc=@loginFunc";
                                cmd.Parameters.AddWithValue("@novaSenhaFunc", novaSenhaFunc);

                                try
                                {
                                    cmd.Connection = con.Conectar();
                                    cmd.ExecuteNonQuery();
                                    con.Desconectar();
                                    this.mensagem = "Senha alterada com sucesso!";
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
                        else
                        {
                            this.mensagem = "Nova Senha e Senha Atual são semelhantes";
                        }
                    }
                    else
                    {
                        this.mensagem = "Senha atual incorreta";
                    }
                }
                else
                {
                    
                    this.mensagem = "Login de Usuário não encontrado";

                    dados.Close();
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
