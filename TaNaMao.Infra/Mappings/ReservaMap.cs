using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;

namespace TaNaMao.Infra.Mappings
{
    class ReservaMap : EntityTypeConfiguration<Reserva>
    {

        public ReservaMap() {
            ToTable("Reserva");
            HasKey(x => x.Id);
            Property(x => x.PeriodoReserva.HorarioInicio).IsRequired();
            Property(x => x.PeriodoReserva.HorarioFinal);
            Property(x => x.NumeroMesa);
            HasRequired(x => x.ClienteReserva);
            Property(x => x.DataConfirmacao);
            Property(x => x.Confirmado);

        }
    }
}
