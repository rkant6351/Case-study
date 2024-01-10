using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.Exceptions_classes
{
    internal class OrderNotFoundException : Exception
    {
        public OrderNotFoundException() : base("Order not Found")
        {

        }
    }
}
