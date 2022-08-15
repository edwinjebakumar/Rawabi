using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIRawabi.Models
{
    public class Transaction
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string TranType { get; set; }
        public DateTime TranDt { get; set; }
    }
}