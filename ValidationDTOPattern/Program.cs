using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDTOPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails ord = new OrderDetails();
            ord.Name = "sipariş örnek";
            ord.OrderID = 5;


            ValidationManager valmanager = new ValidationManager();
            bool validationsonuc = valmanager.IsValid<OrderDetails>(ord);

        }
    }
}
