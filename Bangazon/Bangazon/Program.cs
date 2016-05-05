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
            InvoiceDbInfo db = new InvoiceDbInfo();
            List<Product> lineItems = new List<Product>();
            int menuOption;
            bool quitBangazon = false;

            while (!quitBangazon)
            {
                Console.WriteLine("\n******************************************************");
                Console.WriteLine("** Welcome to Bangazon Command Line Ordering System **");
                Console.WriteLine("******************************************************\n");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Create a Payment Option");
                Console.WriteLine("3. Order a Product");
                Console.WriteLine("4. Complete an Order");
                Console.WriteLine("5. See Product Popularity");
                Console.WriteLine("6. Leave Bangazon!\n");
                Console.Write("Your choice: ");
                Int32.TryParse(Console.ReadLine(), out menuOption);

                switch (menuOption)
                {
                    case 1: //create an account
                        break;
                    case 2: //create a payment option
                        break;
                    case 3: //order a product
                        break;
                    case 4: //complete an order
                        break;
                    case 5: //product popularity
                        break;
                    case 6: //Leave Bangazon!
                        break;
                }
            }
        }
    }
}
