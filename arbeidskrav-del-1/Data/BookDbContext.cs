using arbeidskrav_del_1.Models;
using Microsoft.EntityFrameworkCore;

namespace arbeidskrav_del_1.Data;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
    {
    }

    public DbSet<Books> Books => Set<Books>();
}