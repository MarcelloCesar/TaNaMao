using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;

namespace TanaMao.Domain.Gerencia.Repositories
{
    public interface IClienteRepository
    {
        Cliente GetById(Guid id);
        IList<Cliente> GetClientes();
        void Save(Cliente cliente);
        void Delete(Cliente cliente);

    }
}
