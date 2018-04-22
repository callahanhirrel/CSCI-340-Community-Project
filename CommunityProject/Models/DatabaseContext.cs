using System;
using Microsoft.EntityFrameworkCore;

namespace CommunityProject.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<CommunityProject.Models.BowlathonInfo> BowlathonInfo { get; set; }
        public DbSet<CommunityProject.Models.FishingDerbyInfo> FishingDerbyInfo { get; set; }
        public DbSet<CommunityProject.Models.WalkathonInfo> WalkathonInfo { get; set; }
    }
}
