using Microsoft.AspNetCore.Mvc;
using Rocky.Models;
using Rocky.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET for create action
        public IActionResult Create()
        {
            return View();
        }
        
        // POST for create action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(InvoiceHeader invoiceHeader)
        {
            _invoiceService.AddInvoiceHeader(invoiceHeader);
            return RedirectToAction("Index");
        }
    }
}
