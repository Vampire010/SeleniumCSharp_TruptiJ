using August06_Trupti_J.FoodApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August06_Trupti_J.OrderFood
{
    public abstract class OrdersV1
    {

        public string foodName;
        public int Qty;

        public abstract void CookingInstructions();

        public void OrderdFood()
        { 
            Console.WriteLine(foodName);
            Console.WriteLine(Qty);
        
        }

    }
}
