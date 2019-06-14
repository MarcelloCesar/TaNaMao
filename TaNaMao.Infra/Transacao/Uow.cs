using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaNaMao.Infra.Context;

namespace TaNaMao.Infra.Transacao
{
    public class Uow : IUow
    {
        private readonly GerenciaDataContext _context;

        public Uow(GerenciaDataContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            
        }
    }
}
