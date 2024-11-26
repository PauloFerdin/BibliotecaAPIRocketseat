using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaApi.Data.Map;

public class LivrosMap : IEntityTypeConfiguration<LivrosModel>
{
    public void Configure(EntityTypeBuilder<LivrosModel> builder)
    {
        builder.HasKey (x => x.Id);
        builder.Property (x => x.Titulo).IsRequired().HasMaxLength(255);
        builder.Property(x => x.Genero).IsRequired().HasMaxLength(150);
        builder.Property(x => x.Autor).IsRequired().HasMaxLength(150);
    }
}
