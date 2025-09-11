using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace arbeidskrav_del_1.Migrations
{
    /// <inheritdoc />
    public partial class SeedBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Author = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PublicationYear = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "InStock", "PublicationYear", "Title" },
                values: new object[,]
                {
                    { 1, "John Doe", "978-1-11111-111-1", 10, 2020, "C# Basics" },
                    { 2, "Jane Smith", "978-1-22222-222-2", 5, 2021, "Advanced C#" },
                    { 3, "Mark Johnson", "978-1-33333-333-3", 7, 2019, "EF Core in Depth" },
                    { 4, "Alice Brown", "978-1-44444-444-4", 12, 2022, "ASP.NET Core Guide" },
                    { 5, "Bob Martin", "978-1-55555-555-5", 8, 2018, "LINQ Essentials" },
                    { 6, "Carla White", "978-1-66666-666-6", 9, 2020, "Blazor Unleashed" },
                    { 7, "Daniel Lee", "978-1-77777-777-7", 4, 2017, "Design Patterns C#" },
                    { 8, "Eve Adams", "978-1-88888-888-8", 6, 2019, "Clean Code C#" },
                    { 9, "Frank Green", "978-1-99999-999-9", 11, 2021, "Microservices with .NET" },
                    { 10, "Grace Hall", "978-1-10101-101-0", 10, 2020, "Unit Testing in C#" },
                    { 11, "Hank King", "978-1-11102-101-1", 7, 2018, "Async Programming C#" },
                    { 12, "Irene Scott", "978-1-12121-121-2", 3, 2017, "WPF Fundamentals" },
                    { 13, "Jack Taylor", "978-1-13131-131-3", 5, 2022, "MAUI Essentials" },
                    { 14, "Karen Young", "978-1-14141-141-4", 8, 2020, "Entity Framework Core" },
                    { 15, "Leo Wright", "978-1-15151-151-5", 6, 2019, "SignalR in Action" },
                    { 16, "Mia Roberts", "978-1-16161-161-6", 9, 2021, "Azure for .NET Developers" },
                    { 17, "Nathan Evans", "978-1-17171-171-7", 7, 2021, "Docker for .NET" },
                    { 18, "Olivia Perez", "978-1-18181-181-8", 5, 2022, "Kubernetes .NET Apps" },
                    { 19, "Peter Hall", "978-1-19191-191-9", 6, 2020, "gRPC with .NET" },
                    { 20, "Quinn Lewis", "978-1-20202-202-0", 12, 2022, "Modern C# Patterns" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
