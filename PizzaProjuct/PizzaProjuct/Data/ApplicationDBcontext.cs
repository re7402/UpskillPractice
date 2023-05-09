using Microsoft.EntityFrameworkCore;
using PizzaProjuct.Models;

namespace PizzaProjuct.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<PizzaOrders> orders { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
}
