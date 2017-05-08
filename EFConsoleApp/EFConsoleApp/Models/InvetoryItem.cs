using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Models
{
    /// <summary>
    /// Inventory Item model. Acquisition cost is the purchase price to the business OR material and labor cost to produce item.
    /// SalePrice represents the list price of the item.
    /// </summary>
    public class InvetoryItem
    {
        public int InvetoryId { get; set; }
        public string ItemDescription { get; set; }
        public double AcquisitionCost { get; set; } 
        public double ListPrice { get; set; }
        public int InStock { get; set; }

    }
}
