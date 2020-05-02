using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using t_money.Models;
using t_money.Repositories;

namespace t_money.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryRepository _repository;
        public CategoryController(ILogger<CategoryController> logger, ICategoryRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.FindAll());
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
