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
            Console.WriteLine("NewOrder");

        }
        private static void SizeOrder()
        {
            while (true)
            {
                Console.WriteLine("Size(one is required)");
                Console.WriteLine("Small($5)");
                Console.WriteLine("Meduim($6.25)");
                Console.WriteLine("Large(8.75");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1':
                        SmallPizza();

                        return;

                    case '2':
                        MeduimPizza(); return;

                    case '3':
                        LargePizza(); return;



                    default:

                        Console.WriteLine("Please enter a valid value");

                        break;
                };
            }


        }

        private static void MeduimPizza()
        {
            throw new NotImplementedException();
        }

        private static void LargePizza()
        {
            throw new NotImplementedException();
        }

        private static void SmallPizza()
        {
            throw new NotImplementedException();
        }
    }





    private static void MeatOrder()
    {
        while (true)
        {
            Console.WriteLine("Meats(zero or more).Each option is $0.50 extra. The user can select or unselect the options until done");
            Console.WriteLine("\t1. Bacon");
            Console.WriteLine("\t1. Ham");
            Console.WriteLine("\t1.Pepperoni");
            Console.WriteLine("\t1.Sausage");

            string input = Console.ReadLine();
            switch (input[0])
            {
                case '1':
                    BaconMeats();return;

                case '2':
                    HamMeats(); return;

                case '3':
                    PepperoniMeats(); return;

                case '4':
                    SausageMeats(); return;



                default:

                    Console.WriteLine("Please enter a valid value");

                    break;

            }

        }


       void SausageMeats()
        {
            throw new NotImplementedException();
        }

        void PepperoniMeats()
        {
            throw new NotImplementedException();
        }

        void HamMeats()
        {
            throw new NotImplementedException();
        }

        void BaconMeats()
        {
            throw new NotImplementedException();
        }

    }

    
}



























