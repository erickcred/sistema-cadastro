using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vendas.Data.Context;
using Vendas.Domain.Entities;

namespace Vendas.Data.Interfaces.Services
{
    public interface IContrato
    {
        public Task<List<Contrato>> Get();
        public Task<Contrato> GetById(int Id);
        public Task<Contrato> Create(Contrato model);
        public Task<Contrato> UpDate(Contrato model);
        public Task<Contrato> Delete(int id);

    }
}