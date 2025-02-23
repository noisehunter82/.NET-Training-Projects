To create a new model and database context classes based on existing database.

1. Intall the following packages.

- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools - Optional: Install only if you want to use Visual Studion's Package Manager Console (PMC) commands.

2. Scaffold the promotions context and coupon model.
- .NET CLI:
`dotnet ef dbcontext scaffold <connection string> Microsoft.EntityFrameworkCore.Sqlite --context-dir Data --output-dir Models`

- PMC:
`Scaffold-DbContext <connection string> <context provider> -ContextDir Data -OutputDir Models -DataAnnotations`

'context string' - make sure there are not double '\\' characters in server path
'context provider' - examples: 'Microsoft.EntityFrameworkCore.SqlServer', 'Microsoft.EntityFrameworkCore.Sqlite', etc.