using Members.Domain.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Members.Domain.Data.Configurations
{
    internal class PersonConfig : MemberConfig<Person>
    {
        public override void Configure( EntityTypeBuilder<Person> builder )
        {
            base.Configure( builder );
        }
    }
}
