using Empresa.UI.Windows.LoginConexao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dados;

        public bool verificarLogin(String loginFunc, String senhaFunc)
        {
            // procurar no banco login e senha
            cmd.CommandText = "SELECT * FROM TFUNC WHERE loginFunc='teste' and senhaFunc='123'";
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
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com Banco de Dados";
            }
            return tem;
        }

        public String Cadastrar(String nome, String login, String senha, String departamento)
        {
            // comandos para inserir no banco
            return mensagem;
        }
    }
}
