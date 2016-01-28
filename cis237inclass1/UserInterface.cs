using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        //Private Variables - No need for local variables, so there are no private
        //variable declarations for this class.

        //Properties - Since there are no local variables, this is no need for
        //public properties, so I don't need that section either. 

        //Public methods - we will have some of these!


        //This will print the menu to the screen, and await a valid input
        //fron the user. Once the input is valid, it wil return the 
        // number that they selected.
        public int GetUserInput()
        {
            //Let's print the menu first
            this.printMenu();

            // Get user input from the terminal. Whatever they type will come back 
            // as a string once they push enter on the keyboard. 
            String input = Console.ReadLine();

            //While the input is not valid 
            while(input != "1" && input != "2")
            {
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                //Reprint menu for user
                this.printMenu();
                //Re-fetch the user input from the console
                input = Console.ReadLine();
            }

            // I know since we are out of the while loop that it must either be a 
            // 1 or a 2, so there is no need for me to use try/catch.
            return Int32.Parse(input);

        }

        /// <summary>
        /// Take in a string that we would like to output to the screen
        /// </summary>
        /// <param name="allOutput"></param>
        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
        }

        /// <summary>
        /// This is just a private method to print the menu. it wil probably
        /// happen quite a bit, so it makes sense that it is a method. 
        /// </summary>
        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }


        //Constructors - No need for any construtors either. We will 
        // just use the automatic default one that is provided to us.
        //We can't see it, but trust me, it's available. 
    }
}
