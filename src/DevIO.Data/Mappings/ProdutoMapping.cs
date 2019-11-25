using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(cd => cd.Id);

            builder.Property(cd => cd.Nome).IsRequired().HasColumnType("varchar(200)");
            builder.Property(cd => cd.Descricao).IsRequired().HasColumnType("varchar(1000)");
            builder.Property(cd => cd.Imagem).IsRequired().HasColumnType("varchar(100)");
            
            builder.ToTable("Produtos", "dbo");
        }
    }
}
