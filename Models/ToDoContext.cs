using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Clase_1.Models
{
    // ToDoContext is derived from DbContext, which is a part of EF Core used to manage database operations for specific data models.
    public class ToDoContext : DbContext
    {
        public ToDoContext()
        {

        }

        // DbSet properties represent collections of the specified entities in the context.
        // These properties act as a proxy for querying and working with entity data in the database.
        public DbSet<ToDoItem> Items { get; set; } // Represents the ToDoItem table in the database.
        public DbSet<Categoria> Categorias { get; set; } // Represents the Categoria table in the database.

        // This method is overridden to configure the database (and other options) to be used for this context.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configures the context to connect to a Microsoft SQL Server database.
            optionsBuilder.UseSqlServer(
                "Data Source=LAPTOP-NG836ULB\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True;Encrypt=False"
                );
        }

        // This method is overridden to further configure the model that was discovered by convention from the entity types
        // exposed in DbSet properties on your derived context.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Calls the base method to complete the model creation.
            base.OnModelCreating(modelBuilder);

            // Seeds the database with initial data for the Categoria table.
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { Id = 1, Nombre = "Personal"},
                new Categoria { Id = 2, Nombre = "Trabajo"},
                new Categoria { Id = 3, Nombre = "Estudio"}
                );
        }
    }
}
