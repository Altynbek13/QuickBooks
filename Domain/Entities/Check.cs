using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Check
    {
        public int Id { get; set; }
        public string RequestId { get; set; } 
        public string CheckNumber { get; set; } 
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Payee { get; set; } 
    }
}
