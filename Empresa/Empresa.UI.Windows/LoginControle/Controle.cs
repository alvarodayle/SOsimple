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
            tem = loginAcesso.verificarLogin(loginFunc, senhaFunc);

            if (!loginAcesso.mensagem.Equals(""))
            { 
                this.mensagem = loginAcesso.mensagem;
            }
            return tem;
        }

        public String Cadastrar(String nomeFunc, String loginFunc, String senhaFunc, String deptFunc, String confSenha)
        {
            Acesso loginAcesso = new Acesso();
            this.mensagem = loginAcesso.Cadastrar(nomeFunc, loginFunc, senhaFunc, deptFunc, confSenha);
            if (loginAcesso.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
