using APIClothingMAYIOZ.Model;
using Microsoft.EntityFrameworkCore;

namespace APIClothingMAYIOZ.Data
{
    public class ClothingDbContext : DbContext
    {
        public ClothingDbContext(DbContextOptions<ClothingDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Talle> Talles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>

                {
                    entity.HasKey(p => p.IdProducto);
                    entity.Property(p => p.Precio).HasColumnType("decimal(18,2)");
                }
            );
        }
    }
}
