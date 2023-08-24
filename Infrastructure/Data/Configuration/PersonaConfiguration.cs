using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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

        //Se relaciona un tipo de persona a muchas persona
        builder.HasOne(p => p.TipoPersona)
        .WithMany(e => e.Personas)
        .HasForeignKey(f => f.IdTipoPersona);

        //Relacion una persona tiene una Region pero una
        //region tiene muchas personas
        builder.HasOne(p => p.Region)
        .WithMany(e => e.Personas)
        .HasForeignKey(f => f.IdRegion)


    }
}
