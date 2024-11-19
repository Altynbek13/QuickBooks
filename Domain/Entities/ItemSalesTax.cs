using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ItemSalesTax
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string TaxName { get; set; } 
        public decimal Rate { get; set; }
    }
}
