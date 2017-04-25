using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class ValidationCls
    { 
        public static string GetValidInput()
        { 
          while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "Family")
                    return input;
                else if (input == "Commedy")
                    return input;
                else if (input == "Horror")
                    return input;
                else if (input == "Action")
                    return input;
            }
    }
 


        public static bool GetContinue()
        {
            //Continue Loop
            string Continue;
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Do You Want to Search for Another Movie?  (y/n)");
                Continue = Console.ReadLine().ToUpper();
                Console.WriteLine("");
                if (Continue == "Y")
                    return true;

                if (Continue == "N")
                    return false;

                else
                 
                Console.WriteLine("Please Enter Y or N");
               }
        }
    }
    }
class Validation
{

    // Method to Get Valid String
    public static string GetValidInput()
    {
        string Input = Console.ReadLine().ToUpper();

        // Validate Input
        while ((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input) || (Input.Length == 0)))
        {
       
            Console.Write("You Enter Action, Comedy, Family or Horror here  --->:   ");
            Input = Console.ReadLine().ToUpper(); ;

        }
        return Input;
    }
}

