Web UI for updating SQL database with EFc CRUD.

1. Create new Razor project.

2. Install packages.

- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools - Optional: Install only if you want to use Visual Studion's Package Manager Console (PMC) commands.

3. Scaffold enitiy model and db context based on existing database (or the othwer way around).
- PMC:
`Scaffold-DbContext <connection string> <context provider> -ContextDir Data -OutputDir Models -DataAnnotations`

4. Create new folder ('Products') in 'Pages'.

5. Right-click on the folder and 'Add' => 'New Scaffolded Item'.

6. Slect 'Razor Pages using Entity Framework (CRUD)'.

7. Repeat for other tables.

