using Microsoft.EntityFrameworkCore;
using Members.Shared.Data.Configurations;

namespace Members.Shared.Data
{
    public class MembersContext : DbContext
    {
        public MembersContext()
        {
        }

        public MembersContext( DbContextOptions<MembersContext> options ) : base( options )
        {
        }

        protected override void OnConfiguring( DbContextOptionsBuilder builder )
        {
            base.OnConfiguring( builder );

            builder
                .UseSqlServer(
                    @"data source=(LocalDb)\MSSQLLocalDB;" +
                    @"initial catalog=Members2024;" +
                    @"integrated security=True; " +
                    @"MultipleActiveResultSets=True" );
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            base.OnModelCreating( modelBuilder );

            modelBuilder.ApplyConfiguration( new PersonConfig() );
            modelBuilder.ApplyConfiguration( new GroupConfig() );
        }
    }
}
