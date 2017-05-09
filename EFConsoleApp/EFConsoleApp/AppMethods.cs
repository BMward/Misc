using EFConsoleApp.DbContexts;
using EFConsoleApp.Models;
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
        static void PrintItemDescription(InventoryItem item, bool shortlist = false)
        {
            if(shortlist)
            {
                Console.WriteLine(string.Format("ID: {0} | Description: {1}", item.InventoryId, item.ItemDescription));
            }
            else
            {
                Console.WriteLine(string.Format("\n ID: {0} \n Description: {1} \n Stock: {2} \n Acq. Cost: {3} | List Price: {4} \n", item.InventoryId, item.ItemDescription, item.InStock, item.AcquisitionCost, item.ListPrice));
            }
        }

        public static void DeleteInventoryItem(int itemId)
        {
            using (var db = new InventoryItemDbContext())
            {
                var item = GetItem(itemId, false);
                //because the item returns from a different DB context, you must attach that context to this one.
                db.Items.Attach(item);
                db.Items.Remove(item);
                db.SaveChanges();
            }
        }

        public static void CreateInventoryItem()
        {
            Console.WriteLine("Description:");
            var desc = Console.ReadLine();
            Console.WriteLine("Amount in stock:");
            var inStock = int.Parse(Console.ReadLine());
            Console.WriteLine("List Price:");
            var list = double.Parse(Console.ReadLine());
            Console.WriteLine("Acquisition Cost: ");
            var cost = double.Parse(Console.ReadLine());
            using (var db = new InventoryItemDbContext())
            {
                var item = new InventoryItem()
                {
                    ItemDescription = desc,
                    InStock = inStock,
                    ListPrice = list,
                    AcquisitionCost = cost
                };
                db.Items.Add(item);
                db.SaveChanges();
            }
        }

        public static InventoryItem GetItem(int Id, bool print = true)
        {
            InventoryItem item;
            using (var db = new InventoryItemDbContext())
            {
                item = db.Items.Find(Id);
            }
            if(print)
                PrintItemDescription(item);
            return item;
        }

        public static void GetItems()
        {
            DbSet<InventoryItem> items;
            using (var db = new InventoryItemDbContext())
            {
                items = db.Items;
            }
            foreach(var item in items)
                PrintItemDescription(item, true);
        }

        public static void UpdateInventoryItem(int Id)
        {
            InventoryItem item;
            using (var db = new InventoryItemDbContext())
            {
                var items = db.Items;
                item = items.First(i => i.InventoryId == Id);
                try
                {
                    Console.WriteLine("CURRENT INFO: ");
                    PrintItemDescription(item);
                    Console.WriteLine("Description:");
                    item.ItemDescription = Console.ReadLine();
                    Console.WriteLine("Amount in stock:");
                    item.InStock = int.Parse(Console.ReadLine());
                    Console.WriteLine("List Price:");
                    item.ListPrice = double.Parse(Console.ReadLine());
                    Console.WriteLine("Acquisition Cost: ");
                    item.AcquisitionCost = double.Parse(Console.ReadLine());
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    throw;
                }
            }
        }
    }
}
