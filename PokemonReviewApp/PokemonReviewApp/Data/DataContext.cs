using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;
using System.Collections.Generic;

namespace PokemonReviewApp.Data
{
    //Nuestro data context representara nuestras tablas de la base de datos
    public class DataContext : DbContext //DataContext hereda de DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Ahora traemos todas las tablas/modelos requeridas de nuestra DB
        /*DbSet representa la colección de todas las entidades(Tablas) del contexto, 
        o que se pueden consultar desde la base de datos, de un tipo determinado*/
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonOwner> PokemonOwners { get; set; }
        public DbSet<PokemonCategory> PokemonCategories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>() 
                .HasKey(pc => new { pc.PokemonId, pc.CategoryId }); //Basicamente le decimos a EF que necesitamos vincular estas dos id, de lo contrario EF no sabra que se requiere vincular
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonCategories)
                .HasForeignKey(c => c.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                .HasOne(p => p.Category)
                .WithMany(pc => pc.PokemonCategories)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
                .HasKey(po => new { po.PokemonId, po.OwnerId }); //Basicamente le decimos a EF que necesitamos vincular estas dos id, de lo contrario EF no sabra que se requiere vincular
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Pokemon)
                .WithMany(pc => pc.PokemonOwners)
                .HasForeignKey(c => c.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                .HasOne(p => p.Owner)
                .WithMany(pc => pc.PokemonOwners)
                .HasForeignKey(c => c.OwnerId);
        }
    }
}