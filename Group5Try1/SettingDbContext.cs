using Group5Try1.Models;
using Microsoft.EntityFrameworkCore;

namespace Group5Try1
{
    public class SettingDbContext : DbContext
    {
        public SettingDbContext(DbContextOptions<SettingDbContext> Options) : base(Options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<PLocation> PLocations { get; set; }

        
    }
}
