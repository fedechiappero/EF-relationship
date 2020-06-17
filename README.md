# basic usage:
$ dotnet new webapi -o folder/proyectName
$ dotnet run


# installed packages:

inmemory database for initial testin:
$ dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 3.1.5

i ended up using SQLite for data persistence
$ dotnet add package Microsoft.EntityFrameworkCore.Sqlite
$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer

scaffolding engine for new controlleres and views (requires Microsoft.EntityFrameworkCore.SqlServer):
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet tool install --global dotnet-aspnet-codegenerator --version 3.1.3

    + use example
        dotnet-aspnet-codegenerator -p "C:\MyProject\MyProject.csproj" controller -name MyDemoModelController -api -m My.Namespace.Models.MyDemoModel -dc MyDemoDbContext -outDir Controllers -namespace My.Namespace.Controllers

    + dotnet aspnet-codegenerator controller -name BlogController -async -api -m Blog -dc TestContext -outDir Controllers

migrations utilities
$ dotnet tool install --global dotnet-ef

$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
