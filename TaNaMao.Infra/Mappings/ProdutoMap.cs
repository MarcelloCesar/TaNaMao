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
            ToTable("Produto");  // Pode mudar o nome da tabela. Se nao informado mantem o nome da classe configurada
            HasKey(x => x.Id);   // Informa que a entidade tem uma chave de identificacao
            Property(x => x.NomeProduto).IsRequired().HasMaxLength(11).IsFixedLength();  // Not null; Define o tamanho maximo; Nao vira varchar, vira char
            Property(x => x.DescricaoProduto.TextoDescricao).IsRequired();
            Property(x => x.PrecoProduto.Valor).IsRequired(); //Mapeamento de VO
            Property(x => x.PrecoProduto.Moeda);              //Mapeamento de VO
            Property(x => x.Disponivel);
            Property(x => x.TipoProduto); //É um enum, vira inteiro no banco
        }
    }
}
