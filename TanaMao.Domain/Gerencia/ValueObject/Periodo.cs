using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanaMao.Domain.Gerencia.ValueObject
{
    public class Periodo : TaNaMao.Shared.ValueObject.ValueObject
    {
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFinal { get; set; }

        public Periodo(DateTime inicio, DateTime fim)
        {
            HorarioInicio = inicio;
            HorarioFinal = fim;

            AddNotifications(
                new Contract().Requires()
                .IsTrue(ValidatePeriod(), "HorarioFinal", "O horário final de um período não pode ser menor que o horário inicial.")
            );
        }

        private bool ValidatePeriod()
        {
            if(HorarioFinal < HorarioInicio)
            {
                return false;
            }

            return true;
        }
    }
}
