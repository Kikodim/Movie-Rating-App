using System.Collections.Generic;
using movie_ratings_app.models;

namespace movie_ratings_app.viewModel

{
    public class movies
    {
        public static IEnumerable<Movie> Get()
        {
            return new List<Movie> //Here I declare the movies with their data
            {
                new Movie() {Title="Avengers: Endgame",Year="2019", Description="The grave course of events set in motion by " +
                "Thanos that wiped out half the universe and fractured the Avengers ranks compels the remaining Avengers to take one final stand in Marvel Studios' grand conclusion to twenty-two films "},
                 new Movie() {Title="Inception",Year="2010", Description="Inception is a 2010 science fiction action film written and directed by Christopher Nolan, who also produced the film with Emma Thomas," +
                 " his wife. The film stars Leonardo DiCaprio as a professional thief " +
                 "who steals information by infiltrating the subconscious of his targets." },
                 new Movie() {Title="Fury",Year="2014",Description="A grizzled tank commander makes tough decisions as he and his crew fight their way across Germany in April, 1945."},
                 new Movie() {Title="Wonder Woman",Year="2017",Description="Princess Diana of an all-female Amazonian race rescues US pilot Steve. Upon learning of a war, she ventures into the world of men to stop Ares, the god of war, from destroying mankind."},
                 new Movie() {Title="Catch Me If You Can",Year="2002",Description="Notorious con artist Frank Abagnale has duped people worth millions of dollars with his masterful art of deception. With his scams getting bolder, he is soon pursued by FBI agent Carl Hanratty."},
                 new Movie() {Title="Mission Impossible: Fallout",Year="2018",Description="A group of terrorists plans to detonate three plutonium cores for a simultaneous nuclear attack on different cities. Ethan Hunt, along with his IMF team, sets out to stop the carnage."}
            };
        }
    }
}
