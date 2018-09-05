using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section1
{
    class Program
    {
        private static int minValue;

        static void Main( string[] args )
        {

            bool notQuit;
            do
            {
               notQuit = DisplayMenu();
            } while (notQuit);



            //playWithStrings();

        }

        private static void playWithStrings()
        {
            string hoursString = "10A";
            //int hours = Int32.Parse(hoursString);
            //int hours;
            //bool result = Int32.TryParse(hoursString,out  hours);
            //bool result = Int32.TryParse(hoursString, out int  hours);

            // hoursString = hours.ToString();
            // 4.75.ToString();
            //457.ToString();
            //Console.ReadLine().ToString();

            string message = "Hello\tworld";
            string filePath = "C:\\Temp\\Test";

            //Verbatim strings 
            filePath = @"C:\Temp\Test";

            //Concat
            string FirstName = "Bob";
            string lastName = "Smith";
            string name = FirstName + "  " + lastName;

            //strings are immutable - this produces a new string 
            //name = "Hello " + name;
            Console.WriteLine("Hello" + name);
            Console.WriteLine("Hello {1}", FirstName, lastName);
            string str = String.Format("Hello {1}", FirstName, lastName);
            Console.WriteLine(str);


            //Approach 4
            Console.WriteLine($"Hello  {FirstName} {lastName} ");

            string missing = null;
            string empty = "";
            string empty2 = String.Empty;

            //Checking for empty strings
            //if (firstName.Lenght == 0)
            // if (FirstName!= null && FirstName != "")
            if (!String.IsNullOrEmpty(FirstName))
                Console.WriteLine(FirstName);

            //Other stuff
            string upperName = FirstName.ToUpper();
            string lowerName = FirstName.ToLower();

            //Comparison
            bool areEqual = FirstName == lastName;

            areEqual = FirstName.ToLower() == lastName.ToLower();
            areEqual = String.Compare(FirstName, lastName, true) == 0;

            bool startsWithA = FirstName.StartsWith("A");
            bool endsWithA = FirstName.EndsWith("A");
            bool hasA = FirstName.IndexOf("A") >= 0;
            String subset = FirstName.Substring(4);

            //Clean up
            string cleanMe = FirstName.Trim(); //trimstart, TrimEnd
            string makeLonger = FirstName.PadLeft(20); //PadRight


        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movie");
                Console.WriteLine("v)iew Movies");
                Console.WriteLine("Q)uit");



                string input = Console.ReadLine();
                switch (input[0])





                {


                    case 'a':
                    case 'A':
                    AddMovie();
                    return true;
                    case 'e':
                    case 'E':
                    EditMovie();
                    return true;
                    case 'd':
                    case 'D':
                    DeleteMovie();
                    return true;
                    case 'v':
                    case 'V':
                    ViewMovies();
                    return true;
                    case 'q':
                    case 'Q':
                    ;
                    return false;


                    default:
                    Console.WriteLine("Please enter a valid value.");
                    break;
                };

            };
        }

        private static void ViewMovies()
        {
            Console.WriteLine("ViewMovies");
        }

        private static void AddMovie()
        {
            Console.WriteLine("AddMovie");
        }


        private static void EditMovie()
        {
            Console.WriteLine("EditMovie");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("DeleteMovie");
        }

        private static int ReadInt32( string message )


        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out int result))
                {
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine($"You must enter an integer value >= {minValue}");
            };
        }
    }

}