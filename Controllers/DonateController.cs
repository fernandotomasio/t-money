using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TMoney.Models;

namespace TMoney.Controllers
{
    public class DonateController : Controller
    {
        private readonly ILogger<DonateController> _logger;

        public DonateController(ILogger<DonateController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
