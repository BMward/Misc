using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Models
{
    /// <summary>
    /// The Transaction model hinge. Links the TransactionID to the Customer and the Item purchased. 
    /// </summary>
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
    }
}
