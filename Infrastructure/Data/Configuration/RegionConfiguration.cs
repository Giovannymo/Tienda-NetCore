using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;


    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("Region");

            builder.Property(p => p.CodRegion )
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasMaxLength(3);
        
            builder.Property(p => p.NombreRegion)
            .IsRequired()
            .HasMaxLength(50);
            
            builder.HasOne(p => p.Estado)
            .WithMany(p => p.Regiones)
            .HasForeignKey(p => p.CodEstado);
        }
    }
