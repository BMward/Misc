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
            Console.Title = "Inventory Management.";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Inventory Management.");
            bool running = true;
            Console.WriteLine("Enter H for commands. Press Q to quit.");

            while(running)
            {
                Console.WriteLine("Enter command :: ");
                var input = Console.ReadLine();
                switch (input.Substring(0,2).ToLower())
                {
                    case "li":
                        AppMethods.GetItems();
                        break;
                    case "fi":
                        var arg = int.Parse(input.Substring(3));
                        try
                        {
                            AppMethods.GetItem(arg);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("GET ITEM Error: " + ex.Message);
                            break;
                        }
                    case "ci":
                        try
                        {
                            AppMethods.CreateInventoryItem();
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(string.Format("Error. {0}", ex.Message));
                            break;
                        }
                    case "ui":
                        var uiarg = int.Parse(input.Substring(3));
                        try
                        {
                            AppMethods.UpdateInventoryItem(uiarg);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("UPDATE Error: ");
                            break;
                        }
                    case "di":
                        try
                        {
                            Console.WriteLine("Please enter item ID to DELETE: ");
                            var Id = int.Parse(Console.ReadLine());
                            AppMethods.DeleteInventoryItem(Id);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("DELETE ITEM Error: " + ex.Message);
                            break;
                        }
                    case "qq":
                        running = false;
                        break;
                    case "hh":
                        Console.WriteLine("LI : List all items.");
                        Console.WriteLine("FI {itemId}: Get all information on an Item.");
                        Console.WriteLine("CI : Create new item.");
                        Console.WriteLine("UI {itemId}: Update item.");
                        Console.WriteLine("DI : Delete item.");
                        Console.WriteLine("Q : Exit program.");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid command. Enter H for a list of commands.");
                        break;
                }
            }
        }
    }
}
