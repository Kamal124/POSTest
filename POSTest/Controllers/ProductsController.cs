using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using POSTest.Data;
using POSTest.Models;
using System.Linq;
using System.Threading.Tasks;

namespace POSTest.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Products> objtList = _db.Products;
            return View(objtList);
        }
    }
}
