using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;
using TanaMao.Domain.Gerencia.Repository;
using TaNaMao.Infra.Context;

namespace TaNaMao.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly GerenciaDataContext _context;

        public ProdutoRepository(GerenciaDataContext context)
        {
            _context = context;
        }

        public void Delete(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto GetById(Guid id)
        {
            return _context.Produtos.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public IList<Produto> GetProdutos(List<Produto> ids)
        {
            throw new NotImplementedException();
        }

        public void Save(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
