using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class PaymentType
    {
        public int idPaymentOption { get; set; }
        public int idCustomer { get; set; }
        public string name { get; set; }
        public string accountNumber { get; set; }
    }
}
