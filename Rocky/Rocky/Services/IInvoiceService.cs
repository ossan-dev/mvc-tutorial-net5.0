using Rocky.Models;

namespace Rocky.Services
{
    public interface IInvoiceService
    {
        int AddInvoiceHeader(InvoiceHeader invoiceHeader);
    }
}