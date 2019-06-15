using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaNaMao.Shared.Entities;
using TanaMao.Domain.Gerencia.ValueObject;

namespace TanaMao.Domain.Gerencia.Entidades
{
    public class Cliente : Entity
    {
        public Nome NomePessoa { get; private set; }
        public string Sexo { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public int Idade { get; private set; }

        protected Cliente(){}

        public Cliente(Nome nomePessoa, string sexo, string telefone, string endereco, int idade)
        {
            NomePessoa = nomePessoa;
            Sexo = sexo;
            Telefone = telefone;
            Endereco = endereco;
            Idade = idade;
        }
    }
}