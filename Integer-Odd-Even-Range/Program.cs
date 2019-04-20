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
                invalidName = ValidateName(name);
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
                    invalidInteger = ValidateStringIsInteger(userInput);//End loop if it is a valid integer.
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


        }

        static string GetUserInput(string message)
        {
            Console.Write(message + ": ");
            return Console.ReadLine();
            
        }

        static bool ValidateStringIsInteger(string stringToValidate)
        {
            //Check string is a integer with Tryparse. If it is then save it to local int integer.
            if(int.TryParse(stringToValidate, out int integer))
            {
                //We have a valid integer. Check if it is between 1 and 100
                if (integer > 0 && integer < 100)
                {
                    return false; //All conditions pass the integer is valid
                }
            }
            Console.WriteLine("You must enter a number between 1 and 100");
            return true;
        }

        static bool ValidateName(string name)
        {
            if(name.Length > 0)
            {
                return false;
            }
            Console.WriteLine("You must enter a valid name.");
            return true;
        }

        static void EvaluateInteger(string name, int integer)
        {
            bool isEven = CheckIntegerIsEven(integer);

            if (isEven)
            {
                //Integer even
                if(integer >= 2 && integer <= 25)
                {
                    Console.WriteLine($"{name} Even and less than 25.");
                } else if (integer >= 26 && integer <= 60)
                {
                    Console.WriteLine($"{name} Even.");
                } else
                {
                    Console.WriteLine($"{name} {integer} Even.");
                }
            }
            else
            {
                //Integer odd
                Console.WriteLine($"{name} {integer} Odd.");
                if(integer > 60)
                {
                    Console.WriteLine($"{name} {integer} Odd.");
                }
            }
        }

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
