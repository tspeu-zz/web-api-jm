using Microsoft.EntityFrameworkCore;

using jm_web_api.Entities;

namespace jm_web_api.Domain
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
