                                     // Task.3

List<Customer> customers = new List<Customer>
{
    new Customer
    {
        Name = "Alice",
        Email = "alice@example.com",
        Age = 25,
        PurchaseHistory = new List<Purchase>
        {
            new Purchase { Date = new DateTime(2022, 1, 1), Amount = 100.00M },
            new Purchase { Date = new DateTime(2022, 2, 1), Amount = 50.00M },
            new Purchase { Date = new DateTime(2022, 3, 1), Amount = 75.00M }
        }
    },
    new Customer
    {
        Name = "Bob",
        Email = "bob@example.com",
        Age = 35,
        PurchaseHistory = new List<Purchase>
        {
            new Purchase { Date = new DateTime(2022, 1, 1), Amount = 150.00M },
            new Purchase { Date = new DateTime(2022, 2, 1), Amount = 75.00M },
            new Purchase { Date = new DateTime(2022, 3, 1), Amount = 125.00M }
        }
    },
    new Customer
    {
        Name = "Charlie",
        Email = "charlie@example.com",
        Age = 30,
        PurchaseHistory = new List<Purchase>
        {
            new Purchase { Date = new DateTime(2022, 1, 1), Amount = 75.00M },
            new Purchase { Date = new DateTime(2022, 2, 1), Amount = 125.00M },
            new Purchase { Date = new DateTime(2022, 3, 1), Amount = 150.00M }
        }
    },
    
    new Customer
    {
    Name = "Chori",
    Email = "chori@example.com",
    Age = 16,
    PurchaseHistory = new List<Purchase>
    {
        new Purchase { Date = new DateTime(2022, 1, 1), Amount = 100.00M },
        new Purchase { Date = new DateTime(2022, 2, 1), Amount = 125.00M },
        new Purchase { Date = new DateTime(2022, 3, 1), Amount = 200.00M }
    }
    },
    
    new Customer
    {
    Name = "Nasim",
    Email = "nasim@example.com",
    Age = 36,
    PurchaseHistory = new List<Purchase>
    {
        new Purchase { Date = new DateTime(2022, 1, 1), Amount = 100.00M },
        new Purchase { Date = new DateTime(2022, 2, 1), Amount = 125.00M },
        new Purchase { Date = new DateTime(2022, 3, 1), Amount = 150.00M }
    }
},
    new Customer
    {
        Name = "Bakhtovar",
        Email = "bakhtovarrizozoda@gmail.com",
        Age = 21,
        PurchaseHistory = new List<Purchase>
        {
            new Purchase { Date = new DateTime(2022, 1, 1), Amount = 90.00M },
            new Purchase { Date = new DateTime(2022, 2, 1), Amount = 150.00M },
            new Purchase { Date = new DateTime(2022, 3, 1), Amount = 180.00M }
        }
    }
};
  
DateTime oneYearAgo = DateTime.Now.Date.AddYears(-1);

var Customers = customers
    .Select(c => new
    {
        c.Name,
        c.Email,
        c.Age,
        PurchaseAmount = c.PurchaseHistory
            .Where(p => p.Date >= oneYearAgo)
            .Sum(p => p.Amount)
    })
    .OrderByDescending(c => c.PurchaseAmount)
    .Take(5)
    .ToList();

foreach (var customer in Customers)
{
    Console.WriteLine($"Name: {customer.Name}");
    Console.WriteLine($"Email: {customer.Email}");
    Console.WriteLine($"Age: {customer.Age}");
    Console.WriteLine($"Purchase Amount: {customer.PurchaseAmount}");
    Console.WriteLine();
}
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public List<Purchase> PurchaseHistory { get; set; }
}                                    
public class Purchase
{
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
}