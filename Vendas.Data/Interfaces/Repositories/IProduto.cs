using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vendas.Data.Context;
using Vendas.Domain.Entities;

namespace Vendas.Data.Interfaces.Services
{
    public interface IProduto
    {
        public Task<List<Produto>> Get();
        public Task<Produto> GetById(int Id);
        public Task<Produto> Create(Produto model);
        public Task<Produto> UpDate(Produto model);
        public Task<Produto> Delete(int id);

    }
}