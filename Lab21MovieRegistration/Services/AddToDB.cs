using Lab21MovieRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21MovieRegistration.Context;


namespace Lab21MovieRegistration.Services
{
    public class AddToDB : IAddable
    {
        public void Store(MovieModel movieModel, MovieDBContext _context)
        {
            var newMovie = new Movies();
            newMovie.Title = movieModel.Title;
            newMovie.Genre = movieModel.Genre.ToString();
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
        }
    }
}
