using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class InvoiceHeader2
    {
        public int Id { get; set; }
        [DisplayName("Numero fattura")]
        public string InvoiceNo { get; set; }
        [DisplayName("Data creazione")]
        public DateTime CreatedAt { get; set; }
        [DisplayName("ID cliente")]
        public int CustomerId { get; set; }
        [DisplayName("Importo")]
        public decimal Amount { get; set; }
        [DisplayName("Già pagata?")]
        public bool IsPaid { get; set; }
    }
}
