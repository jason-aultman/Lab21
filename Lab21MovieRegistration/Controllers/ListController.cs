using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Lab21MovieRegistration.Areas.Identity.Data;
using Lab21MovieRegistration.Context;
using Lab21MovieRegistration.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Lab21MovieRegistration.Controllers
{
    public class ListController : Controller
    {
        private readonly MovieDBContext _context;
        


        public ListController(MovieDBContext context)
        {
            _context = context;
            
          
        }
        public IActionResult Index()
        {
            var allMovies = from m in _context.Movies
                            select m;
            return View(allMovies);
        }
        public IActionResult CheckOut(int id)
        {
            var user = new UserModel();
            
           
            
                var movieToCheckout = (from m in _context.Movies
                                       where (m.Id == id)
                                       select m).FirstOrDefault();
                return View(movieToCheckout);
            
           
           
        }
        public IActionResult ReturnToList()
        {
            return View("Index");
        }
    }
}