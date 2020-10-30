using Lab21MovieRegistration.Context;
using Lab21MovieRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21MovieRegistration.Services
{
    public interface IAddable
    {
        public void Store(MovieModel m, MovieDBContext context);
    }
}
