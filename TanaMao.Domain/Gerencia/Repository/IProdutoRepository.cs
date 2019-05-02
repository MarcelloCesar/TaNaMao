using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanaMao.Domain.Gerencia.Repository
{
    public interface IProdutoRepository
    {
        Produto GetById(Guid id);
    }
}
