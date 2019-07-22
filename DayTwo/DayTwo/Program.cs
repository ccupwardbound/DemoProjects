using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    class Program
    {
        //Declare vars
        public static int a = 1;
        public static int b = 1;
        public static int c = 0;
        public static string s = "Hi, I'm a string!";

        static void Main(string[] args)
        {
            //Write things to the console
            Console.WriteLine(s);
            //Wait for the user to hit a key
            Console.ReadLine();
            //Call my functions and write them
            Console.WriteLine(FancyMaths.AddMeTogether(a, b).ToString());
            Console.WriteLine(FancyMaths.SubtractThings(a, b));
            Console.WriteLine(FancyMaths.MultThings(a, b));
            Console.WriteLine(FancyMaths.DivThings(a, b));
            Console.WriteLine(FancyMaths.SquareThings(a));
            //Wait for the user to hit a key
            Console.ReadLine();

            //Conditional Statements
            if (a == b) //a does equal b
            {
                Console.WriteLine("a == b"); //so we will write this to the console
            }

            if(a == c) //a does NOT equal c
            {
                Console.WriteLine("a == c"); // so we do NOT write the to the console
            }
            else
            {
                Console.WriteLine("a does not equal c"); //instead we write this to the console
            }

            if(a != c) //a does NOT equal c
            {
                Console.WriteLine("a != c"); //so we write this to the console
            }
            //Wait for the user to hit a key
            Console.ReadLine();

            Console.WriteLine();

            //Basic Looping
            for(int i = 0; i < 10; i++) // i starts as 0, then we add 1 to i everytime we go through the loop until we reach 9
            {
                Console.WriteLine(i); //write the value of i to the console everytime through the loop
            }
            //Wait for the user to hit a key
            Console.ReadLine();
        }
    }
}
