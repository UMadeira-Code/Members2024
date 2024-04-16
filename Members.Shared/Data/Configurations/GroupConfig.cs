using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Members.Shared.Data.Configurations
{
    internal class GroupConfig : MemberConfig<Group>
    {
        public override void Configure( EntityTypeBuilder<Group> builder )
        {
            base.Configure(builder);
            builder.HasMany( e => e.Members ).WithMany();
        }
    }
}
