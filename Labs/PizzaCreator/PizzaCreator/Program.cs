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
            GetVegetables();
            GetSauceofPizza();
            GetCheeseOfPizza();
            GetDeliveryOfPizza();
        
        }

        private static decimal PriceOfPizza()
        {


            var small =         5.00m;
            var Medium =        6.25m;
            var Large =         8.75m;
            var Bacon =         0.75m;
            var Ham =           0.75m;
            var Pepperoni =     0.75m;
            var Sausage =       0.75m;
            var black =         0.50m;
            var Mushrooms =     0.50m;
            var Onions =        0.50m;
            var Peppers =       0.50m;
            var Traditional =      0m;
            var Garlic =           1m;
            var Oregano =          1m;
            var Regular =          0m;
            var Extra =         1.25m;
            var Take =             0m;
            var Delivery =       2.50;


            return 0;
        }

        private static void GetDeliveryOfPizza()
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Delivery(one is required)");
                Console.WriteLine("1) Take Out  ($0)");
                Console.WriteLine("2) Delivery  ($2.5)");
               

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case '1': DeliveryOfPizza = "Take Out"; flag = true; return;

                    case '2': DeliveryOfPizza = "Delivery"; flag = true; return;


                    default:

                        Console.WriteLine("Please enter a valid value");
                        break;

                }
            }
        }

        private static void GetCheeseOfPizza()
        {
            Console.WriteLine("Do you want Cheese on your pizza?");
            Console.WriteLine("1) for Yes or 2) for No.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Cheese (One is required)");
                    Console.WriteLine("1) Regular  ($0)");
                    Console.WriteLine("2) Extra    ($1.25)");
                    

                    switch (Console.ReadLine()[0])
                    {

                        case '1': CheeseOfPizza = "Regular"; flag = true; return;

                        case '2': CheeseOfPizza = "Extra"; flag = true; return;

                        default:

                            Console.WriteLine("Please enter a valid value");
                            break;
                    }

                }

            }

        }

        private static void GetSauceofPizza()
        {
            Console.WriteLine("Do you want Sauce on your pizza?");
            Console.WriteLine("1) for Yes or 2) for No.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Sauce (One is required)");
                    Console.WriteLine("1) Traditional  ($0)   ");
                    Console.WriteLine("2) Garlic       ($1)   ");
                    Console.WriteLine("3) Oregano      ($1)   "); 
            

                    switch (Console.ReadLine()[0])
                    {
                          case '1': SauceOfPizza = "Traditional"; flag = true; return;

                          case '2': SauceOfPizza = "Garlic"; flag = true; return;

                          case '3': SauceOfPizza = "Oregano"; flag = true; return;

                        default:

                           Console.WriteLine("Please enter a valid value");
                            break;
                    }
                }


            }
        }

        private static void GetVegetables()
        {
            Console.WriteLine("Do you want vegetables on your pizza?");
            Console.WriteLine("1) for Yes or 2) for No.");
            string input = Console.ReadLine();

            if (input == "1")
            {
                bool flag = false;
                while (!flag)
                {


                    Console.WriteLine("Vegetables (zero or more )Each option $0.50 extra.The user can select or unselect the options until done.");
                    Console.WriteLine("1) Black olives  ($0.50)");
                    Console.WriteLine("2) Mushrooms     ($0.50)");
                    Console.WriteLine("3) Onions        ($0.50)");
                    Console.WriteLine("4) Peppers       ($0.50)");

                    switch (Console.ReadLine()[0])
                    {

                        case '1': VegetablesOfPizza = "Black Olives"; flag = true; return;

                        case '2': VegetablesOfPizza = "Mushrooms"; flag = true; return;

                        case '3': VegetablesOfPizza = "Onions"; flag = true; return;


                        case '4': VegetablesOfPizza = "Peppers"; flag = true; return;

                        default:


                            Console.WriteLine("Please enter a valid value");
                            break;

                    } 
                }

            }

        }

        private static void GetMeatToppings()
        {
            Console.WriteLine("Do you want meats on your pizza?");
            Console.WriteLine("1) for Yes or 2) for No.");
            string input = Console.ReadLine();

            if (input == "1")
            {

                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Meats(zero or more )Each option $0.75 extra.The user can select or unselect the options until done.");
                    Console.WriteLine("1) Bacon     ($0.75)");
                    Console.WriteLine("2) Ham       ($0.75) ");
                    Console.WriteLine("3) Pepporoni ($0.75)");
                    Console.WriteLine("4) Sausage   ($0.75)");
                    switch (Console.ReadLine()[0])
                    {
                        case '1': MeatsOfPizza = "Bacon"; flag = true; return;

                        case '2': MeatsOfPizza = "Ham"; flag = true; return;

                        case '3': MeatsOfPizza = "Pepperoni"; flag = true; return;


                        case '4': MeatsOfPizza = "Sausage"; flag = true; return;

                        default:


                            Console.WriteLine("Please enter a valid value");
                            break;
                    }
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
                    case '1': SizeOfPizza1 = "Small"; flag = true; return;

                    case '2': SizeOfPizza1 = "Meduim"; flag = true; return;

                    case '3': SizeOfPizza1 = "Large"; flag = true; return;

                    default:

                        Console.WriteLine("Please enter a valid value");

                        break;
                };
            }


        }

        private  static string sizeOfPizza;
        private static string cheeseOfPizza;
        private static string deliveryOfPizza;

        public static string MeatsOfPizza { get; private set; }
        public static string VegetablesOfPizza { get; private set; }
        public static string SauceOfPizza { get; private set; }
        public static string DeliveryOfPizza { get => deliveryOfPizza; set => deliveryOfPizza = value; }
        public static string CheeseOfPizza { get => cheeseOfPizza; set => cheeseOfPizza = value; }
        public static string SizeOfPizza1 { get => sizeOfPizza; set => sizeOfPizza = value; }
    }
}





    


       

    

    




























