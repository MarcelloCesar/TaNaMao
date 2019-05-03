using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.ValueObjects;
using TanaMao.Domain.Gerencia.Repository;
using TanaMao.Domain.Gerencia.Entidades;
using TanaMao.Domain.Gerencia.Enum;
using TanaMao.Domain.Gerencia.Repositories;

namespace TaNaMao.Main
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Descricao temp;

            temp = new Descricao("Este produto não pode estar em contato com crianças?");
            Console.WriteLine(temp.Notifications.ElementAt(0).Message);
            
        }
    }


    public class FakeProdutoRepository : IProdutoRepository
    {
        public Produto GetById(Guid id)
        {
           //Falta instanciar 
          //  return new Produto("CocaCola",  5, TipoProdutoEnum.Bebida);
        }

        public IList<Produto> GetProdutos(List<Produto> ids)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeReservaRepository : IReservaRepository
    {
        public Reserva GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Reserva> GetReservas(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
