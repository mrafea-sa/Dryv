﻿using Dryv.Demo.Models;
using Dryv.Demo.Nav;
using Microsoft.AspNetCore.Mvc;

namespace Dryv.Demo.Controllers
{
    public class HomeController : Controller
    {
        [Nav(Menu.Introduction)]
        public IActionResult Index()
        {
            return this.View(new Customer());
        }

        [HttpPost]
        public IActionResult Index(Customer customer)
        {
            return this.View(customer);
        }
    }
}