using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Enum;
using TanaMao.Domain.Gerencia.ValueObject;
using TanaMao.Domain.Gerencia.ValueObjects;
using TaNaMao.Shared.Entities;

namespace TanaMao.Domain.Gerencia.Entidades
{
    public class Produto : Entity
    {
        public Descricao DescricaoProduto { get; private set; }
        public Preco PrecoProduto { get; private set; }
        public bool Disponivel { get; private set; }    
        public string NomeProduto { get; private set; }
        public TipoProdutoEnum TipoProduto { get; private set; }

        // Em função do entity framework
        protected Produto(){}

        public Produto(
            string nome,
            Descricao desc,
            Preco val,
            TipoProdutoEnum tipo
        )
        {
            NomeProduto = nome;
            DescricaoProduto = desc;
            PrecoProduto = val;
            TipoProduto = tipo;
        }

        public void TornarDisponivel()
        {
            Disponivel = true;
        }

        public void TornarIndisponivel()
        {
            Disponivel = false;
        }
    }
}
