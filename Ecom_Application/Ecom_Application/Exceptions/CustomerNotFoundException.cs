using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.Exceptions_classes
{
    internal class CustomerNotFoundException:Exception
    {
        public CustomerNotFoundException() : base("Customer ID Is invalid")
        {

        }
    }
}
