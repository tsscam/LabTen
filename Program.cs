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
            bool run = true;

            Console.Title = "Movie / Category Inventory";
            Console.WriteLine("Search for MOVIE");

            MovieCls[] ListOfMovies = new MovieCls[10];

            ListOfMovies[0] = new MovieCls("Jurassic Park", "Action");
            ListOfMovies[1] = new MovieCls("Home Alone", "Family");
            ListOfMovies[2] = new MovieCls("Independence Day", "Action");
            ListOfMovies[3] = new MovieCls("SAW", "Horror");
            ListOfMovies[4] = new MovieCls("Speed", "Family");
            ListOfMovies[5] = new MovieCls("Tommy Boy", "Commedy");
            ListOfMovies[6] = new MovieCls("Don't Breathe", "Horror");
            ListOfMovies[7] = new MovieCls("Trolls", "Commedy");
            ListOfMovies[8] = new MovieCls("BFG", "Family");
            ListOfMovies[9] = new MovieCls("Superman", "Family");

            do
            {
                
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
                Console.WriteLine("");
                

                Console.WriteLine("Please enter any of these movie category: ");
                
                Console.WriteLine("Family, Horror, Commedy or Action: ");
                Console.WriteLine("==================================");
                              

                string CategoryInput = Console.ReadLine();
                Console.WriteLine("");
                foreach (MovieCls temp in ListOfMovies)
                {
                    if (CategoryInput.ToLower() == temp.Category.ToLower())
                    {
                        // will MATCH the MOVIE TO CATEGORY 
                        Console.WriteLine("These Movies are Available: --->\t" + temp.Movie1);
                    }
                }
                run = ValidationCls.GetContinue();

            } while (run == true);
        }
    }
}
      
              

      
  
                    

                    
           
              
        

                        
            
            
    


 