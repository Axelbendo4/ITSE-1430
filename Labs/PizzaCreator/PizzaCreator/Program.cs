using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {

        static void Main( string[] args )
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



        }
        private static void LargeSize()
        {
            throw new NotImplementedException();
        }

        private static void MeduimPizza()
        {
            throw new NotImplementedException();
        }

        private static void SmallPizza()
        {
            throw new NotImplementedException();
        }

    }
    private void MeatOrder()
    {

        while (true)

        Console.WriteLine("\t1. Bacon");
    }

    object ReadInt32( int v1, int v2 )
    {
        throw new NotImplementedException();
    }
}



  


















    
  

