using Microsoft.EntityFrameworkCore;
using registro_clase.entidades;
namespace registro_clase.DAL{
public class Contexto: DbContext{
    public DbSet<Actores> Actores {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
        optionsBuilder.UseSqlite(@"Data Source=Peliculas.db");
    }
}
}