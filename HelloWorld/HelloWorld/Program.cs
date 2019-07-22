using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        //Declare Variables
        public static int a;
        public static int b;
        public static int c;
        public static string resultSumText;
        public static string resultDiffText;

        static void Main(string[] args)
        {
            //Assign variables
            a = 5;
            b = 5;
            c = 0;
            resultSumText = "The sum is: ";
            resultDiffText = "The difference is: ";

            //Test our function
            c = AddMeTogether(a, b);
            int d = SubtractMe(c, a);

            //Display Things
            //Console.WriteLine(resultSumText + c.ToString());
            Console.WriteLine(resultSumText + AddMeTogether(a, b).ToString());
            //Console.WriteLine(resultDiffText + d.ToString());
            Console.WriteLine(resultDiffText + SubtractMe(c, a).ToString());
            Console.ReadLine();
        }

        public static int AddMeTogether(int x, int y)
        {
            return x + y;
        }

        public static int SubtractMe(int x, int y)
        {
            return x - y;
        }
    }
}
