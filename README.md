# basic usage:
$ dotnet new webapi -o folder/proyectName
$ dotnet run


# installed packages:

inmemory database for initial testin:
$ dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 3.1.5

scaffolding engine for new controlleres and views:
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet tool install --global dotnet-aspnet-codegenerator --version 3.1.3

    + use example
        dotnet-aspnet-codegenerator -p "C:\MyProject\MyProject.csproj" controller -name MyDemoModelController -api -m My.Namespace.Models.MyDemoModel -dc MyDemoDbContext -outDir Controllers -namespace My.Namespace.Controllers
