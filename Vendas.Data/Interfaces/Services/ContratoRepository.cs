using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Domain.Entities;

namespace Vendas.Data.Interfaces.Services
{
    public class ContratoRepository : IContrato
    {
        public Task<List<Contrato>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Contrato> GetById(int Id)
        {
            throw new NotImplementedException();
        }
        
        public Task<Contrato> Create(Contrato model)
        {
            throw new NotImplementedException();
        }

        public Task<Contrato> Delete(int id)
        {
            throw new NotImplementedException();
        }


        public Task<Contrato> UpDate(Contrato model)
        {
            throw new NotImplementedException();
        }
    }
}