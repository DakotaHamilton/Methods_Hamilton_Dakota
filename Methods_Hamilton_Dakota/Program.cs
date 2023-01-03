using System;

namespace Methods_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args) //Main Method
        {
            Console.WriteLine("Please enter a whole number!"); //Asks for a whole number
            int x = Convert.ToInt32(Console.ReadLine()); //Reads and assigns the user input to x
            Console.WriteLine("Please enter another whole number!"); //Asks the for another whole number
            int y = Convert.ToInt32(Console.ReadLine()); //Reads and assigns the user input to y
            
            Console.WriteLine(Multiply(x,y)); //Executes Multiply when both values are assigned

            Console.WriteLine("What is your name?"); //Asks for the user's name
            string name = Console.ReadLine(); //Reads the username input

            WelcomeUser(name); //Executes WelcomeUser when username is provided

            Goodbye(); //Executes Goodbye 
        }

        static int Multiply(int num1, int num2) //Int Method
        {
            return num1 * num2; //Multiplies the two assigned values 
        }

        static void WelcomeUser(string username) //Username Method
        {
            Console.WriteLine($"Hello, {username}! It is nice to meet you!"); //prints the username and message to the console
        }

        /// <summary>
        /// Prints a goodbye message to the console
        /// </summary>
        static void Goodbye() //Goodbye Method
        {
            Console.WriteLine("Have a fantastic day!"); //prints the message to console
        }

    }
}