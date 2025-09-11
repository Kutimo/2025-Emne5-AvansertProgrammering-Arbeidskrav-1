take my pdf and please make a list of everything i need to do in a md file

response is the todo.md file

help me seed the db with 20 books with efcore: Id (int): En unik identifikator for boken. Title (string): Bokens tittel. Author (string): Forfatteren av boken. PublicationYear (int): Året boken ble publisert. ISBN (string): Den internasjonale standardboknummeret for boken. InStock (int): Mengden av denne boken som er tilgjengelig i bokhandelen.

res:
using Microsoft.EntityFrameworkCore;

public class BooksDbContext : DbContext
{
public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options) { }

    public DbSet<Book> Books => Set<Book>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "C# Basics", Author = "John Doe", PublicationYear = 2020, ISBN = "978-1-11111-111-1", InStock = 10 },
            new Book { Id = 2, Title = "Advanced C#", Author = "Jane Smith", PublicationYear = 2021, ISBN = "978-1-22222-222-2", InStock = 5 },
            new Book { Id = 3, Title = "EF Core in Depth", Author = "Mark Johnson", PublicationYear = 2019, ISBN = "978-1-33333-333-3", InStock = 7 },
            new Book { Id = 4, Title = "ASP.NET Core Guide", Author = "Alice Brown", PublicationYear = 2022, ISBN = "978-1-44444-444-4", InStock = 12 },
            new Book { Id = 5, Title = "LINQ Essentials", Author = "Bob Martin", PublicationYear = 2018, ISBN = "978-1-55555-555-5", InStock = 8 },
            new Book { Id = 6, Title = "Blazor Unleashed", Author = "Carla White", PublicationYear = 2020, ISBN = "978-1-66666-666-6", InStock = 9 },
            new Book { Id = 7, Title = "Design Patterns C#", Author = "Daniel Lee", PublicationYear = 2017, ISBN = "978-1-77777-777-7", InStock = 4 },
            new Book { Id = 8, Title = "Clean Code C#", Author = "Eve Adams", PublicationYear = 2019, ISBN = "978-1-88888-888-8", InStock = 6 },
            new Book { Id = 9, Title = "Microservices with .NET", Author = "Frank Green", PublicationYear = 2021, ISBN = "978-1-99999-999-9", InStock = 11 },
            new Book { Id = 10, Title = "Unit Testing in C#", Author = "Grace Hall", PublicationYear = 2020, ISBN = "978-1-10101-101-0", InStock = 10 },
            new Book { Id = 11, Title = "Async Programming C#", Author = "Hank King", PublicationYear = 2018, ISBN = "978-1-11102-101-1", InStock = 7 },
            new Book { Id = 12, Title = "WPF Fundamentals", Author = "Irene Scott", PublicationYear = 2017, ISBN = "978-1-12121-121-2", InStock = 3 },
            new Book { Id = 13, Title = "MAUI Essentials", Author = "Jack Taylor", PublicationYear = 2022, ISBN = "978-1-13131-131-3", InStock = 5 },
            new Book { Id = 14, Title = "Entity Framework Core", Author = "Karen Young", PublicationYear = 2020, ISBN = "978-1-14141-141-4", InStock = 8 },
            new Book { Id = 15, Title = "SignalR in Action", Author = "Leo Wright", PublicationYear = 2019, ISBN = "978-1-15151-151-5", InStock = 6 },
            new Book { Id = 16, Title = "Azure for .NET Developers", Author = "Mia Roberts", PublicationYear = 2021, ISBN = "978-1-16161-161-6", InStock = 9 },
            new Book { Id = 17, Title = "Docker for .NET", Author = "Nathan Evans", PublicationYear = 2021, ISBN = "978-1-17171-171-7", InStock = 7 },
            new Book { Id = 18, Title = "Kubernetes .NET Apps", Author = "Olivia Perez", PublicationYear = 2022, ISBN = "978-1-18181-181-8", InStock = 5 },
            new Book { Id = 19, Title = "gRPC with .NET", Author = "Peter Hall", PublicationYear = 2020, ISBN = "978-1-19191-191-9", InStock = 6 },
            new Book { Id = 20, Title = "Modern C# Patterns", Author = "Quinn Lewis", PublicationYear = 2022, ISBN = "978-1-20202-202-0", InStock = 12 }
        );
    }
}
