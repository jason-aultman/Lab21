using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21MovieRegistration.Context;
using Microsoft.AspNetCore.Mvc;

namespace Lab21MovieRegistration.Controllers
{
    public class CheckOutController : Controller
    {
        public readonly MovieDBContext _context;

        public CheckOutController(MovieDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckOut()
        {


            return View();
        }
       
    }
}