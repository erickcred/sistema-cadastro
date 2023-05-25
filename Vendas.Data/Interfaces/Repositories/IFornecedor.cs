using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vendas.Data.Context;
using Vendas.Domain.Entities;

namespace Vendas.Data.Interfaces.Services
{
    public interface IFornecedor
    {
        public Task<List<Fornecedor>> Get();
        public Task<Fornecedor> GetById(int Id);
        public Task<Fornecedor> Create(Fornecedor model);
        public Task<Fornecedor> UpDate(Fornecedor model);
        public Task<Fornecedor> Delete(int id);
    }
}