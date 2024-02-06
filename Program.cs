// See https://aka.ms/new-console-template for more information
using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;


using ContosoPizzaContext context = new ContosoPizzaContext();

//Console.WriteLine("Hello, World!");
//var dbContext = new ContosoPizzaContext();

//var c1 = new Customer() { FirstName = "Claire",LastName="Hook",Address="American Street",Phone="38748374",Email= "claire.hook@outlook.com" };
//context.Customers.Add(c1);
//List<Customer> cust=dbContext.Customers.ToList();
//dbContext.Remove(cust[0]);
//Console.WriteLine("removed");
//foreach (var c in cust) { 
//Console.WriteLine(c.FirstName);
//}

//await context.SaveChangesAsync();

//var customers = dbContext.Customers;
//customers.ToList<Customer>(c1);



Product veggieSpecial = new Product() { Name = "Veggie Special Pizza" , Price = 9.99M};
context.Products.Add(veggieSpecial);

Product deluxMeat = new Product() { Name = "Delux Meat Pizza", Price = 12.99M };
context.Products.Add(deluxMeat);

context.SaveChanges();

//var veggieSpecial = context.Products
//            .Where(p => p.Name == "Veggie Special Pizza")
//            .FirstOrDefault();

//if (veggieSpecial is Product) {

//    veggieSpecial.Price = 10.99M;
//}
//context.SaveChanges();

//List<Product> productList = context.Products.Where(p => p.Price > 10.00M)
//                                            .OrderBy(p => p.Name).ToList();

//foreach (var product in productList)
//{

//    Console.WriteLine($"Id:{product.Id},Name:{product.Name},Price:{product.Price}");
//}

//Scaffold - DbContext 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Chinook' Microsoft.EntityFrameworkCore.SqlServer
   // Scaffold-DbContext 'Host=localhost;Port=5432;Database=myDataBase;Username=postgres;Password=postgres' Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models -Context ContosoPizzaContext;
