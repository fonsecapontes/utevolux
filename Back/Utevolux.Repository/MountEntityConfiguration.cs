using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Utevolux.Repository
{
    internal sealed class MountEntityConfiguration : IEntityTypeConfiguration<MountEntity>
    {
        public void Configure(EntityTypeBuilder<MountEntity> builder)
        {
            builder.ToTable("Mount");
            builder.HasKey(x => x.Id);
        }
    }
}
