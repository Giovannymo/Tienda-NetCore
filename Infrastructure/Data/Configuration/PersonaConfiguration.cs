using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;


public class PersonaConfiguration : IEntityTypeConfiguration<Persona> 
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        // Aquí puedes configurar las propiedades de la entidad Marca
        // utilizando el objeto 'builder'.
        builder.ToTable("Persona");
        builder.Property(p => p.IdPersona)
        .IsRequired()
        .HasMaxLength(15);

        builder.Property(p => p.NombrePersona)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.ApellidosPersona)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.EmailPersona)
        .IsRequired()
        .HasMaxLength(100);
                                                                                         
        builder.HasOne(p => p.TipoPersona)
        .WithMany(p => p.Personas)
        .HasForeignKey(p => p.IdTipoPersonaFk);
        
        builder.HasOne(r => r.Region)
        .WithMany(r => r.Personas)
        .HasForeignKey(p => p.IdRegionFk);




    }
}
