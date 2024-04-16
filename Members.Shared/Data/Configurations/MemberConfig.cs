using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Members.Shared.Data.Configurations
{
    internal class MemberConfig<T> : ItemConfig<T> where T : Member
    {
        public override void Configure( EntityTypeBuilder<T> builder )
        {
            base.Configure(builder);
        }
    }
}
