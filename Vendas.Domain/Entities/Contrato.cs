using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Vendas.Domain.Entities
{
    public class Contrato
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataVencimento { get; set; }
        public string DocContrato { get; set; }
        public bool Ativo { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<Produto> Produtos { get; set; }
        
    }
}
