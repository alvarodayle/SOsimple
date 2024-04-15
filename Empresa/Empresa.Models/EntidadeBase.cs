﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public abstract class EntidadeCliente
    {
        public int    IdCliente     { get; set; }
        public string nomeCliente   { get; set; }
        public string cpfCliente    { get; set; }
        public string telCliente    { get; set; }
        public string cepCliente    { get; set; }
        public string endCliente    { get; set; }
        public string numEndCliente { get; set; }
        public string cidCliente    { get; set; }
        public string ufCliente     { get; set; }
    }

    public abstract class EntidadeFuncionario
    {
        public string loginFunc { get; set; }
        public string senhaFunc { get; set; }
    }

    public abstract class EntidadeProduto
    {
        public int    IdProduto      { get; set; }
        public string tipoProduto    { get; set; }
        public string modeloProduto  { get; set; }
        public string marcaProduto   { get; set; }
        public string numSerie       { get; set; }

    
    }
}
