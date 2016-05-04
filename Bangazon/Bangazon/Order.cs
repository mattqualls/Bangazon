using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
     public class Order
    {
        public int idOrder { get; set; }
        public int idCustomer { get; set; }
        public int idPaymentOption { get; set; }
        public string shippingMethod { get; set; }
    }
}
