using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.Entidades;

namespace TaNaMao.Infra.Mappings
{
    // classe para permitir o mapeamenton do banco. Tem que herdar desta classe passando um tipo
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Pode mudar o nome da tabela. Se nao informado mantem produto
            //ToTable("");

            // Informa que a entidade tem uma chave de identificacao
            HasKey(x => x.Id);

            Property(x => x.NomeProduto)
                // Not null
                .IsRequired()
                //Define o tamanho maximo
                .HasMaxLength(11)
                // Nao vira varchar, vira char
                .IsFixedLength();

            Property(x => x.DescricaoProduto.TextoDescricao).IsRequired();
            Property(x => x.PrecoProduto.Valor);
            Property(x => x.PrecoProduto.Moeda);
            Property(x => x.Disponivel);
            Property(x => x.TipoProduto);
        }          
    }
}
