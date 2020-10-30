using System;
using System.Collections.Generic;

namespace Lab21MovieRegistration.Models
{
    public partial class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal? Runtime { get; set; }
    }
}
