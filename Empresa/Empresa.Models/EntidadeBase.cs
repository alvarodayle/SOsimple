using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public abstract class EntidadeBase
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
}
