using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanaMao.Domain.Gerencia.ValueObject
{
    public class Preco: TaNaMao.Shared.ValueObject.ValueObject
    {       
        public float Valor { get; set; }
        public string Moeda { get; set; }

        // Em função do entity framework
        protected Preco(){}

        public Preco (float valor, string moeda){
            Valor = valor;
            Moeda = moeda;

            AddNotifications(
                new Contract().Requires()
                .IsTrue(ValidateNegative(), "Valor", "O valor não pode ser negativo.")
                .IsTrue(ValidateCurrency(), "Moeda", "A moeda informada não é utilizada pelo sistema.")
            );
        }       

        private bool ValidateNegative()
        {
            // Preco nao pode ser negativo.
            if (Valor < 0)
            {
                return false;
            }

            return true;
        }

        private bool ValidateCurrency()
        {
            if(Moeda != "R$" && 
               Moeda != "$"  &&
               Moeda != "€"
            )
            {
                return false;
            }

            return true;
        }
    }
}
