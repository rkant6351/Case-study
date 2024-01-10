using Ecom_Application.DAO;
using Ecom_Application.Entity;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application
{
    internal class Ecom
    {
        static void Main(string[] args)
        {
            try
            {
                int flag = 0;
                do
                {
                    Console.WriteLine("Welcome to Ecom Application");
                    Console.WriteLine("Enter 1 To Register Customer");
                    Console.WriteLine("Enter 2 To Create Product");
                    Console.WriteLine("Enter 3 To Delete Product");
                    Console.WriteLine("Enter 4 To Add to cart");
                    Console.WriteLine("Enter 5 To View Cart");
                    Console.WriteLine("Enter 6 To Place Order");
                    Console.WriteLine("Enter 7 To View Customer order");
                    Console.WriteLine("Enter 8 To EXIT");
                    int x = int.Parse(Console.ReadLine());

                    switch (x)
                    {
                        case 1:
                            try
                            {
                                Customers regcustomers = new Customers();
                                Console.WriteLine("Welcome to Customers Registration Portal");
                                Console.WriteLine("Enter Customer name");
                                regcustomers.Name = Console.ReadLine();
                                Console.WriteLine("Enter Customer Email");
                                regcustomers.Email = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                regcustomers.Password = Console.ReadLine();
                                OrderProcessorRepository customerregistration = new OrderProcessorRepositoryImpl();
                                bool registration = customerregistration.createCustomer(regcustomers);
                                if (registration == true)
                                {
                                    Console.WriteLine("Customer Registered");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Customer Cannot be registered");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadLine();
                            }

                            break;

                        case 2:
                            try
                            {
                                Products addproduct = new Products();
                                Console.WriteLine("Welcome to product entry portal");
                                Console.WriteLine("Enter Product name");
                                addproduct.Name = Console.ReadLine();
                                Console.WriteLine("Enter Product price");
                                addproduct.Price = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Product Description");
                                addproduct.Description = Console.ReadLine();
                                Console.WriteLine("Enter Stock Quantity");
                                addproduct.StockQuantity = int.Parse(Console.ReadLine());
                                OrderProcessorRepository productaddition = new OrderProcessorRepositoryImpl();
                                bool product_addition = productaddition.createProduct(addproduct);
                                if (product_addition == true)
                                {
                                    Console.WriteLine("Product Added");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Product Already Exist");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadLine();
                            }
                            break;


                        case 3:
                            try
                            {
                                Products deleteproduct = new Products();
                                Console.WriteLine("Enter product id of the product that you want to Delete");
                                deleteproduct.Product_id = int.Parse(Console.ReadLine());
                                OrderProcessorRepository productdeletion = new OrderProcessorRepositoryImpl();
                                bool productdeleted = productdeletion.deleteProduct(deleteproduct.Product_id);
                                if (productdeleted == true)
                                {
                                    Console.WriteLine("Product Deleted");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a valid Product id");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadLine();
                            }
                            break;

                        case 4:
                            try
                            {
                                Customers addcartcustomer = new Customers();
                                Console.WriteLine("Enter Customer id");
                                addcartcustomer.Customer_id = int.Parse(Console.ReadLine());
                                Products addcartproduct = new Products();
                                Console.WriteLine("Enter Product id");
                                addcartproduct.Product_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Quantity");
                                int quantity = int.Parse(Console.ReadLine());
                                OrderProcessorRepository addtocart = new OrderProcessorRepositoryImpl();
                                bool addedtocart = addtocart.addToCart(addcartcustomer, addcartproduct, quantity);
                                if (addedtocart == true)
                                {
                                    Console.WriteLine("Added to cart");
                                }
                                else
                                {
                                    Console.WriteLine("Either customer doesnot exist or product not available");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadLine();
                            }
                            break;



                        case 5:
                            try
                            {
                                Customers viewcustomerscart = new Customers();
                                Console.WriteLine("Enter Customer id");
                                viewcustomerscart.Customer_id = int.Parse(Console.ReadLine());
                                OrderProcessorRepository viewcart = new OrderProcessorRepositoryImpl();
                                List<Products> products = viewcart.getAllFromCart(viewcustomerscart);
                                if (products != null)
                                {
                                    foreach (Products p in products)
                                    {
                                        Console.WriteLine($"\nProduct id={p.Product_id}\nName={p.Name}\n{p.Price}\n{p.Description}");
                                        Console.ReadLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("User Doestnot have any item in his cart");
                                    Console.ReadLine();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.ReadLine();
                            }
                            break;


                        case 6:
                            int flagplaceorder = 0;
                            Console.WriteLine("\nWelcome to Order placing portal\n");
                            List<Tuple<Products, int>> placeorderlist = new List<Tuple<Products, int>>();
                            Customers customer = new Customers();
                            Console.WriteLine("Enter customer id");
                            customer.Customer_id = int.Parse(Console.ReadLine());
                            do
                            {
                                Products products = new Products();
                                Console.WriteLine("Enter Product id of the product that you want to order");
                                products.Product_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Quantity of this product");
                                int quantity = int.Parse(Console.ReadLine());
                                placeorderlist.Add(Tuple.Create(products, quantity));
                                Console.WriteLine("Enter 1 to add more item to the order list or enter any other number to proceed without adding more");
                                int addmore = int.Parse(Console.ReadLine());
                                if (addmore == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    flagplaceorder = 1;
                                }
                            }
                            while (flagplaceorder != 1);
                            Console.WriteLine("Enter Shipping address");
                            string shippingaddress = Console.ReadLine();

                            OrderProcessorRepository placeorder = new OrderProcessorRepositoryImpl();
                            bool orderplacedornot = placeorder.PlaceOrder(customer, placeorderlist, shippingaddress);
                            if (orderplacedornot == true)
                            {
                                Console.WriteLine("Order Placed");
                            }
                            else
                            {
                                Console.WriteLine("Order cannot be placed");
                            }
                            break;

                        case 7:
                            try
                            {
                                List<Tuple<Products, int>> listcustomerOrders = new List<Tuple<Products, int>>();
                                Console.WriteLine("Enter customer id");
                                int a = int.Parse(Console.ReadLine());
                                OrderProcessorRepository Customerorders = new OrderProcessorRepositoryImpl();
                                listcustomerOrders = Customerorders.getOrdersByCustomer(a);
                                if (listcustomerOrders != null)
                                {
                                    foreach (var order in listcustomerOrders)
                                    {

                                        Console.WriteLine($"Product id: {order.Item1.Product_id} Product Name: {order.Item1.Name}, Quantity: {order.Item2}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Order detail not found");
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.ReadLine();
                            break;
                        case 8:
                            flag = 1;
                            break;

                        case 9:/*int flagvalidate = 0;
                            OrderProcessorRepositoryImpl validate=new OrderProcessorRepositoryImpl();
                            List<Tuple<Products, int>> validation = new List<Tuple<Products, int>>();
                            do
                            {
                                Products products = new Products();
                                Console.WriteLine("Enter Product id of the product that you want to order");
                                products.Product_id = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Quantity of this product");
                                int quantity = int.Parse(Console.ReadLine());
                                validation.Add(Tuple.Create(products, quantity));
                                Console.WriteLine("Enter 1 to add more item to the order list or enter any other number to proceed without adding more");
                                int addmore = int.Parse(Console.ReadLine());
                                if (addmore == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    flagvalidate = 1;
                                }
                            } while (flagvalidate != 1);

                            
                            decimal gettotal = validate.calculatetotalamount(validation);
                            Console.WriteLine($"Total amount={gettotal}");*/
                            break;

                        default:
                            Console.WriteLine("Please Enter a valid Choice");
                            break;
                    }


                    Console.ReadKey();
                } while (flag != 1);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
