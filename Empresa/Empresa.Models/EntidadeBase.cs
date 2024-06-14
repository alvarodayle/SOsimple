using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public abstract class EntidadeCliente
    {
        public int IdCliente { get; set; }
        public string nomeCliente { get; set; }
        public string cpfCliente { get; set; }
        public string telCliente { get; set; }
        public string cepCliente { get; set; }
        public string endCliente { get; set; }
        public string numEndCliente { get; set; }
        public string cidCliente { get; set; }
        public string ufCliente { get; set; }
    }

    public abstract class EntidadeFuncionario
    {
        public int IdFunc { get; set; }
        public string nomeFunc { get; set; }
        public string loginFunc { get; set; }
        public string deptFunc { get; set; }
    }

    public abstract class EntidadeProduto
    {
        public int IdProduto { get; set; }
        public string tipoProduto { get; set; }
        public string modeloProduto { get; set; }
        public string marcaProduto { get; set; }
    }

    public abstract class EntidadePeca
    {
        public int idPeca { get; set; }
        public string marcaProduto { get; set; }
        public string tipoProduto { get; set; }
        public string modeloProduto { get; set; }
        public string nomePeca { get; set; }
        public int qtdPeca { get; set; }
    }

    public abstract class EntidadeClienteGerenciamentoDeOS
    {
        public int IdCliente { get; set; }
        public string nomeCliente { get; set; }
        public string cpfCliente { get; set; }
        public string telCliente { get; set; }
        public string cepCliente { get; set; }
        public string endCliente { get; set; }
        public string numEndCliente { get; set; }
        public string cidCliente { get; set; }
        public string ufCliente { get; set; }
    }

    public abstract class EntidadeOrdemGerenciamentoDeOS
    {
        public int OS { get; set; }
        public int idClienteOS { get; set; }
        public int idProdutoOS { get; set; }
        public string aparenciaProd { get; set; }
        public string numSerieProd {  get; set; }
        public string descDefeitoProd { get; set; }
        public string statusOS { get; set; }
    }
}