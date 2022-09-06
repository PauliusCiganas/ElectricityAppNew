using ElectricityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityApp.Data
{
    public class Database : DbContext
    {
        public Database (DbContextOptions<Database>options) : base(options) { }

        public DbSet<DomesticUser> DomesticUsers { get; set; }
    }
}
