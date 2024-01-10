using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.Entity
{
    public class Order_item
    {
        private int _Order_item_id;
        private int _Order_id;
        private int _Product_id;
        private int _Quantity;

        public int Order_item_id
        {
            get { return _Order_item_id;}
            set { _Order_item_id = value;}
        }
        public int Order_id
        {
            get { return _Order_id;}
            set { _Order_id = value;}
        }
        public int Product_id
        {
            get { return _Product_id;}
            set { _Product_id = value;}
        }
        public int Quantity
        {
            get { return _Quantity;}
            set { _Quantity = value;}
        }

        public Order_item()
        {

        }
        public Order_item(int order_item_id, int order_id, int product_id, int quantity)
        {
            
            Order_item_id = order_item_id;
            Order_id = order_id;
            Product_id = product_id;
            Quantity = quantity;
        }
    }
}
