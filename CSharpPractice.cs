using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // This first part collects the users name and converts it to uppercase.
            Console.WriteLine("Please enter  your name");
            string firstName = Console.ReadLine();
            string firstString = firstName;
            string upperCase = firstString.ToUpper();
            // This second part concatinates the modified string to a sentence. 
            Console.WriteLine("My name is " + upperCase + " in all upper Case!!!!");

            // This begins an loop
            for (int i =0; i < 2; i++ )
            {
                // prompts user to type exit or quit and stores it into userQuit Variable
                Console.WriteLine("Please type Exit or Quit to terminate the program");
                string userQuit = Console.ReadLine();

                // keywords for exiting the program array
                string[] exitWords = { "exit", "quit" };

                // initialize a boolean for quitting at false
                bool quitting = false;

                foreach (string exitOrQuit in exitWords)
                {
                    // this is comparing  the equality in individual strings from the exitWords array to userInput
                    if (String.Compare(exitOrQuit, userQuit, true) == 0)
                    {
                        quitting = true;
                        // this is nested for loop that allows the user to terminate the program if they meet the conditions
  
                        if (quitting == true)
                        {
                            // this collects the user input and quits the program
                            Console.WriteLine("Please type any key to exit");
                            Console.ReadKey();
                            break;

                        }
                    }
                    else
                    {
                        // this restarts the loop
                        i = 0;
                    }
                    
                   
                    
                    
            


                }




            }
        }
    }
}
