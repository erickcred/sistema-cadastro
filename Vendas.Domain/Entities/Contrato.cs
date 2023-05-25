using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Vendas.Domain.Entities.Base;

namespace Vendas.Domain.Entities
{
    public class Contrato : BaseEntity
    {

        public DateTime DataVencimento { get; set; }
        public string DocContrato { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Contrato(bool ativo, DateTime dataCadastro) : base(ativo, dataCadastro)
        {
        }

        //public AddContrato() { }
        //public UpdateContrato() { }
        //public GetContrato() { }
        //public GetContratos() { }
        //DeleteContrato() { }
    }
}
