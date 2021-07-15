using Rocky.DB;
using Rocky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IDataProvider _provider;

        public InvoiceService(IDataProvider provider)
        {
            _provider = provider;
        }

        public int AddInvoiceHeader(InvoiceHeader invoiceHeader)
        {
            var commandText = $"INSERT INTO invoice_header (invoice_no, created_at, customer_no, amount, is_paid) VALUES ('{invoiceHeader.InvoiceNo}', '{invoiceHeader.CreatedAt}', '{invoiceHeader.CustomerNo}', {invoiceHeader.Amount.ToString().Replace(",", ".")}, {(invoiceHeader.IsPaid ? 1 : 0)})";

            var affectedRows = _provider.ExecuteCommand(commandText);

            return affectedRows;
        }
    }
}
