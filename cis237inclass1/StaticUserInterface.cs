using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    public static class StaticUserInterface
    {
        // We made the method static and it is inside a static class
        // this means that this method can be called using the class name
        // instead of an instance. We can see how to cal this method over
        // in the program class. It still does the same work as the 
        // instanced version, only it cannot use the 'this' keyword bc
        // this refers to an instance. 
        public static int GetUserInput()
        {
            //Let's print the menu first
            printMenu();

            
            String input = Console.ReadLine();

            //While the input is not valid 
            while (input != "1" && input != "2")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                //Reprint menu for user
                printMenu();
                //Re-fetch the user input from the console
                input = Console.ReadLine();
            }

            // I know since we are out of the while loop that it must either be a 
            // 1 or a 2, so there is no need for me to use try/catch.
            return Int32.Parse(input);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allOutput"></param>
        public static void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        /// <summary>
        ///
        /// </summary>
        private static void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }
    }
}
