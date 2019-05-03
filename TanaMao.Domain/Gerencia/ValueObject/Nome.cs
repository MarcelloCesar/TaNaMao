using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TanaMao.Domain.Gerencia.ValueObject
{
    public class Nome : TaNaMao.Shared.ValueObject.ValueObject
    {
        public string NomePessoa { get; set; }
        public string SobrenomePessoa { get; set; }

        public Nome(string nomePessoa, string sobrenomePessoa)
        {
            NomePessoa = nomePessoa;
            SobrenomePessoa = sobrenomePessoa;

            AddNotifications(
                new Contract().Requires()
                .IsTrue(ValidateEmpty(NomePessoa), "nome", "O campo nome não deve estar vazio.")
                .IsTrue(ValidateEmpty(SobrenomePessoa), "SobrenomePessoa", "O campo sobrenome não deve estar vazio.")
                .IsTrue(ValidateLength(NomePessoa), "nome", "O campo nome deve conter entre 1 e 100 caracteres")
                .IsTrue(ValidateLength(SobrenomePessoa), "SobrenomePessoa", "O campo sobrenome deve conter entre 1 e 100 caracteres")
                .IsTrue(ValidateChars(NomePessoa), "nome", "O campo nome não deve conter caracteres inválidos")
                .IsTrue(ValidateChars(SobrenomePessoa), "SobrenomePessoa", "O campo sobrenome não deve conter caracteres inválidos")
            );
        }


        private bool ValidateEmpty(string nome)
        {
            // campo nome e sobrenome nao devem estar vazios
            if (String.IsNullOrEmpty(nome.Trim()))
            {
                return false;
            }

            return true;
        }

        private bool ValidateLength(string nome)
        {
            // Todo nome e sbrenome no nosso cenário deve possuir ao menos 1 caracteres e no máximo 100
            if (nome.Length < 1 || nome.Length > 100)
            {
                return false;
            }

            return true;
        }

        private bool ValidateChars(string nome)
        {
            // Verifica se existem caracteres nao permitidos
            if (Regex.IsMatch(nome, "[&#³|@]"))
            {
                return false;
            }

            return true;
        }
    }
}
