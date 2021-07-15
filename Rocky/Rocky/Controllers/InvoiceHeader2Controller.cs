using Microsoft.AspNetCore.Mvc;
using Rocky.Models;
using Rocky.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
{
    public class InvoiceHeader2Controller : Controller
    {
        private readonly IInvoiceHeader2Service _invoiceHeader2Service;

        public InvoiceHeader2Controller(IInvoiceHeader2Service invoiceHeader2Service)
        {
            _invoiceHeader2Service = invoiceHeader2Service;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET action per ottenere il form con i dati da compilare
        public IActionResult Create()
        {
            return View();
        }

        // POST action per scrivere effettivamente i dati nel nostro database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(InvoiceHeader2 invoiceHeader2)
        {
            _invoiceHeader2Service.AddInvoiceHeader(invoiceHeader2);
            return RedirectToAction("Index");
        }
    }
}
