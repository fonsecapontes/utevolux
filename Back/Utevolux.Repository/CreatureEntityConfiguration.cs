using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Utevolux.Repository
{
    internal sealed class CreatureEntityConfiguration : IEntityTypeConfiguration<CreatureEntity>
    {
        public void Configure(EntityTypeBuilder<CreatureEntity> builder)
        {
            builder.ToTable("Creature");
            builder.HasKey(x => x.Id);
        }
    }
}
