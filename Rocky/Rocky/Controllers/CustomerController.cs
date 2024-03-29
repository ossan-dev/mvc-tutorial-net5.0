﻿using Microsoft.AspNetCore.Mvc;
using Rocky.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var customers = _customerService.GetCustomers();
            return View(customers);
        }

        [HttpPost]
        public JsonResult Autocomplete(string expr)
        {
            var customers = _customerService.GetCustomersBySubstring(expr);

            var raw = customers.Select(x => new { val = x.CustomerId, label = x.CustomerName }).ToList();
            return Json(raw);
        }
    }
}
