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
            List<Product> lineItems = new List<Product>();

            Console.WriteLine("******************************************************");
            Console.WriteLine("** Welcome to Bangazon Command Line Ordering System **");
            Console.WriteLine("******************************************************");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Create a Payment Option");
            Console.WriteLine("3. Order a Product");
            Console.WriteLine("4. Complete an Order");
            Console.WriteLine("5. See Product Popularity");
            Console.WriteLine("6. Leave Bangazon!");
            Console.Write("Your choice: ");
        }
    }
}
