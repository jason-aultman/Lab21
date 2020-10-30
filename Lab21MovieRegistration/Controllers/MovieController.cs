using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Lab21MovieRegistration.Context;
using Lab21MovieRegistration.Models;
using Lab21MovieRegistration.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab21MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDBContext _context;
        private readonly IAddable _addToDB;
        
        public MovieController(MovieDBContext moveDBContext, IAddable addable):base()
        {
            _context = moveDBContext;
            _addToDB = addable;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(MovieModel movieModel)
        {
            _addToDB.Store(movieModel, _context);
            var result = new ResultModel() { Title = movieModel.Title };
            return View("Result", result);
        }
    }
}