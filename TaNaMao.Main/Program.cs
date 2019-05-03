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
using TanaMao.Domain.Gerencia.ValueObject;

namespace TaNaMao.Main
{
    public class Program
    {
        
        static void Main(string[] args)
        {
                        
        }
    }


    public class FakeProdutoRepository : IProdutoRepository
    {
        public Produto GetById(Guid id)
        {           
           return new Produto(
               "CocaCola",
               new Descricao("Coca cola 300ml zero açucar"),
               new Preco(5,"R$"),
               TipoProdutoEnum.Bebida
           );
        }

        public IList<Produto> GetProdutos(List<Produto> ids)
        {
            throw new NotImplementedException();
        }

        public void Save(Produto produto)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produto produto)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeReservaRepository : IReservaRepository
    {
        public Reserva GetById(Guid id)
        {
            // É só um teste, as informações nao sao veridicas
            return new Reserva(
               14,               
               new Cliente(),
               new Periodo(DateTime.Now, DateTime.Now)
           );
        }

        public IList<Reserva> GetReservas(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        public void Save(Reserva reserva)
        {
            throw new NotImplementedException();
        }

        public void Delete(Reserva reserva)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeClienteRepository : IClienteRepository
    {
        public void Delete(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(Guid id)
        {
            return new Cliente();
        }

        public IList<Cliente> GetClientes(List<Cliente> ids)
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }



}
