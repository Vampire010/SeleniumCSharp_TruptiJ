using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August06_Trupti_J.Control_Statements
{
    class orderFood
    {
        /*Pizza 
         * Burger
         * Sandwich
         */

        string foodName = "CoolDrinks";

       // [Test]
        public void foodDetails()
        {
            switch (foodName)
            {
                case "Pizza":
                    Console.WriteLine(foodName+ "Qty = 20 , Price = 100$");
                    break;
                case "Burger":
                    Console.WriteLine(foodName + "Qty = 10 , Price = 110$");
                    break;
                case "Sandwich":
                    Console.WriteLine(foodName + "Qty = 11 , Price = 10$");
                    break;
                default:
                    Console.WriteLine("Enetr Valid Food Name");
                    break;


            }
        }



    }
}
