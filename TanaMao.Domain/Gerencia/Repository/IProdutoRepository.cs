using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;

namespace TanaMao.Domain.Gerencia.Repository
{
    public interface IProdutoRepository
    {
        Produto GetById(Guid id);
        IList<Produto> GetProdutos(List<Produto> ids);
        void Save(Produto produto);
        void Delete(Produto produto);
    }
}
