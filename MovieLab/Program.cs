using CircleLab;
using Microsoft.VisualBasic;
using MovieLab;
using System.Collections.Generic;

Movie newMovie1 = new Movie("Avatar", "Scifi", 2012, 140);
Movie newMovie2 = new Movie("Day of the Dead", "Horror", 2000, 109);
Movie newMovie3 = new Movie("The Empire Strikes Back", "Scifi", 1982, 110);
Movie newMovie4 = new Movie("The Notebook", "Drama", 2009, 113);
Movie newMovie5 = new Movie("The Titanic", "Drama", 1998, 126);
Movie newMovie6 = new Movie("Beauty and the Beast", "Animated", 1993, 85);
Movie newMovie7 = new Movie("The Avengers", "Scifi", 2008, 120);
Movie newMovie8 = new Movie("Startrek", "Scifi", 2014, 100);
Movie newMovie9 = new Movie("Bird Box", "Horror", 2020, 112);
Movie newMovie10 = new Movie("Jaws", "Horror", 1987, 90);

List<Movie> AllMovies = new List<Movie>()
{
    newMovie1,
    newMovie2,
    newMovie3,
    newMovie4,
    newMovie5,
    newMovie6,
    newMovie7,
    newMovie8,
    newMovie9,
    newMovie10
};
Console.WriteLine("Hello, Welcome to Hulus very limited selection of movies! ");
//Console.WriteLine("How would you like the list sorted? Genre/Length/Year/Title");
//string sort = Console.ReadLine().ToLower().Trim();

//List <Movie> sortChoice = Movie.Sorted(sort, AllMovies);
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("");
//foreach (Movie s in sortChoice)
//{
//    DisplayMovieDetails(s);
//    Console.WriteLine();
//}





//loop starts here
while (Validator.GetContinue("Would you Like to pick a Genre?"))
{
    bool movieGenre = true;
    while (movieGenre) 
    { 

    Console.WriteLine("Please enter the genre you are interested in. Scifi/Drama/Horror/Animated");

    string genre = Console.ReadLine().ToLower().Trim();
    List<Movie> UserGenre = AllMovies.FindAll(x => x.Genre.ToLower() == genre);
    movieGenre = UserGenre.Any(x => x.Genre.ToLower() == genre);
    if(movieGenre == false)
        {
            Console.WriteLine("We do not carry that genre");
        }

        List<Movie> sortedList = UserGenre.OrderBy(x => x.Title).ToList();

        foreach (Movie u in sortedList)
        {
            DisplayMovieDetails(u);
            Console.WriteLine();
            
        }
        movieGenre = false;
    }
    
    
}
Console.WriteLine("Goodbye!") ;

//loop ends





//methods---------------------------------
static void DisplayMovieDetails(Movie m)
{
    Console.WriteLine($"{m.Title}, Genre: {m.Genre}, Year: {m.Year}, {m.Minutes} Minutes long.");
}

//static List <string> Sorted(string a, List <string> s )
//{
//    if(a == "genre" )
//    {
//         List < string > sortedGenre = s.OrderBy(x => x.Genre).ToList();
//        return sortedGenre;

//    }
//    else if (a == "title" )
//    {
//        List < string > sortedGenre = s.OrderBy(x => x.Title).ToList();
//        return sortedGenre;
//    }
//    else if (a == "length" )
//    {
//        List < string > sortedGenre = s.OrderBy(x => x.Minutes).ToList();
//        return sortedGenre;
//    }
//    else
//    {
//        List<string> sortedGenre = s.OrderBy(x => x.Year).ToList();
//        return sortedGenre;
//    }
//}