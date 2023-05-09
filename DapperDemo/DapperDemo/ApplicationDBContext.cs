using DapperDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DapperDemo
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<Company> Companies { get; set; }
    }
}
