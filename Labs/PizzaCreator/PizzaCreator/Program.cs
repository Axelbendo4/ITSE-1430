using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {

        static void Main(string[] args)
        {
            bool notQuit;
            do


            {
                notQuit = DisplayMenu();

            } while (notQuit);
        }
        private static bool DisplayMenu()
        {

            while (true)
            {
                Console.WriteLine("N)ew Order");
                Console.WriteLine("M)odify Order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'n':
                    case 'N':
                        NewOrder();
                        return true;

                    case 'm':
                    case 'M':
                        ModifyOrder();
                        return true;

                    case 'd':
                    case 'D':
                        DisplayOrder();
                        return true;



                    case 'q':
                    case 'Q':
                        Quit();
                        return false;

                    default:

                        Console.WriteLine("Please enter a valid value");

                        break;
                };
            };
        }

        private static void Quit()
        {
            Console.WriteLine("Quit");
        }

        private static void DisplayOrder()
        {
            Console.WriteLine("DisplayOrder");
        }

        private static void ModifyOrder()
        {
            Console.WriteLine("ModifyOrder");
        }

        private static void NewOrder()
        {
            GetSizeOrder();
            GetMeatToppings();

        }

        private static void GetMeatToppings()
        {
            Console.WriteLine("Do you want meats on your pizza?");
            Console.WriteLine("1) for Yes or 2) for No.");
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                while (true)
                {


                }
            }

            
        }

        private static void GetSizeOrder()
        {

            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Size(one is required)");
                Console.WriteLine("1) Small($5)");
                Console.WriteLine("2) Meduim($6.25)");
                Console.WriteLine("3) Large(8.75");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1': sizeOfPizza = "Small"; flag = true; return;

                    case '2': sizeOfPizza = "Meduim"; flag = true; return;

                    case '3': sizeOfPizza = "Large"; flag = true; return;

                    default:

                        Console.WriteLine("Please enter a valid value");

                        break;
                };
            }


        }

        static string sizeOfPizza;
        //private bool meatToppings[] = new bool meatToppings[4];
    }
}





    


       

    

    




























