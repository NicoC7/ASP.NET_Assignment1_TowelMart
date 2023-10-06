using Microsoft.EntityFrameworkCore;
using TowelMart.Models;

namespace TowelMart.Data
{
    public class TowelMartContext : DbContext
    {
        public TowelMartContext(DbContextOptions<TowelMartContext> options)
            : base(options)
        {
        }

        public DbSet<Towel> Towel { get; set; }
    }
}