using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Domain.Entities;
using Vendas.Domain.Entities.Base;

namespace Vendas.Domain.Entities
{
    public class Fornecedor : Usuario
    {

        public string CNPJ { get; set; }
        public string NomeFantasia { get; set; }
        public List<Contrato> Contratos { get; set; }

        public Fornecedor(string cnpj, string nomeFantasia, bool ativo, DateTime dataCadastro) : base(ativo, dataCadastro)
        {
            this.CNPJ = cnpj;
            this.NomeFantasia = nomeFantasia;
            this.Ativo = ativo;
        }

        //public AddFornecedor() { }

        //public UpdateFornecedor() { }

        //public GetFornecedor() { }

        //public DeleteFornecedor() { }
    }
}
