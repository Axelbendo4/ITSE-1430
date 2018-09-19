using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        public static bool wantCheese = false;
        public static bool wantDelivery = false;
        public static bool wantSauce = false;
        public static bool wantVegetables = false;
        public static bool wantMeats = false;
        public static bool wantSize = false;
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
            bool[] menu = new bool[18];







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
                        NewOrder(menu);
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

            Console.WriteLine(PriceOfPizza());
        }


        private static void ModifyOrder()
        {
            Console.WriteLine("ModifyOrder");
        }

        private static void NewOrder(bool[] men)
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
            string[] text = new string[18];
            decimal[] index = new decimal[18];

            text = new string[18]{"small" , "Medium" , "Large" ,"Bacon" ,"Ham", "Pepperoni", "Sausage","Black_Olives","Mushrooms","Onions","Peppers","Traditional","Garlic", "Oregono","Regular","Extra","Take_Out",
                    "Delivery"};


            index = new decimal[18] { 5.00m, 6.25m, 8.75m, 0.75m, 0.75m, 0.75m, 0.75m, 0.50m, 0.50m, 0.50m, 0.50m, 0m, 1m, 1m, 0m, 1.25m, 0m, 2.50m };

            decimal CostOfPizza = 0.00m;

            if (wantSize)
            {
                CostOfPizza += index[1];
                CostOfPizza += index[2];
            }
            else
            {

                CostOfPizza += index[3];
            }
            if (wantMeats)
            {
                CostOfPizza += index[4];
                CostOfPizza += index[5];

            }
            else
            {
                CostOfPizza += index[6];
                CostOfPizza += index[7];
            }
            if (wantVegetables)
            {
                CostOfPizza += index[8];
                CostOfPizza += index[9];
            }
            else
            {
                CostOfPizza += index[10];
                CostOfPizza += index[11];


            }
            if (wantSauce)
            {

                CostOfPizza += index[12];
                CostOfPizza += index[13];
            }
            else
            {
                CostOfPizza += index[14];

            }
            if (wantCheese)
            {
                CostOfPizza += index[15];


            }

            else
            {

                CostOfPizza += index[16];
            }


            if (wantDelivery)
            {

                CostOfPizza += index[17];


            }
            else
            {


                CostOfPizza += index[18];
            }
            return CostOfPizza;




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
                    case '1': DeliveryOfPizza = "Take Out"; flag = true ; wantDelivery = true; return;

                    case '2': DeliveryOfPizza = "Delivery"; flag = true ; wantDelivery = true; return;


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

                        case '1': CheeseOfPizza = "Regular"; flag = true;wantCheese = false; return;

                        case '2': CheeseOfPizza = "Extra"; flag = true;wantCheese = true; return;

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
                          case '1': SauceOfPizza = "Traditional"; flag = true;wantSauce = true; return;

                          case '2': SauceOfPizza = "Garlic"; flag = true; wantSauce = true; return;

                          case '3': SauceOfPizza = "Oregano"; flag = true; wantSauce = true; return;

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

                        case '1': VegetablesOfPizza = "Black Olives"; flag = true;wantVegetables = true; return;

                        case '2': VegetablesOfPizza = "Mushrooms"; flag = true; wantVegetables = true; return;

                        case '3': VegetablesOfPizza = "Onions"; flag = true; wantVegetables = true; return;


                        case '4': VegetablesOfPizza = "Peppers"; flag = true; wantVegetables = true; return;

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
                        case '1': MeatsOfPizza = "Bacon"; flag = true;wantMeats = true; return;

                        case '2': MeatsOfPizza = "Ham"; flag = true; ; wantMeats = true; return;

                        case '3': MeatsOfPizza = "Pepperoni"; flag = true; ; wantMeats = true; return;


                        case '4': MeatsOfPizza = "Sausage"; flag = true; ; wantMeats = true; return;

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
                    case '1': SizeOfPizza1 = "Small"; flag = true;wantSize = true; return;

                    case '2': SizeOfPizza1 = "Meduim"; flag = true; wantSize = true; return;

                    case '3': SizeOfPizza1 = "Large"; flag = true; wantSize = true; return;

                    default:

                        Console.WriteLine("Please enter a valid value");

                        break;
                };
            }


        }

        private static string sizeOfPizza;
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





    


       

    

    




























