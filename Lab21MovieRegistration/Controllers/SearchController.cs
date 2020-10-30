using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21MovieRegistration.Context;
using Lab21MovieRegistration.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab21MovieRegistration.Controllers
{
    public class SearchController : Controller
    {
        private readonly MovieDBContext _movieDBContext;

        public SearchController(MovieDBContext movieDBContext)
        {
            _movieDBContext = movieDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchResultTitle(SearchModel searchModel)
        {
            var result = (from m in _movieDBContext.Movies
                          where m.Title.Contains(searchModel.Title)
                         select m).ToList();
            var model = new SearchResultTitle();
            model.MovieResults = result;
            return View(model);
        }
        public IActionResult SearchResultGenre(SearchModel searchModel)
        {
            var result = (from m in _movieDBContext.Movies
                          where m.Genre==searchModel.genres.ToString()
                          select m).ToList();
            var model = new SearchResultGenre();
            model.MovieResults = result;
            return View(model);
        }
    }
}