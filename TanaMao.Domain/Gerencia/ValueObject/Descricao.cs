using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaNaMao.Shared.ValueObject;

namespace TanaMao.Domain.Gerencia.ValueObjects
{
    public class Descricao : TaNaMao.Shared.ValueObject.ValueObject
    {
        public string TextoDescricao { get; set; }

        public Descricao(String textoDescricao)
        {
            TextoDescricao = textoDescricao;

            AddNotifications(
                new Contract().Requires()
                .IsTrue(ValidateEmpty(), "TextoDescricao", "A descrição não deve estar vazia.")    
                .IsTrue(ValidateLength(), "TextoDescricao", "A descrição deve conter entre 5 e 5000 caracteres")
                .IsTrue(ValidateChars(), "TextoDescricao", "A descrição não deve conter caracteres inválidos")
            );            
        }

        private bool ValidateEmpty()
        {
            // Descricoes nao devem estar vazias
            if (String.IsNullOrEmpty(TextoDescricao.Trim())) {
                return false;                
            }

            return true;
        }
        
        private bool ValidateLength()
        {
            // Toda descrição no nosso cenário deve possuir ao menos 5 caracteres e no máximo 5000
            if (TextoDescricao.Length < 5 || TextoDescricao.Length > 5000) {
                return false;
            }

            return true;
        }

        private bool ValidateChars()
        { 
            // Verifica se existem caracteres nao permitidos
            if (Regex.IsMatch(TextoDescricao, "[&#³|]")){
                return false;
            }
            
            return true;            
        }
    }
}
