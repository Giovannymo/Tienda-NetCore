using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data;

public class TiendaContext : DbContext
{
    public TiendaContext(DbContextOptions<TiendaContext> options) : base(options)
    {
    }
    public DbSet<Pais>? Paises { get; set; }
    public DbSet<Estado>? Estados { get; set; }
    public DbSet<Region>? Regiones { get; set; }
    public DbSet<Persona>? Personas { get; set; }
    public DbSet<TipoPersona>? TipoPersonas { get; set; }
    public DbSet<Producto>? Productos { get; set; }
    public DbSet<PersonaProducto> PersonaProductos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>().HasIndex(idx => idx.EmailPersona).IsUnique();
        modelBuilder.Entity<PersonaProducto>().HasKey(r => new { r.IdPersonaFk, r.IdProductoFk });
        modelBuilder.Entity<TipoPersona>().HasKey(r => new { r.IdTipoPersona });
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
