using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class InvoiceHeader
    {
        public int Id { get; set; }
        [DisplayName("Invoice No")]
        public string InvoiceNo { get; set; }
        [DisplayName("Created At")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("Customer ID")]
        public int CustomerId { get; set; }
        
        public decimal Amount { get; set; }
        [DisplayName("Is it paid?")]
        public bool IsPaid { get; set; }
    }
}
