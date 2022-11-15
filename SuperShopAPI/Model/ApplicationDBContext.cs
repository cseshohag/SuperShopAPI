using Microsoft.EntityFrameworkCore;

namespace SuperShopAPI.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}
