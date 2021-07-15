using Rocky.DB;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Services
{
    public class InvoiceHeader2Service : IInvoiceHeader2Service
    {
        private readonly IDataProvider _provider;

        public InvoiceHeader2Service(IDataProvider provider)
        {
            _provider = provider;
        }

        public int AddInvoiceHeader(InvoiceHeader2 invoiceHeader2)
        {
            var commandText = $"INSERT INTO invoice_header (invoice_no, created_at, customer_id, amount, is_paid) VALUES ('{invoiceHeader2.InvoiceNo}', '{invoiceHeader2.CreatedAt}', {invoiceHeader2.CustomerId}, {invoiceHeader2.Amount}, {(invoiceHeader2.IsPaid ? 1 : 0)})";

            var affectedRows = _provider.ExecuteCommand2(commandText);

            return affectedRows;
        }
    }
}
