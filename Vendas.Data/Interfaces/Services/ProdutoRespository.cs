using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vendas.Data.Context;
using Vendas.Domain.Entities;

namespace Vendas.Data.Interfaces.Services
{
    public class ProdutoRespository : IProduto
    {
        private readonly VendasContext _context;
        public ProdutoRespository(VendasContext context)
            => _context = context;

        public async Task<List<Produto>> Get()
        {
            return await _context.Produtos.AsNoTracking().ToListAsync();
        }

        public async Task<Produto> GetById(int Id)
        {
            return await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == Id);
        }
        
        public Task<Produto> Create(Produto model)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> Delete(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Produto> UpDate(Produto model)
        {
            throw new NotImplementedException();
        }
    }
}