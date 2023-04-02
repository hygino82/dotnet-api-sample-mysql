using Microsoft.EntityFrameworkCore;
using MySqlAPI.Model;

namespace MySqlAPI.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options)
            : base(options)
        { }

        public DbSet<Estado> Estado { get; set; }
    }
}
