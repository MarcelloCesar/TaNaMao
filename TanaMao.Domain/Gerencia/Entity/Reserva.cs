using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.ValueObject;
using TaNaMao.Shared.Entities;

namespace TanaMao.Domain.Gerencia.Entidades
{
    public class Reserva : Entity
    {
        public Periodo PeriodoReserva { get; private set; }
        public int NumeroMesa { get; private set; }
        public Cliente ClienteReserva { get; private set;}
        public DateTime DataConfirmacao { get; private set; }
        public bool Confirmado;

        public Reserva(
            int mesa,
            Cliente cliente,
            Periodo Periodo
        )
        {
            NumeroMesa = mesa;
            ClienteReserva = cliente;
            PeriodoReserva = Periodo;
        }

        public void ConfirmarReserva()
        {
            Confirmado = true;
            DataConfirmacao = DateTime.Now;
        }

    }
}
