using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> orderProducts = new List<Product>();
            int menuOption;
            string outputStr = "";
            bool quitBangazon = false;

            while (!quitBangazon)
            {
                outputStr = Menu.displayMainMenu(outputStr);
                Int32.TryParse(Console.ReadLine(), out menuOption);

                //Console.WriteLine("\n******************************************************");
                //Console.WriteLine("** Welcome to Bangazon Command Line Ordering System **");
                //Console.WriteLine("******************************************************\n");
                //Console.WriteLine("1. Create an Account");
                //Console.WriteLine("2. Create a Payment Option");
                //Console.WriteLine("3. Order a Product");
                //Console.WriteLine("4. Complete an Order");
                //Console.WriteLine("5. See Product Popularity");
                //Console.WriteLine("6. Leave Bangazon!\n");
                //Console.Write("Your choice: ");
                //Int32.TryParse(Console.ReadLine(), out menuOption);

                switch (menuOption)
                {
                    case 1: //create an account
                        Menu.addCustomer();
                        break;
                    case 2: //create a payment option
                        Menu.addPaymentOption();
                        break;
                    case 3: //order a product
                        orderProducts = Menu.orderProduct(orderProducts);
                        break;
                    case 4: //complete an order
                        outputStr = Menu.completeOrder(orderProducts);
                        break;
                    case 5: //product popularity
                        Menu.popularProducts();
                        Console.Read();
                        break;
                    case 6: //Leave Bangazon!!
                        Console.WriteLine("\nAdios!\n");
                        quitBangazon = true;
                        break;
                    default:
                        break;
                }
            }
        } //Main
    } //Program
}//Namespace
