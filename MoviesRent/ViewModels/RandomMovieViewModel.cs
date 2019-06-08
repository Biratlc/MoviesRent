using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesRent.Models;

namespace MoviesRent.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}