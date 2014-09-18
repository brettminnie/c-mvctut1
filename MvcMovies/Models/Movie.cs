using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovies.Models
{
    public class Movie
    {
        protected int Id { get; set; }

        protected string Title { get; set; }

        protected DateTime ReleaseDate { get; set; }

        protected string Genre { get; set; }

        protected decimal Price { get; set; }
    }
}