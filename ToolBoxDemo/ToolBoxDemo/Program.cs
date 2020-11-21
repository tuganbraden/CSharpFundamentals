using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxDemo
{
    class Program
    {
        //The Main methosacts as our program's .exe file (executable/entry point). This is the file we double click on to start any program
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to your Tool Box!");

            KeyToContinueWithClearConsole();
            Console.WriteLine("You can either hit \"Y\" then hit ENTER to continue, or hit \"N\" then ENTER to clear the console and continue");
            
            string userResponse = Console.ReadLine();

            if(userResponse == "N")
            {
                KeyToContinue();
            }
            else if(userResponse == "N")
            {
                KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure, friend, but I'm gonna close the program when you hit ENTER");
            }
            Console.ReadLine();



            //Functions are methods written outside of a custom class
            //Methods are functions written inside of a custom class

            //Functions below this line
            void KeyToContinue()
            {
            Console.WriteLine("Hit ENTER to Clear the Console and continue on with the code...");
            Console.ReadLine();
            }

            void ClearConsole()
            {
            Console.Clear();
            //Console.WriteLine("Congratulations, you've cleared the console!");
            }
            
            void KeyToContinueWithClearConsole()
            {
                KeyToContinue();
                ClearConsole();
            }
        }
    }
}
