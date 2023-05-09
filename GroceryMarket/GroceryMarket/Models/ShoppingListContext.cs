using Microsoft.EntityFrameworkCore;
namespace GroceryMarket.Models
{
    public class ShoppingListContext : DbContext
    {
        public ShoppingListContext(DbContextOptions<ShoppingListContext> options):base(options)
        {

        }
        public DbSet<Grocery> Groceries { get; set; }
    }
}
