using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.Entity
{
    public class Products
    {
        private int _product_id;
        private string _name;
        private decimal _price;
        private string _description;
        private int _stockQuantity;

        public int Product_id
        {
            get { return _product_id; } 
            set { _product_id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int StockQuantity
        {
            get { return _stockQuantity; }
            set { _stockQuantity = value; }
        }

        public Products() 
        { 

        }

        public Products(int product_id, string name, decimal price, string description, int stockQuantity)
        {
            
            Product_id= product_id;
            Name = name;
            Price = price;
            Description = description;
            StockQuantity = stockQuantity;
        }
    }
}
