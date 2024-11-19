using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Bill
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string BillNumber { get; set; } 
        public DateTime Date { get; set; }
        public decimal AmountDue { get; set; }
        public string Vendor { get; set; }
    }
}
