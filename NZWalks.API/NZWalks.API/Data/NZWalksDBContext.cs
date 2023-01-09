using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;
using System.Security.Cryptography.X509Certificates;

namespace NZWalks.API.Data
{
    //Esta clase herada de DBContext class
    public class NZWalksDBContext : DbContext
    {
        /*DbSet representa la colección de todas las entidades del contexto, 
        o que se pueden consultar desde la base de datos, de un tipo determinado.
        Los objetos DbSet se crean a partir de dbContext mediante el método DbContext.
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options): base(options)*/

        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options): base(options)
        {
            
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulty { get; set; }
    }
}
