using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaNaMao.Infra.Transacao
{
    public interface IUow
    {
        void Commit();
        void Rollback();
    }
}
