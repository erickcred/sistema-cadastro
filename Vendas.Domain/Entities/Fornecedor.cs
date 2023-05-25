using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Domain.Entities;

namespace Vendas.Domain.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public bool Ativo { get ; set; }
        
        public DateTime DataCadatro { get; set; }
        public List<Contrato> Contratos { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
