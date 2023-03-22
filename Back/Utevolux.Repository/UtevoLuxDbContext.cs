using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Utevolux.Repository
{
    public class UtevoLuxDbContext : DbContext
    {
        public UtevoLuxDbContext(DbContextOptions<UtevoLuxDbContext> options)
            : base(options)
        {

        }

        public DbSet<CreatureEntity> Creature { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
