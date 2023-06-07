using DonerNet.Models;
using Microsoft.EntityFrameworkCore;

namespace DonerNet.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<DonerOrder> DonerOrders { get; set; }

        public DbSet<Review> Reviews { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
