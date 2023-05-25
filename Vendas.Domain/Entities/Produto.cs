using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Domain.Entities.Base;

namespace Vendas.Domain.Entities
{
    public class Produto : BaseEntity
    {

        public Fornecedor Fornecedor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Produto(bool ativo, DateTime dataCadastro) : base(ativo, dataCadastro)
        {
        }
    }
}
