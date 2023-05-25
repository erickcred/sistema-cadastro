using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Qunatidade { get; set; }
        public Decimal Preco { get; set; }
        public bool Ativo { get; set; }

        public DateTime DataInclusao { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Contrato Contrato { get; set; }

    }
}
