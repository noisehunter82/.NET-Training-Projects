// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using SQLDbToEFcModel.Data;
using SQLDbToEFcModel.Models;
//Console.WriteLine("Test");
var context = new MyPracticeDbContext();
var dbName = context.Database.GetDbConnection().Database;
var dbAvailable = context.Database.CanConnect();

Console.WriteLine($"{dbName} is{(dbAvailable ? " " : " not ")}available.");
Console.WriteLine(new string('-', 20));

if (dbAvailable)
{
    var matchingProducts = context.Products
              .Where(p => p.Price > 4m)
              .OrderBy(p => p.Name);

    foreach (Product p in matchingProducts)
    {
        Console.WriteLine($"Id: {p.Id}");
        Console.WriteLine($"Name: {p.Name}");
        Console.WriteLine($"Price: {p.Price}");
        Console.WriteLine(new string('-', 20));
    }
}