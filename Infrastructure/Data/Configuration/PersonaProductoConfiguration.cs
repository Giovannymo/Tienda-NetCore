using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Infrastructure.Data.Configuration;

public class PersonaProductoConfiguration : IEntityTypeConfiguration<PersonaProducto>
{
    public void Configure(EntityTypeBuilder<PersonaProducto> builder)
    {
        // En las tablas intermedias las llaves foraneas forman la clave principal de la tabla. Para poder
        //establecer la llave principal se debe realizar usando el modelBuilder. En la clase contexto.


        builder.ToTable("PersonaProducto");
        //Tabla intermedia es de uno a muchos
        builder.HasOne(p => p.Personas)
        .WithMany(p => p.PersonaProductos)
        .HasForeignKey(f=> f.IdPersona);

        builder.HasOne(p => p.Productos)
        .WithMany(p => p.PersonaProductos)
        .HasForeignKey(f=> f.IdProducto);

        
    }
}
