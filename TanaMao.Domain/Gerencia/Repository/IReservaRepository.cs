using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;

namespace TanaMao.Domain.Gerencia.Repositories
{
    public interface IReservaRepository
    {
        Reserva GetById(Guid id);
        IList<Reserva> GetReservas(List<Guid> ids);
        void Save(Reserva reserva);
        void Delete(Reserva reserva);

    }
}
