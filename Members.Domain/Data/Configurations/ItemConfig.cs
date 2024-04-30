using Members.Core.Data;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Members.Domain.Data.Configurations
{
    internal class ItemConfig<T> : IEntityTypeConfiguration<T> where T : Item
    {
        public virtual void Configure( EntityTypeBuilder<T> builder )
        {
            builder.HasKey( e => e.Id );
            builder.Property( e => e.Id ).UseIdentityColumn();

            builder.Property( e => e.TimeStamp )
                .IsConcurrencyToken()
                .ValueGeneratedOnAddOrUpdate();
        }
    }
}
