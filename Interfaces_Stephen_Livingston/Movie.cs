using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Stephen_Livingston
{   /// <summary>
/// Implements constructor and assings parameters to esrb, genre, and title.
/// </summary>
    class Movie : IGenre
    {
        public string ESRB { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            ESRB = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// creates method/describe method and prints game is starting to the console.
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, Ssssshhhh.");
        }
            public string Describe()
            {
                return $"{Title} is a(n) {Genre} Movie Rated {ESRB}!";
        
            }         
           

        
        

           
       
        
    }
}
