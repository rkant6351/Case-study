using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ecom_Application.Entity
{
    public class Orders
    {
        private int _Order_id;
        private int _Customer_id;
        private DateTime _Order_date;
        private double _Total_price;
        private string _Shipping_address;

        public int Order_id
        {
            get { return _Order_id; }
            set { _Order_id = value; }
        }
        public int Customer_id
        {
            get { return _Customer_id; }
            set { _Customer_id = value; }
        }
        public DateTime Order_date
        {
            get { return _Order_date; }
            set { _Order_date = value; }
        }
        public double Total_price
        {
            get { return _Total_price; }
            set { _Total_price = value; }
        }
        public string Shipping_address
        {
            get { return _Shipping_address; }
            set { _Shipping_address = value; }
        }

        public Orders() 
        { 

        }
        public Orders(int order_id, int customer_id, DateTime order_date, double total_price, string shipping_address)
        {
            
            Order_id = order_id;
            Customer_id = customer_id;
            Order_date = order_date;
            Total_price = total_price;
            Shipping_address = shipping_address;
        }
    }
}
