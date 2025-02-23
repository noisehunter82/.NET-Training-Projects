using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Rewrite;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddSingleton<ITaskService>(new InMemoryTaskService());

// Build Webapp.
var app = builder.Build();

// MIDDLEWARE

// Custom middleware - log info for incoming request.
app.Use(async (context, next) =>
{
    Console.WriteLine($"[{context.Request.Method} {context.Request.Path} {DateTime.UtcNow}] Received.");
    // This step 
    await next(context);
});

// Built-in middleware (applied to all incoming requests) that rewrites paths of the request.
// All request with path containing "task" will be redirected to "todos".
// Adding "$1" ensures that original path params will be kept.
// For more regex and replacement string examples see; https://learn.microsoft.com/en-us/aspnet/core/fundamentals/url-rewriting?view=aspnetcore-8.0#regex-examples
app.UseRewriter(new RewriteOptions().AddRedirect("tasks/(.*)", "todos/$1"));

// Custom middleware - log the end of the middleware chain. Ntice that requests to "/tasks" are never finished - instead they are redirected to "/todos".
app.Use(async (context, next) =>
{
    Console.WriteLine($"[{context.Request.Method} {context.Request.Path} {DateTime.UtcNow}] Finished.");

    await next();
});


// ENDPOINTS

app.MapGet("/todos", (ITaskService service) => service.GetTodos());

app.MapGet("/todos/{id}", Results<Ok<Todo>, NotFound> (int id, ITaskService service) =>
{
    Console.WriteLine("Todo by id...");
    var targetTodo = service.GetTodoById(id);
    return targetTodo is null
    ? TypedResults.NotFound()
    : TypedResults.Ok(targetTodo);
});

app.MapPost("/todos", (Todo task, ITaskService service) =>
{
    service.AddTodo(task);
    return TypedResults.Created("/todos/{id}", task);
})
// Endpoint filter are applied to specifc endpoints and can be chained of the specific endpoint method. There are usually used for input validation.
.AddEndpointFilter(async (context, next) =>
{
    var taskArgument = context.GetArgument<Todo>(0);
    var errors = new Dictionary<string, string[]>();

    if (taskArgument.DueDate < DateTime.UtcNow)
    {
        errors.Add(nameof(Todo.DueDate), ["Cannot have due date in the past."]);
    }
    if (taskArgument.IsComplete)
    {
        errors.Add(nameof(Todo.IsComplete), ["Cannot add completed todo."]);
    }

    if (errors.Count > 0)
    {
        return TypedResults.ValidationProblem(errors);
    }
    return await next(context);
});

app.MapDelete("/todos/{id}", (int id, ITaskService service) =>
{
    service.DeleteTodoById(id);
    return TypedResults.NoContent();
});

app.Run();


//Type declarations

public record Todo(int Id, string Name, DateTime DueDate, bool IsComplete);

interface ITaskService
{
    Todo? GetTodoById(int id);
    List<Todo> GetTodos();
    void DeleteTodoById(int id);
    Todo AddTodo(Todo task);
}

class InMemoryTaskService : ITaskService
{
    private readonly List<Todo> _todos = [];

    public Todo? GetTodoById(int id)
    {
        return _todos.SingleOrDefault(t => t.Id == id);
    }
    public List<Todo> GetTodos()
    {
        return _todos;
    }
    public void DeleteTodoById(int id)
    {
        _todos.RemoveAll(t => t.Id == id);
    }
    public Todo AddTodo(Todo task)
    {
        _todos.Add(task);
        return task;
    }
}
