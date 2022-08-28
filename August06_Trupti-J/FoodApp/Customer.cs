using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August06_Trupti_J.FoodApp
{
    public  class Customer
    {
        public string customername;
        public string customerid;
        public long contactNumber;

        public double totalCost;
       //non return Type
       //return type 

        public void displayCustomerDetails()
        {
            Console.WriteLine("customername: " + customername);
            Console.WriteLine("customerid: " + customerid);
            Console.WriteLine("contactniumber: "+ contactNumber);
        }

        public void updateDetails(string customername)
        {
            Console.WriteLine("customername: " + customername);
        }

        public void updateDetails(long contactNumber)
        {
            Console.WriteLine("contactniumber: " + contactNumber);
        }





    }
}
