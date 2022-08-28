using August06_Trupti_J.OrderFood;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August06_Trupti_J.FoodApp
{
     class InputCustomerDetails : Customer
    {

       // [Test]
        public void EnterCustomerDetails()
        {
            
            customername = "John";
            contactNumber = 9876543210L;
            customerid = "C101";
            displayCustomerDetails();
            updateDetails("RAMA");
            updateDetails(1234567890L);


        }
    }
}
