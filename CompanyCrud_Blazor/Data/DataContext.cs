using CompanyCrud_Blazor.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyCrud_Blazor.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

    }
}
