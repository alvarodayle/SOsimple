using Empresa.UI.Windows.LoginAcesso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.UI.Windows.LoginControle
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public String departamento = "";
        public String nomeFuncionario = "";

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

        public void Alcada(String loginFunc, String senhaFunc)
        {
            Acesso alcada = new Acesso();
            alcada.verificarAlcada(loginFunc, senhaFunc);

            departamento = alcada.departamento;
            nomeFuncionario = alcada.nomeFuncionario;

        }

        public String resetSenha(String loginFunc, String senhaAtualFunc, String novaSenhaFunc, String confirSenhaFunc)
        {
            Acesso loginAcesso = new Acesso();
            this.mensagem = loginAcesso.resetSenha(loginFunc, senhaAtualFunc, novaSenhaFunc, confirSenhaFunc);
            if (loginAcesso.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
