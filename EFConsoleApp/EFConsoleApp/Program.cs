using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Inventory Management.");
            bool running = true;

            while(running)
            {
                Console.WriteLine("Enter C to add a new Customer. Press L to list all customers. Press Q to quit.");
                var input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "c":
                        Console.WriteLine("Please Enter First Name: ");
                        var fn = Console.ReadLine();
                        Console.WriteLine("Please Enter Last Name: ");
                        var ln = Console.ReadLine();
                        Console.WriteLine("Please Enter Phone Number: ");
                        var pn = Console.ReadLine();
                        Console.WriteLine("Please Enter Email: ");
                        var em = Console.ReadLine();
                        AppMethods.CreateCustomer(fn, ln, pn, em);
                        Console.WriteLine("Done!");
                        break;
                    case "l":
                        AppMethods.GetCustomers();
                        break;
                    case "q":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command");
                        break;
                }
            }
        }
    }
}
