using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public BaseEntity(bool ativo, DateTime dataCadastro)
        {
            this.Ativo = ativo;
            this.DataCadastro = dataCadastro;
        }

    }
}
