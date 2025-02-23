EFCore tutorial - create new SQL Server database from model.

1. Install packages:
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools - Optional: Install only if you want to use Visual Studion's Package Manager Console (PMC) commands.

2. Create new model and context.

3. Create new migration action.
 - .NET CLI: `dotnet ef migrations add <MigrationNameInPascalCase> --context <context class name>`
 - Package Manager Console (VS only): `Add-Migration <MigrationNameInPascalCase>`
 (optional `-Context <context class name>` must be added if multiple databases are used).

4. Update database
- .NET CLI: `dotnet ef database update --context <context class name>`
- Package Manager Console (VS only): `Update-Database` 
(optional `-Context <context class name>` must be added if multiple databases are used)

5. To make further changes to databse chema, repeat steps 3 and 4.