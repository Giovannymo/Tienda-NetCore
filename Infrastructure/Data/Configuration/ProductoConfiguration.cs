using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        // Aquí puedes configurar las propiedades de la entidad Marca
        // utilizando el objeto 'builder'.
        builder.ToTable("Producto");
        builder.Property(p => p.IdProducto)
        .IsRequired()
        .HasMaxLength(15);

        builder.Property(p => p.NombreProducto)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.Descripcion)
        .HasColumnType("text");

        builder.Property(p => p.Precio)
        .HasColumnType("double");

        builder.Property(p => p.StockMinimo)
        .HasColumnType("int");

        builder.Property(p => p.StockMaximo)
        .HasColumnType("int");


    }
}
