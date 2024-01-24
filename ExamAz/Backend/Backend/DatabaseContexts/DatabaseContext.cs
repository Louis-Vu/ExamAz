using Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.DatabaseContexts;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Order> OrderTbl { get; set; }
}
