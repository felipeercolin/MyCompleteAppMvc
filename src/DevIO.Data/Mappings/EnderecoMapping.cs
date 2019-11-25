using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(cd => cd.Id);

            builder.Property(cd => cd.Logradouro).IsRequired().HasColumnType("varchar(200)");
            builder.Property(cd => cd.Numero).IsRequired().HasColumnType("varchar(50)");
            builder.Property(cd => cd.Cep).IsRequired().HasColumnType("varchar(8)");
            builder.Property(cd => cd.Complemento).IsRequired().HasColumnType("varchar(250)");
            builder.Property(cd => cd.Bairro).IsRequired().HasColumnType("varchar(100)");
            builder.Property(cd => cd.Cidade).IsRequired().HasColumnType("varchar(100)");
            builder.Property(cd => cd.Estado).IsRequired().HasColumnType("varchar(50)");

            builder.ToTable("Enderecos", "dbo");
        }
    }
}