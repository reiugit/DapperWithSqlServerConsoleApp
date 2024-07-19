using Dapper;
using DapperWithSqlServerConsoleApp.Domain;
using DapperWithSqlServerConsoleApp.Data;

using var connection = Connection.Open();

var product = new Product { Name = "Product X", Price = 10.0m };

await connection.ExecuteAsync("""
    INSERT INTO Products (Name, Price) 
    VALUES (@Name, @Price)
    """, product);

var products = await connection
    .QueryAsync<Product>("SELECT * FROM Products");

products.ToList().ForEach(PrintProduct);

KeyHandler.WaitForAnyKey();

static void PrintProduct(Product p)
    => WriteLine($"Id: {p.Id}, Name: '{p.Name}', Price: {p.Price}");
