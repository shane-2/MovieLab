using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab
{
    internal class Movie
    {
        //properties
        public string Title { get; set; }
        public string Genre { get; set; }  
        public int Year { get; set; }
        public int Minutes { get; set; }
        //constructor
        public Movie (string _title, string _genre, int year, int minutes)
        {
            Title = _title;
            Genre = _genre;
            Year = year;
            Minutes = minutes;
        }


        //methods
        public List<Movie> Sorted(string a, List<Movie> s)
        {
            if (a == "genre")
            {
                List<Movie> sortedG = s.OrderBy(x => x.Genre).ToList();
                return sortedG;

            }
            else if (a == "title")
            {
                List<Movie> sortedG = s.OrderBy(x => x.Title).ToList();
                return sortedG;
            }
            else if (a == "length")
            {
                List<Movie> sortedG = s.OrderBy(x => x.Minutes).ToList();
                return sortedG;
            }
            else if (a == "year")
            {
                List<Movie> sortedG = s.OrderBy(x => x.Year).ToList();
                return sortedG;
            }
            else
            {
                return s;
            }
        }


    }
}
