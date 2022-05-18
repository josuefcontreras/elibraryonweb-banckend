# Library API

GBH just hired you to create an online library. It needs you to build a REST API which will allow our clients to consume the list of available books, as well as to read those books page by page in the desired formats. For this first iteration the books will be available (page by page) in plain text and HTML. In future iterations, we would like to add support for more reading formats, as well as support to interface with other online book service providers.

## Technical Requirements

- Get list of books
- Get a book
- Get a book page in the desired format
- Make use of friendly routes
  for example: `/book/1` or `/book/1 /page/11/html`
- Provide seeders / migrations for the database (books with their pages)
- Provide instruccions on project setup/configuration

## Rules

- Make use of the language mentioned in the email in which you got this test
- Do not use any frameworks. A good developer must know how to select his tools and how to use them.
- The use of third-party libraries is allowed and encouraged.- Make use of .gitignore, keep it clean.

## How to run the project

1. Install the latest [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
2. Navigate to `src/API` and run `dotnet run` to launch the back end (ASP.NET Core Web API)

ABOUT DATABASE: This project is using Sqlite to unsure anyone can run the solution without needing to set up additional infrastructure (e.g. SQL Server)

## Technologies used

- [ASP.NET Core 6](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
- [Entity Framework Core 6](https://docs.microsoft.com/en-us/ef/core/)
- [Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/)
- [MediatR](https://github.com/jbogard/MediatR)
- [AutoMapper](https://automapper.org/)
- [FluentValidation](https://fluentvalidation.net/)
