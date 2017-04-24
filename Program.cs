using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Movie / Category Inventory";

            MovieCls[] ListOfMovies = new MovieCls[10];

            ListOfMovies[0] = new MovieCls("Jurassic Park" , "Action");
            ListOfMovies[1] = new MovieCls("Home Alone", "Family");
            ListOfMovies[2] = new MovieCls("Independence Day", "Action");
            ListOfMovies[3] = new MovieCls("SAW", "Horror");
            ListOfMovies[4] = new MovieCls("Speed", "Family");
            ListOfMovies[5] = new MovieCls("Tommy Boy", "Commedy");
            ListOfMovies[6] = new MovieCls("Don't Breathe", "Horror");
            ListOfMovies[7] = new MovieCls("Trolls", "Commedy");
            ListOfMovies[8] = new MovieCls("BFG", "Family");
            ListOfMovies[9] = new MovieCls("Superman", "Family");

            Console.WriteLine("Select a category: ");


            for (int i = 0; i < ListOfMovies.Length; i++)
            {
                //ListOfMovies[i] = new MovieCls();
                Console.WriteLine("Please enter a movie category: ");
                string CategoryInput = Console.ReadLine();

                foreach (MovieCls temp in ListOfMovies)
                {
                    if (CategoryInput.ToLower() == temp.Category.ToLower())
                    {
                        // will MATCH the MOVIE TO CATEGORY 
                        Console.WriteLine(temp.Movie1);
                    }
                }
            }

        }

    }
}

  