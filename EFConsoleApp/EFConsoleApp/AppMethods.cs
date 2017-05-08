using EFConsoleApp.DbContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp
{
    public class AppMethods
    {
        public static void CreateCustomer(Customer customer)
        {
            using (var db = new CustomerDbContext())
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void CreateCustomer(string firstName, string lastName, string phone, string email)
        {
            using (var db = new CustomerDbContext())
            {
                var customer = new Customer()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phone,
                    Email = email
                };

                db.Customers.Add(customer);
                db.SaveChanges();
            }
        }

        public static void GetCustomers()
        {
            List<Customer> result;
            using (var db = new CustomerDbContext())
            {
                result = db.Customers.ToList();
            }

            foreach(var item in result)
            {
                Console.WriteLine(string.Format("Name: {0} {1}, Id: {2}, Phone: {3}, Email: {4}", item.FirstName, item.LastName, item.CustomerId, item.PhoneNumber, item.Email));
            }
        }
    }
}
