using EFConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.DbContexts
{
    public class TransactionDbContext : InventoryItemDbContext
    {
        public DbSet<Transaction> Transactions { get; set; }
    }
}
