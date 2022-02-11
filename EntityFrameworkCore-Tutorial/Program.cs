using EntityFrameworkCore_Tutorial.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore_Tutorial {
    class Program {
        static void Main(string[] args) {

            AppDbContext context = new AppDbContext();

            var items = context.Items.ToList();

            foreach(var i in items)    {
                i.Price = i.Price * (1 + 0.1m);
            }
            context.SaveChanges();

             items = context.Items.ToList();

            foreach (var item in items) {
                Console.WriteLine($"{item.Id,-5} {item.Code,-10} {item.Name,-15} {item.Price,10:c}");
            }


            

            ////Add a new order for Kroger
            //var kroger = context.Customers.SingleOrDefault(c => c.Name.StartsWith("Krog"));
            //var order = new Order() {
            //    Id = 0, Description = "3rd Order", Total = 2500, CustomerId = kroger.Id
            //};

            //context.Orders.Add(order);
            //context.SaveChanges();

            //var orders = context.Orders.Include(x => x.Customer).ToList();

            //foreach(var o in orders) {
            //    Console.WriteLine($"{order.Id, -5}{o.Description, -10}{o.Total,10:c}       {o.Customer.Name}");
            //}

            //add order


            //delete a customer
            //var amazon = context.Customers.SingleOrDefault(c => c.Name == "Amazon");

            //if(amazon != null) {
            //    context.Customers.Remove(amazon);
            //    context.SaveChanges();
            //}

            
            //Update customer
            //var max = context.Customers.Find(1);

            //max.Sales += 5000;

            //context.SaveChanges();
            
            //add a new customer 
            //var newCustomer = new Customer() {
            //    Id = 0, Name = "Kroger", Active = true, Sales = 3000000, Updated = new DateTime(2022, 2, 11)
            //};
            //context.Customers.Add(newCustomer);
            //context.SaveChanges();

            // read by primary key 
            //var customer = context.Customers.Find(2);
            //Console.WriteLine($"{customer.Name} {customer.Sales:c}");

            // read all customers
            //var customers = from cust in context.Customers
            //                //where cust.Sales < 100000
            //                select cust;


            ////List<Customer> customers = context.Customers
            ////                                    .Where(cust => cust.Sales < 100000)
            ////                                    .ToList();

            //foreach (var customer in customers) {
            //    Console.WriteLine($"{customer.Name, -20} {customer.Sales,10:c}");
            //}
        }
    }
}
