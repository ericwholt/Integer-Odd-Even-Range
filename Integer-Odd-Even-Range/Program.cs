using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Odd_Even_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get users name
            bool invalidName = true;
            string name = "";

            while(invalidName)
            {
                name = GetUserInput("Enter Name");
                invalidName = IsNameInvalid(name);
            }
            //Loop until user wants to stop
            while (true)
            {
                bool invalidInteger = true;
                string userInput = "";
                int usersChoice = 0;
                while (invalidInteger)
                {
                    //Prompt for user to enter an integer between 1 and 100
                    userInput = GetUserInput("Enter a number between 1 and 100");
                    //Validate string is an integer, is positive, and between 1 and 100
                    invalidInteger = IsStringAnInnvalidInteger(userInput);//End loop if it is a valid integer.
                    if (!invalidInteger)
                    {
                        usersChoice = int.Parse(userInput);
                    }
                }

                EvaluateInteger(name, usersChoice);

                if(GetUserInput("Continue (y/n)") == "n")
                {
                    break;
                }

            }
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Console.Write("Press Any Key...");
            Console.ReadKey();//Keep console from closing immediately

        }

        /// <summary>
        /// Method to display message and get input from user.
        /// </summary>
        /// <param name="message">string</param>
        /// <returns>User input as string.</returns>
        static string GetUserInput(string message)
        {
            Console.Write(message + ": ");
            return Console.ReadLine();   
        }

        /// <summary>
        /// Validates userinput is an integer and returns a bool
        /// </summary>
        /// <param name="stringToValidate"></param>
        /// <returns>Returns false if integer or false if it is not</returns>
        static bool IsStringAnInnvalidInteger(string stringToValidate)
        {
            //Check string is a integer with Tryparse. If it is then save it to local int integer.
            if(int.TryParse(stringToValidate, out int integer))
            {
                //We have a valid integer. Check if it is between 1 and 100
                if (integer > 1 && integer < 100)
                {
                    return false; //All conditions pass the integer is valid
                }
            }
            Console.WriteLine("You must enter a number between 1 and 100");
            return true;
        }

        /// <summary>
        /// Method checks name input to ensure user entered a name.
        /// </summary>
        /// <param name="name">string</param>
        /// <returns>True if name length is 0</returns>
        static bool IsNameInvalid(string name)
        {
            if(name.Length > 0)
            {
                return false;
            }
            Console.WriteLine("You must enter a valid name.");
            return true;
        }

        /// <summary>
        /// Display approiate information to console based on the integer entered
        /// </summary>
        /// <param name="name">string</param>
        /// <param name="integer">int</param>
        static void EvaluateInteger(string name, int integer)
        {
            bool isEven = CheckIntegerIsEven(integer);

            if (isEven)
            {
                //Integer even
                if(integer >= 2 && integer <= 25)
                {
                    Console.WriteLine($"{name} the number is Even and less than 25.");
                } else if (integer >= 26 && integer <= 60)
                {
                    Console.WriteLine($"{name} the number is Even.");
                } else
                {
                    Console.WriteLine($"{name} the number {integer} is Even.");
                }
            }
            else
            {
                //Integer odd
                Console.WriteLine($"{name} {integer} Odd.");
            }
        }

        /// <summary>
        /// Check if the integer is even.
        /// </summary>
        /// <param name="integer">int</param>
        /// <returns>Returns true if even false if odd.</returns>
        static bool CheckIntegerIsEven(int integer)
        {
            if(integer % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
