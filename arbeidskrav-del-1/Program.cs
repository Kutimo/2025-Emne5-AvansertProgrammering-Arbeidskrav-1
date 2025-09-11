using arbeidskrav_del_1.Data;
using arbeidskrav_del_1.Models;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

namespace arbeidskrav_del_1;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();
        
        // Configure MySQL connection
        builder.Services.AddDbContext<BooksDbContext>( options => 
            options.UseMySql(
                builder.Configuration.GetConnectionString("DefaultConnection"),
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
            )
        );
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference();
        }
        
        app.MapGet("/books", async (BooksDbContext db) =>
        {
            var books = await db.Books.ToListAsync();
            return Results.Ok(books);
        });
        
        // CREATE
        app.MapPost("/books", async (Books books, BooksDbContext db) =>
        {
            db.Books.Add(books);
            await db.SaveChangesAsync();
            return Results.Created($"/books/{books.Id}", books);
        });
        
        app.UseHttpsRedirection();

        app.UseAuthorization();

        

        app.Run();
    }
}