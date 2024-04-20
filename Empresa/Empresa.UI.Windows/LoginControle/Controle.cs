using Empresa.UI.Windows.LoginAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.UI.Windows.LoginControle
{
    public class Controle
    {
        public bool tem;

        public String mensagem = "";
        public bool Acessar(String loginFunc, String senhaFunc)
        {
            Acesso loginAcesso = new Acesso();
            loginAcesso.verificarLogin(loginFunc, senhaFunc);

            if (!loginAcesso.mensagem.Equals(""))
            { 
                this.mensagem = loginAcesso.mensagem;
            }
            return tem;
        }

        public String Cadastrar(String nome, String login, String senha, String departamento)
        {
            return mensagem;
        }
    }
}
