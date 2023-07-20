// See https://aka.ms/new-console-template for more information
using CCSARestaurant.Core;
using CCSARestaurant.DB;

Console.WriteLine("Hello, World!");

// Establish Database Connection
var sessionFactory = new SessionFactory();
var session = sessionFactory.Session;


//Perform CRUD Operations

//Create
var customer = new Customer { FirstName = "Murphy", Surname = "Ochuba" };
var customer2 = new Customer { FirstName = "Chuks", Surname = "Isichei" };
session.Save(customer);
session.Save(customer2);
sessionFactory.Commit(session);


//Read
var customers = session.Query<Customer>().ToList();
foreach(Customer cus in customers)
{
    Console.WriteLine($"Customer: {cus.FirstName} {cus.Surname}");
}


//Update

customer2.FirstName = "Chukwuka";
sessionFactory.Commit(session);

Customer updatedCustomer2 = session.Get<Customer>(customer2.Id);
Console.WriteLine($"Customer: {updatedCustomer2.FirstName} {updatedCustomer2.Surname}");


//Delete
session.Delete(customer2);
sessionFactory.Commit(session);

customers = session.Query<Customer>().ToList();
foreach (var cust in customers)
{
    Console.WriteLine($"Remaining Customer: {cust.FirstName} {cust.Surname}");
}




Console.WriteLine("Done!");

