// Axel G Bendo
//ITSE 1430

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        public static bool wantCheese;
        public static bool wantDelivery;
        public static bool wantSauce;
        public static bool wantVegetables;
        public static bool wantMeats;
        public static bool wantSize;
        public static bool[] MeatToppings = new bool[4];
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









            Console.WriteLine("N)ew Order");
            Console.WriteLine("M)odify Order");
            Console.WriteLine("D)isplay Order");
            Console.WriteLine("Q)uit");

            Console.WriteLine("Please enter the first letter of the value you would like to do:");
            ConsoleKeyInfo choice = Console.ReadKey(true);
            while (true)
            {
                switch (choice.KeyChar)
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
                        choice = Console.ReadKey(true);

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
          


            Console.WriteLine("\n\nPizza Order");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Size: {sizeTotal}   ${size}");
            Console.WriteLine($"Meats: {meatsTotal}   ${meats}");
            Console.WriteLine($"Vegetables: {vegetablesTotal}   ${vegetables}");
            Console.WriteLine($"Sauce: {sauceTotal}   ${sauce}");
            Console.WriteLine($"Cheese: {cheeseTotal}   ${cheese}");
            Console.WriteLine($"Delivery or Take out: {deliveryTotal}   ${delivery}");
            Console.WriteLine("------------------------");
            PriceOfPizza();
            Console.WriteLine("\n\n");



        }


        private static void  ModifyOrder()
        {
            Console.WriteLine("Do you want to modify your Order?");

            if (ConfirmChoice("Are you sure to modify your order?"))
            {
                 double  Total = 0.00; 
                GetSizeOrder();
                GetMeatToppings();
                GetVegetables();
                GetSauceofPizza();
                GetCheeseOfPizza();
                GetDeliveryOfPizza();


                DisplayOrder();
                
            }

        }

        private static void NewOrder(bool[] men)
        {
            GetSizeOrder();
            GetMeatToppings();
            GetVegetables();
            GetSauceofPizza();
            GetCheeseOfPizza();
            GetDeliveryOfPizza();


            DisplayOrder();
           
        }

        private static void PriceOfPizza()
        {

            priceOfPizza = 
            (size + (meats * .5) + (vegetables * .5) + sauce + cheese + delivery);
            Console.WriteLine($"Total: ${priceOfPizza}");
            


            

            




        }
        private static void GetDeliveryOfPizza()
        {
            string message = "One is required?";
            Console.WriteLine("1) for Yes or 2) for No.");
            do
            {
                bool flag = false;
                while (!flag)
                {

                    Console.WriteLine("1) Take Out  ($0)");
                    Console.WriteLine("2) Delivery  ($2.5)");


                    ConsoleKeyInfo choice = Console.ReadKey(true);

                    switch (choice.KeyChar)

                    {
                        case '1':
                            deliveryOfPizza = "Take Out";
                            flag = true;
                            wantDelivery = true;
                            deliveryTotal = "Take_Out";
                            delivery = 0;
                            break;

                        case '2':
                            deliveryOfPizza = "Delivery";
                            flag = true;
                            wantDelivery = true;
                            deliveryTotal = "Delevery";
                            delivery = 2.50;
                            return;


                        default:

                            Console.WriteLine("Please enter a valid value");
                            choice = Console.ReadKey(true);


                            break;
                    };
                    Console.WriteLine("\nTake out or Delivery : " + deliveryTotal);

                };



            } while (!ConfirmChoice(message));
        }

        private static void GetCheeseOfPizza()
        {
            string message = "Are you sure of choice?";

           
            Console.WriteLine("1) for Yes or 2) for No.");
            string input = Console.ReadLine();

            do
            {
                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Cheese (One is required)");
                    Console.WriteLine("1) Regular  ($0)");
                    Console.WriteLine("2) Extra    ($1.25)");


                    ConsoleKeyInfo choice = Console.ReadKey(true);

                    switch (choice.KeyChar)
                    {

                        case '1':
                            cheeseOfPizza = "Regular";
                            flag = true;
                            wantCheese = false;
                            cheeseTotal = "Regular";
                            cheese = 0.00;
                            return;

                        case '2':
                            cheeseOfPizza = "Extra";
                            flag = true;
                            wantCheese = true;
                            cheeseTotal = "Extra";
                            cheese = 1.25;
                            return;

                        default:

                            Console.WriteLine("Please enter a valid value");
                            choice = Console.ReadKey(true);
                            break;
                    };

                };

            } while (!ConfirmChoice(message));

            PriceOfPizza();

        }

        private static void GetSauceofPizza()
        {
            string message = "Are you sure of choice?";


            do
            {
                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Sauce (One is required)");
                    Console.WriteLine("1) Traditional  ($0)   ");
                    Console.WriteLine("2) Garlic       ($1)   ");
                    Console.WriteLine("3) Oregano      ($1)   ");

                    ConsoleKeyInfo choice = Console.ReadKey(true);

                    switch (choice.KeyChar)

                    {
                        case '1':
                            sauceOfPizza = "Traditional";
                            flag = true;
                            wantSauce = true;
                            sauceTotal = "Traditional";
                            sauce = 0.00;
                            break;

                        case '2':
                            sauceOfPizza = "Garlic";
                            flag = true;
                            wantSauce = true;
                            sauceTotal = "Garlic";
                            sauce = 1.00;
                            break;

                        case '3':
                            sauceOfPizza = "Oregano";
                            flag = true;
                            wantSauce = true;
                            sauceTotal = "Oregano";
                            sauce = 1.00;

                            break;

                        default:

                            Console.WriteLine("Please enter a valid value");
                            choice = Console.ReadKey(true);

                            break;
                    };

                    Console.WriteLine("\nSauce: " + sauceTotal);

                };


            } while (!ConfirmChoice(message));

            PriceOfPizza();
        }

        private static void GetVegetables()
        {
            string message = "Are you sure of choice?";

            do
            {

                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Vegetables (zero or more )Each option $0.50 extra.The user can select or unselect the options until done.");
                    Console.WriteLine("1) Black olives  ($0.50)");
                    Console.WriteLine("2) Mushrooms     ($0.50)");
                    Console.WriteLine("3) Onions        ($0.50)");
                    Console.WriteLine("4) Peppers       ($0.50)");

                    ConsoleKeyInfo choice = Console.ReadKey(true);

                    switch (choice.KeyChar)
                    {
                        case '1':
                            vegetablesOfPizza = "Black Olives";
                            flag = true;
                            wantVegetables = false ;
                           vegetablesTotal = "Black Olives";
                            vegetables = 0.50;
                            break; 

                        case '2':
                            vegetablesOfPizza = "Mushrooms";
                            flag = true;
                            wantVegetables = false ;
                            vegetablesTotal = "Mushrooms";
                            vegetables = 0.50;
                            break;

                        case '3':
                            vegetablesOfPizza = "Onions";
                            flag = true;
                            wantVegetables = false ;
                            vegetablesTotal = "Onions";
                            vegetables = 0.50;
                            break;


                        case '4':
                            vegetablesOfPizza = "Peppers";
                            flag = true;
                            wantVegetables = false ;
                            vegetablesTotal = "Peppers";
                            vegetables = 0.50;
                            break;

                        default:


                            Console.WriteLine("Please enter a valid value");
                            choice = Console.ReadKey(true);
                            break;

                    };



                }

            } while (!ConfirmChoice(message));
        }

        private static void GetMeatToppings()
        {
            string message = "Are you sure of choice ? ";
            Console.WriteLine("1) for Yes or 2) for No.");


            do
            {

                bool flag = false;
                while (!flag)
                {
                    
                    ConsoleKeyInfo choice = Console.ReadKey(true);
                    Console.WriteLine("1) Bacon     ($0.75)");
                    Console.WriteLine("2) Ham       ($0.75) ");
                    Console.WriteLine("3) Pepporoni ($0.75)");
                    Console.WriteLine("4) Sausage   ($0.75)");
                    

                    switch (choice.KeyChar)
                    {
                        case '1':
                            meatsOfPizza = "Bacon"; flag = true;meatsTotal = "Bacon";meats = 0.75; wantMeats = true; break;
                            
                            ;

                        case '2':
                            meatsOfPizza = "Ham"; flag = true; meatsTotal = "Ham"; meats = 0.75; wantMeats = true; break;



                        case '3':
                            meatsOfPizza = "Pepporoni"; flag = true; meatsTotal = "Pepperoni"; meats = 0.75; wantMeats = true; break;


                        case '4':
                            meatsOfPizza = "Sausage"; flag = true; meatsTotal = "Sausage"; meats = 0.75; wantMeats = true; break;




                        default:


                            Console.WriteLine("Please enter a valid value");
                            choice = Console.ReadKey(true);
                            break;
                    };

                    Console.WriteLine("meats" + meatsTotal);


                };


            } while (!ConfirmChoice(message));


        }

        private static void GetSizeOrder()
        {
                  string message = "Are you sure of choice ? ";


            do
            {
                bool flag = false;
                while (!flag)
                {
                   
                    Console.WriteLine("1) Small($5)");
                    Console.WriteLine("2) Meduim($6.25)");
                    Console.WriteLine("3) Large(8.75");
                    ConsoleKeyInfo choice = Console.ReadKey(true);

                    switch (choice.KeyChar)

                    {
                        case '1':
                            sizeOfPizza = "Small";
                            flag = true;
                            wantSize = true;
                            sizeTotal = "small";
                            size = 5.00;
                            break;

                        case '2':
                            sizeOfPizza = "Medium";
                            flag = true;
                            wantSize = true;
                            sizeTotal = "Meduim";
                            size = 6.25;
                            break;

                        case '3':
                            sizeOfPizza = "Large";
                            flag = true;
                            wantSize = true;
                            sizeTotal = "Large";
                            size = 8.75;
                            break;

                        default:

                            Console.WriteLine("Please enter a valid value");

                            break;
                    };
                    Console.WriteLine("size" + sizeTotal);
                };

            } while (!ConfirmChoice (message )) ;

        
        
         PriceOfPizza();
        }

        private static string sizeOfPizza;
        private static string cheeseOfPizza;
        private static string deliveryOfPizza;
        private static string sauceOfPizza;
        private static string vegetablesOfPizza;
        private static string meatsOfPizza;



    



        private static bool ConfirmChoice(string message)
        {

            do
            {
                Console.WriteLine($"{message} (Y/N)\n");
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.KeyChar)
                {
                    case 'Y':
                    case 'y':
                        return true;

                    case 'N':
                    case 'n':
                        return false;

                    default:
                        Console.WriteLine("Please enter Y)es or N)o.");
                        break;

                };
            } while (true);
        }

        private static string sizeTotal = "";
        private static string meatsTotal = "";
        private static string vegetablesTotal = "";
        private static string sauceTotal = "";
        private static string cheeseTotal = "";
        private static string deliveryTotal = "";
        private static double size;
        private static double meats = 0;
        private static double vegetables = 0;
        private static double sauce;
        private static double cheese;
        private static double delivery;
        private static double priceOfPizza;
    }
}





    










































