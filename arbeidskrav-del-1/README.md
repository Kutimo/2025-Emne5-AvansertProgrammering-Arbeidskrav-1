# Arbeidskrav 1 Avansert programmering

## Introduction
I created a simple web api that connects to a mysql server, I have done 
many projects like this earlier, so those were used as reference.

To start, we need to have a mysql instance running, so either add a db 
called books and add the connection string in appsettings.json 
or run to use the docker file provided:
```bash
    docker compose up -d
```

Then add all the credentials needed in the ```appsettings.json``` i
(This is not best practice and .env files is the way to go)
next we need to add a migration and update the db context:

TODO: remove db migrations!!!
```bash
dotnet ef migrations add SeedBooks
```
```bash
dotnet ef database update 
```
Then run the project:
```bash
dotnet run
```

Then we can use the scalar gui in the browser to test all the endpoints.
http://localhost:5039/scalar (possibly, as the localhost may vary)


# Review
I like the simplicity of ef core and minimal api, I enjoy working with 
 these tools, and I look forward to expand on this arbeidskrav.
