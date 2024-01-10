using Ecom_Application.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.DAO
{
    public interface OrderProcessorRepository
    {
        bool createProduct(Products products);
        bool createCustomer(Customers customers);
        bool deleteProduct(int product_id);
        bool deleteCustomer(int customer_id);
        bool addToCart(Customers customer, Products product, int quantity);
        bool removeFromCart(Customers customer, Products product);
        List<Products> getAllFromCart(Customers customer);

        bool PlaceOrder(Customers customer, List<Tuple<Products, int>> productsAndQuantities, string shippingAddress);
        List<Tuple<Products, int>> getOrdersByCustomer(int Customer_id);

    }
}
