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
            //------ Cadastrar novo produto
            Preco precoProduto = new Preco(18, "R$");
            Descricao descProduto = new Descricao("Acompanha: Alface, tomate, rúcula");
            Produto produto = new Produto(
                "Salada Silvestre",
                descProduto,
                precoProduto,
                TipoProdutoEnum.Entrada
            );
            //Torna o produto disponivel
            produto.TornarDisponivel(); 

            var fakeProdutoRepository = new FakeProdutoRepository();
            fakeProdutoRepository.Save(produto);
            

            //------ Cadastrar cliente 
            Nome nomeCliente = new Nome("Marcello","Queiroz");
            Cliente cliente = new Cliente(
                nomeCliente,
                "M",
                "34547158",
                "Rua Carmelita",
                19
            );

            var fakeClienteReposiory = new FakeClienteRepository();
            fakeClienteReposiory.Save(cliente);

            //------ Gerar uma reserva
            //Buscar o cliente no banco
            Cliente clienteReserva = fakeClienteReposiory.GetById(Guid.NewGuid());

            //Define o horario da reserva
            Periodo periodoReserva = new Periodo(
                DateTime.Now,
                new DateTime(2019, 5, 3, 22, 00, 00)
            );

            Reserva novaReserva = new Reserva(
                34, 
                clienteReserva,
                periodoReserva
            );

            var fakeReservaRepository = new FakeReservaRepository();
            fakeReservaRepository.Save(novaReserva);
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
               new Cliente(
                   new Nome("Bruno", "Silva"),
                   "M",
                   "996587458",
                   "Rua das Orquídeas",
                   19
               ),
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
            return new Cliente(
                new Nome("Isabella", "Yamashita"),
                   "F",
                   "9965547458",
                   "Rua das Flores",
                   35
            );
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
