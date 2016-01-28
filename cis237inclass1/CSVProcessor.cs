using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        public bool ImportCSV(string pathToCSVFile, Employee[] employees)
        {
            StreamReader streamReader = null;

            try
            {
                //declare a string to represent a line we read
                string line;

                //create a new instance of the StreamReader class
                streamReader = new StreamReader(pathToCSVFile);

                //create a counter to know what index to place the new object
                int counter = 0;

                // this line is doing a bunch of stuff. it is reading a line from
                // the file. it is assigning that info to the 'line' variable, and 
                // lastly it is making sure that what it just read was not null(empty).
                // if it is null we are done reading the file and we can exit the loop. 
                while ((line = streamReader.ReadLine()) != null)
                {
                    processLine(line, employees, counter++);
                }

                return true;
            }
            catch (Exception e)
            {
                // displays errors that occured
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.StackTrace); 
            }
            finally
            {
                // If an instance of the streamreader was made, we want to ensure
                // that we close it. the finally block is a perfect place to put it
                // since it will get called regardless of whether or noth the try succeeded
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }

            return false;
        }


        private void processLine(string line, Employee[] employees, int index)
        {
            //split the line into parts, and assign the party to a string array
            string[] parts = line.Split(',');

            //create some local variables and assign the various parts to them
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            //Now we need to add a new employee to the array and us the parts we 
            // parsed out. if you had a collection class, i would hope that it has a 
            // method that you made called 'add' that would then do the work of 
            // adding a new employee to the collection

            employees[index] = new Employee(firstName, lastName, salary); 
        }
    }
}
