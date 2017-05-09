using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsoleApp.Models
{
    /// <summary>
    /// Inventory Item model. Acquisition cost is the purchase price to the business OR material and labor cost to produce item.
    /// SalePrice represents the list price of the item.
    /// </summary>
    public class InventoryItem
    {
        //If the property is named something other than Id, you need to add the [Key] attribute to it.
        [Key]
        public int InventoryId { get; set; }
        public string ItemDescription { get; set; }
        public double AcquisitionCost { get; set; } 
        public double ListPrice { get; set; }
        public int InStock { get; set; }

    }
}
