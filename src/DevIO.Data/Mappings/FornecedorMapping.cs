using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(cd => cd.Id);

            builder.Property(cd => cd.Nome).IsRequired().HasColumnType("varchar(200)");
            builder.Property(cd => cd.Documento).IsRequired().HasColumnType("varchar(14)");

            // 1 = 1 => Fornecedor : Endereco
            builder.HasOne(cd => cd.Endereco)
                .WithOne(cd => cd.Fornecedor)
                .HasForeignKey<Endereco>(cd => cd.FornecedorId);

            // 1 = N => Fornecedor : Produtos
            builder.HasMany(cd => cd.Produtos)
                .WithOne(cd => cd.Fornecedor)
                .HasForeignKey(cd => cd.FornecedorId);

            builder.ToTable("Fornecedores", "dbo");
        }
    }
}