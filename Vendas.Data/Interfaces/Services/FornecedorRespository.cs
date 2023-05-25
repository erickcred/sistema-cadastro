using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Domain.Entities;

namespace Vendas.Data.Interfaces.Services
{
    public class FornecedorRespository : IFornecedor
    {
        public Task<List<Fornecedor>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Fornecedor> GetById(int Id)
        {
            throw new NotImplementedException();
        }
        
        public Task<Fornecedor> Create(Fornecedor model)
        {
            throw new NotImplementedException();
        }

        public Task<Fornecedor> Delete(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Fornecedor> UpDate(Fornecedor model)
        {
            throw new NotImplementedException();
        }
    }
}