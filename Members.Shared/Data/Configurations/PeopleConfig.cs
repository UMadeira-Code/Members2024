using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Members.Shared.Data.Configurations
{
    internal class PersonConfig : MemberConfig<Person>
    {
        public override void Configure( EntityTypeBuilder<Person> builder )
        {
            base.Configure(builder);
        }
    }
}
