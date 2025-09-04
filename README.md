# ProductsApi - .NET Core CRUD Example

This is a simple **CRUD API** built with **.NET 7**, **Entity Framework Core**, and **SQLite**, designed for learning and testing purposes.  
It includes **DTOs**, **Service Layer**, **Controllers**, and **Swagger UI** for easy API testing.

---

## Features

- Create, Read, Update, Delete products
- DTOs for safe data transfer
- EF Core for database operations
- Swagger UI for interactive API testing
- SQLite database for simplicity

---

## Folder Structure

ProductsApi/
┣ Controllers/
┃ ┗ ProductsController.cs
┣ Data/
┃ ┗ AppDbContext.cs
┣ Dtos/
┃ ┣ ProductCreateDto.cs
┃ ┣ ProductDto.cs
┃ ┗ ProductUpdateDto.cs
┣ Models/
┃ ┗ Product.cs
┣ Services/
┃ ┗ ProductService.cs
┣ Program.cs
┗ ProductsApi.csproj


---

## Requirements

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Visual Studio 2022 or VS Code
- Node.js (optional, if frontend integration)
- Postman or Swagger UI for API testing
- Git (for version control)

---

## Packages

Install the required NuGet packages:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Swashbuckle.AspNetCore
