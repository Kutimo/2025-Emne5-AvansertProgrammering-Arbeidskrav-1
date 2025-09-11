using arbeidskrav_del_1.Models;
using Microsoft.EntityFrameworkCore;

namespace arbeidskrav_del_1.Data;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options) { }

    public DbSet<Books> Books => Set<Books>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Books>().HasData(
            new Books { Id = 1, Title = "C# Basics", Author = "John Doe", PublicationYear = 2020, ISBN = "978-1-11111-111-1", InStock = 10 },
            new Books { Id = 2, Title = "Advanced C#", Author = "Jane Smith", PublicationYear = 2021, ISBN = "978-1-22222-222-2", InStock = 5 },
            new Books { Id = 3, Title = "EF Core in Depth", Author = "Mark Johnson", PublicationYear = 2019, ISBN = "978-1-33333-333-3", InStock = 7 },
            new Books { Id = 4, Title = "ASP.NET Core Guide", Author = "Alice Brown", PublicationYear = 2022, ISBN = "978-1-44444-444-4", InStock = 12 },
            new Books { Id = 5, Title = "LINQ Essentials", Author = "Bob Martin", PublicationYear = 2018, ISBN = "978-1-55555-555-5", InStock = 8 },
            new Books { Id = 6, Title = "Blazor Unleashed", Author = "Carla White", PublicationYear = 2020, ISBN = "978-1-66666-666-6", InStock = 9 },
            new Books { Id = 7, Title = "Design Patterns C#", Author = "Daniel Lee", PublicationYear = 2017, ISBN = "978-1-77777-777-7", InStock = 4 },
            new Books { Id = 8, Title = "Clean Code C#", Author = "Eve Adams", PublicationYear = 2019, ISBN = "978-1-88888-888-8", InStock = 6 },
            new Books { Id = 9, Title = "Microservices with .NET", Author = "Frank Green", PublicationYear = 2021, ISBN = "978-1-99999-999-9", InStock = 11 },
            new Books { Id = 10, Title = "Unit Testing in C#", Author = "Grace Hall", PublicationYear = 2020, ISBN = "978-1-10101-101-0", InStock = 10 },
            new Books { Id = 11, Title = "Async Programming C#", Author = "Hank King", PublicationYear = 2018, ISBN = "978-1-11102-101-1", InStock = 7 },
            new Books { Id = 12, Title = "WPF Fundamentals", Author = "Irene Scott", PublicationYear = 2017, ISBN = "978-1-12121-121-2", InStock = 3 },
            new Books { Id = 13, Title = "MAUI Essentials", Author = "Jack Taylor", PublicationYear = 2022, ISBN = "978-1-13131-131-3", InStock = 5 },
            new Books { Id = 14, Title = "Entity Framework Core", Author = "Karen Young", PublicationYear = 2020, ISBN = "978-1-14141-141-4", InStock = 8 },
            new Books { Id = 15, Title = "SignalR in Action", Author = "Leo Wright", PublicationYear = 2019, ISBN = "978-1-15151-151-5", InStock = 6 },
            new Books { Id = 16, Title = "Azure for .NET Developers", Author = "Mia Roberts", PublicationYear = 2021, ISBN = "978-1-16161-161-6", InStock = 9 },
            new Books { Id = 17, Title = "Docker for .NET", Author = "Nathan Evans", PublicationYear = 2021, ISBN = "978-1-17171-171-7", InStock = 7 },
            new Books { Id = 18, Title = "Kubernetes .NET Apps", Author = "Olivia Perez", PublicationYear = 2022, ISBN = "978-1-18181-181-8", InStock = 5 },
            new Books { Id = 19, Title = "gRPC with .NET", Author = "Peter Hall", PublicationYear = 2020, ISBN = "978-1-19191-191-9", InStock = 6 },
            new Books { Id = 20, Title = "Modern C# Patterns", Author = "Quinn Lewis", PublicationYear = 2022, ISBN = "978-1-20202-202-0", InStock = 12 }
        );
    }
}