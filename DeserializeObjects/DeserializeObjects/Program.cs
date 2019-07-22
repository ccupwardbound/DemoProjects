using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeObjects
{
    class Program
    {
        private static Person Jack = new Person();
        private static Person Sarah = new Person();
        private static List<Person> MyPeople = new List<Person>();

        private static ItemInfo FirstItem = new ItemInfo()
        {
            Name = "Ball",
            Dimension = new Dimension()
            {
                Height = 4F,
                Width = 4F,
                Depth = 4F
            },
            Color = new ItemColor()
            {
                Red = 27,
                Blue = 2,
                Green = 135
            }
        };

        private static ItemInfo SecondItem = new ItemInfo()
        {
            Name = "Lego",
            Dimension = new Dimension()
            {
                Height = 1.2F,
                Width = 0.5F,
                Depth = 0.25F
            },
            Color = new ItemColor()
            {
                Red = 255,
                Blue = 0,
                Green = 0
            }
        };

        private static List<ItemInfo> MyItems = new List<ItemInfo>();

        static void Main(string[] args)
        {
            MyItems.Add(FirstItem);
            MyItems.Add(SecondItem);

            foreach (var item in MyItems)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Height: " + item.Dimension.Height);
                Console.WriteLine("Width: " + item.Dimension.Width);
                Console.WriteLine("Depth: " + item.Dimension.Depth);
                Console.WriteLine("Color: {0} | {1} | {2}", item.Color.Red, item.Color.Blue, item.Color.Green);
                Console.WriteLine();
            }


            //Jack.Name = "Jack Sprat";
            //Jack.SSN = "Jack's SSN";
            //Jack.Height = 5.5F;
            //Jack.Weight = 165F;
            //Jack.EyeColor = "Blue";

            //Sarah.Name = "Sarah Jones";
            //Sarah.SSN = "Sarah's SSN";
            //Sarah.Height = 12.8F;
            //Sarah.Weight = 3F;
            //Sarah.EyeColor = "None";

            //MyPeople.Add(Jack);
            //MyPeople.Add(Sarah);

            //foreach (var person in MyPeople)
            //{
            //    Console.WriteLine("Name: " + person.Name);
            //    Console.WriteLine("SSN: " + person.SSN);
            //    Console.WriteLine("Height: " + person.Height.ToString());
            //    Console.WriteLine("Weight: " + person.Weight.ToString());
            //    Console.WriteLine("Eye Color: " + person.EyeColor);
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Name: " + Jack.Name);
            //Console.WriteLine("SSN: " + Jack.SSN);
            //Console.WriteLine("Height: " + Jack.Height.ToString());
            //Console.WriteLine("Weight: " + Jack.Weight.ToString());
            //Console.WriteLine("Eye Color: " + Jack.EyeColor);

            //Console.WriteLine();

            //Console.WriteLine("Name: " + Sarah.Name);
            //Console.WriteLine("SSN: " + Sarah.SSN);
            //Console.WriteLine("Height: " + Sarah.Height.ToString());
            //Console.WriteLine("Weight: " + Sarah.Weight.ToString());
            //Console.WriteLine("Eye Color: " + Sarah.EyeColor);


            Console.ReadLine();

        }
    }
}
