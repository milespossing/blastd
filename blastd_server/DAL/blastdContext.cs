using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blastd.Models;

namespace blastd_server.DAL
{
    public class BlastdContext : DbContext
    {
        public BlastdContext(DbContextOptions<BlastdContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=blastdserver.database.windows.net;Initial Catalog=blastd;User ID=developer;Password='raz69kpYikkln|A,xfousfM6msFT7_&#$!~<wagin6ujdyrp';Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SponsorRelationship>()
                .HasOne(sr => sr.Accountable)
                .WithMany(u => u.Sponsors);

            builder.Entity<SponsorRelationship>()
                .HasOne(sr => sr.Sponsor)
                .WithMany(u => u.Reports);
        }

        public DbSet<User> Users { get; set; }
    }
}
