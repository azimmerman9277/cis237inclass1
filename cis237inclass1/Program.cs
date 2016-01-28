using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Alysia", "Zimmerman", 435.00m);
            Employee employee2 = new Employee("Jesse", "Smith", 120.00m);

            int myNumber = 5;

            //Write the Value of the int before the method, call the method, print after call/
            Console.WriteLine(myNumber);
            changeAnInt(myNumber);
            Console.WriteLine(myNumber);

            Console.WriteLine(employee1);
            changeAnObject(employee1);
            Console.WriteLine(employee1.ToString());


          //  Console.WriteLine(employee.GetFullName());
          //  Console.WriteLine(employee.ToString());
           

            //Showing how to use an array with objects
            Employee[] employees = new Employee[10];

            //Instanciates some employees into array
            //employees[0] = new Employee("James", "Bailey", 543.00m);
            //employees[1] = new Employee("Justin", "Aaron", 344.00m);
            //employees[2] = new Employee("Ashley", "Nick", 546.00m);
            //employees[3] = new Employee("Meagan", "Combe", 364.00m);
            //employees[4] = new Employee("Rene", "Base", 583.00m);
            //employees[5] = new Employee("Tyler", "Anderson", 344.00m);
            //employees[6] = new Employee("Bret", "Band", 573.00m);
            //employees[7] = new Employee("Kyle", "Andrew", 224.00m);
            //employees[8] = new Employee("Kelsey", "Drew", 563.00m);
          //  employees[9] = new Employee("Morgan", "Amber", 347.00m);


            //Lets use the new CSVProcessor we made
            CSVProcessor csvProcessor = new CSVProcessor();

            //Call the importCSV method passing the path and the employees array
            // over so they can be used
            csvProcessor.ImportCSV("../data/employees.csv", employees);



            
            //For each loop that will loop through each element of the employees array
            foreach (Employee employee in employees)
            {
                // Check to make sure that the current object is not null.
                if (employee != null)
                {
                    Console.WriteLine(employee.ToString());
                }
            }

            //We are creating a new UserInterface class and it's okay 
            // that the UserInterface calss does not have a defined 
            // constructor. It will have a default one provide to us that
            // we can take advantage of by just not passing in any parameters
            UserInterface ui = new UserInterface();



            // Call the GetUserInput method of the UI class. It will return 
            // a valid integer that represents the choice they want to do. 
            int choice = ui.GetUserInput();

            // To use a static class to execute methods we simply call the method
            // on the class name, or type, Since it is not possible to use the 'new'
            // keyword and make an instance, the only way we can access the class
            // is through the class name, that is what we do. Here we are calling
            // the GetUserInterface method on the calss name to get it to run.
            //choice = StaticUserInterface.GetUserInput();

            // While the choice is not the exit choice (which in this case is 2)
            while (choice != 2)
            {
                // If the choice is 1, which in this case has to be true
                if (choice == 1)
                {
                    //Create an empty string
                    string allOutput = "";
                    // For each Employee in the employees array.
                    foreach (Employee employee in employees)
                    {
                        //So long as the spot in the array is not null
                        if (employee != null)
                        {
                            //Concatenate the employee changed to a string plus a new line
                            allOutput += employee.ToString() + Environment.NewLine;
                        }
                    }
                    ui.PrintAllOutput(allOutput);
                }

                //Now that "work" that we wanted to do is done,
                // we need to re-prompt the user for input
                choice = ui.GetUserInput();
            }

        }

        static void changeAnInt(int myNumber)
        {
            myNumber = 456;
        }

        // this method takes in an employee class, which is passed by reference
        // and then changes a property of it
        static void changeAnObject(Employee employee)
        {
            employee.FirstName = "Olivia";
        }
    }
}
