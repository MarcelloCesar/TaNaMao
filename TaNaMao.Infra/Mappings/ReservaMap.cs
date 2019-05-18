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
        // public Periodo PeriodoReserva { get; private set; }
        //public int NumeroMesa { get; private set; }
        //    public Cliente ClienteReserva { get; private set; }
        //   public DateTime DataConfirmacao { get; private set; }
        //  public bool confirmado;

        public ReservaMap() { 

            HasKey(x => x.Id);
            Property(x => x.PeriodoReserva.HorarioInicio);
            Property(x => x.PeriodoReserva.HorarioFinal);
            Property(x => x.NumeroMesa);
            HasRequired(x => x.ClienteReserva);
            Property(x => x.DataConfirmacao);
            //Property(x => x.Confirmado);

        }
    }
}
