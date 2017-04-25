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
    //static = one copy per Class
    //static is ONE CUP...Funtionality not storing things
    //instance = one copy per Object
    //
    
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
 

public static int GetValidInteger()
{
    int input;
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Please enter a valid input.");
    }
    return input;
}
//Validates that integer is within a given range
public static int GetNumberInRange(int min, int max)
{
    int input = GetValidInteger();
    while (input < min || input > max)
    {
        Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
        input = GetValidInteger();
    }
    return input;
}
public static double GetValidDouble()
{
    double input;
    while (!double.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("Please enter a valid double input.");
    }
    return input;
}
//Validates that integer is within a given range
public static double GetInRangeDouble(double min, double max)
{
    double input = GetValidDouble();
    while (input < min || input > max)
    {
        Console.WriteLine("Please enter a double between {0} and {1}.", min, max);
        input = GetValidDouble();
    }
    return input;
}
        public static bool GetContinue()
        {
            //Continue Loop
            string Continue;
            while (true)
            {
            
                Console.WriteLine("Would You Like to Continue?  (y/n)");
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


