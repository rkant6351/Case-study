using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Application.Entity
{
    public class Customers
    {
        private int _Customer_id;
        private string _Name;
        private string _Email;
        private string _Password;
        public int Customer_id
        {
            get { return this._Customer_id; }
            set { this._Customer_id = value; }
        }
        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }
        public string Email
        {
            get { return this._Email; }
            set { this._Email = value; }
        }
        public string Password
        {
            get { return this._Password; }
            set { this._Password = value; }
        }

        public Customers()
        {

        }
        public Customers(int customer_id, string name, string email, string password)
        {
            this.Customer_id = customer_id;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }
    }
}
