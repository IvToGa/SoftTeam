using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class AppContext : DbContext
    {

        public DbSet<EntidadPersona> Personas {get; set;}
        public DbSet<EntidadVeterinario> Veterinarios {get; set;}
        public DbSet<EntidadGestor> Gestor {get; set;}
        public DbSet<EntidadMascota> Mascotas {get; set;}
        public DbSet<EntidadVacunas> Vacunas {get; set;}
        public DbSet<EntidadHistoriaClinica> HistoriasClinicas {get; set;}
        public DbSet<EntidadCuidador> Cuidadores {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            
            if(!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source = BLACKY\\SQLEXPRESS; Initial Catalog = VeterinariaBD;User Id=sa;Password=adminadmin");
            }

        }
        

    }
    
}