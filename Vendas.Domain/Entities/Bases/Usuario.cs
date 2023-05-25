using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Domain.Entities.Base
{
    public abstract class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        protected Usuario(bool ativo, DateTime dataCadastro) : base(ativo, dataCadastro)
        {
        }
    }
}
