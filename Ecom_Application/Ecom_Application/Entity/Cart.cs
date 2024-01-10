using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.Entity
{
    public class Cart
    {
        private int _Cart_id;
        private int _Customer_id;
        private int _Product_id;
        private int _Quantity;

        public int Cart_id
        {
            get { return _Cart_id; }
            set { _Cart_id = value; }
        }
        public int Customer_id
        {
            get { return _Customer_id; }
            set { _Customer_id = value; }
        }
        public int Product_id
        {
            get { return _Product_id; }
            set { _Product_id = value; }
        }
        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        public Cart() 
        {

        }

        public Cart(int cart_id, int customer_id, int product_id, int quantity)
        {
            Cart_id = cart_id;
            Customer_id = customer_id;
            Product_id = product_id;
            Quantity = quantity;
        }
    }

}
