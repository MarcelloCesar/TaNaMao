using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;

namespace TaNaMao.Infra.Mappings
{
    class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        /*        public Nome NomePessoa { get; private set; }
        public string Sexo { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public int Idade { get; private set; }*/

        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.Id);
            Property(x => x.Sexo).HasMaxLength(1).IsFixedLength();
            Property(x => x.Telefone).HasMaxLength(10);
            Property(x => x.Endereco).HasMaxLength(60);
            Property(x => x.Idade).IsRequired();
        }
    }
}
