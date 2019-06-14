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
    public class ReservaRepository : IReservaRepository
    {
        private readonly GerenciaDataContext _context;

        public ReservaRepository(GerenciaDataContext context)
        {
            _context = context;
        }

        public Reserva GetById(Guid id)
        {
            return _context.Reservas.AsNoTracking().FirstOrDefault(r => r.Id == id);
        }

        public IList<Reserva> GetReservas()
        {
            return _context.Reservas.AsNoTracking().ToList();
        }

        public void Save(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }

        public void Delete(Reserva reserva)
        {
            _context.Reservas.Remove(reserva);
            _context.SaveChanges();
        }
    }
}
