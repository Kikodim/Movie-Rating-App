using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace movie_ratings_app.models
{
    public class Movie
    {
        public string Title { get; set;}
        public string Year { get; set; }
        public string Description { get; set; }
        //String concatenation
        public string MovName => Title + " " + "(" + Year + ")";

    }
}
