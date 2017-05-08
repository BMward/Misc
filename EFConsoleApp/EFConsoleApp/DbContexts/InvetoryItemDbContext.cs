using EFConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.DbContexts
{
    public class InvetoryItemDbContext : DbContext
    {
        public InvetoryItemDbContext() : base("InventoryContext")
        {

        }

        public DbSet<InvetoryItem> InventoryItems { get; set; } 
    }
}
