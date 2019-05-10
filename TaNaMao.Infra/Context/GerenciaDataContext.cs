using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TanaMao.Domain.Gerencia.Entidades;

namespace TaNaMao.Infra.Context
{
    public class GerenciaDataContext : DbContext
    {
        public GerenciaDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GerenciaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }      

    }
}
