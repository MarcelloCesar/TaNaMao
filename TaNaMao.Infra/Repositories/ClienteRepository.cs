using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;
using TanaMao.Domain.Gerencia.Repositories;
using TaNaMao.Infra.Context;

namespace TaNaMao.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly GerenciaDataContext _context;

        public ClienteRepository(GerenciaDataContext context)
        {
            _context = context;
        }

        public Cliente GetById(Guid id)
        {
            return _context.Clientes.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public IList<Cliente> GetClientes(List<Cliente> ids)
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
