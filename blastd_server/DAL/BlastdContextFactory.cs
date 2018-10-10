using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace blastd_server.DAL
{
    public class BlastdContextFactory : IDesignTimeDbContextFactory<BlastdContext>
    {
        public BlastdContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<BlastdContext> builder = new DbContextOptionsBuilder<BlastdContext>();
            return new BlastdContext(builder.Options);
        }

        public static BlastdContext CreateDbContext()
        {
            return CreateDbContext();
        }
    }
}
