using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor2.UI
{
    public class InputClass
    {
        public static int GetIntFromUser(string prompt)
        {
            int result;
            string userInput;

            // loop until we return an int
            while (true)
            {
                // 1 & 2: Prompt and Read
                Console.WriteLine(prompt);
                userInput = Console.ReadLine();

                // attempt to convert
                if (int.TryParse(userInput, out result))
                {
                    // good input
                    return result;
                }

                // bad input
                Console.WriteLine("That is not a valid input.");
            }
        }
        public static string GetStringFromUser(string prompt)
        {
           
            string userInput = "";
            bool process = true;

            // loop until we return an int
            while (process)
            {
                // 1 & 2: Prompt and Read
                Console.Write(prompt);
                userInput = Console.ReadLine();

                // attempt to convert
                if (!String.IsNullOrEmpty(userInput) && !String.IsNullOrWhiteSpace(userInput))
                {
                    process = false;
                }
                else
                {
                    Console.WriteLine("That is not valid input. Try again.");
                }

                // bad input
                
            }
            return userInput;
        }
    }
}
