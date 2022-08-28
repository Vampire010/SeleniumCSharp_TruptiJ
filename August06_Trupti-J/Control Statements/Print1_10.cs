using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August06_Trupti_J.Control_Statements
{
    class Print1_10
    {

        

        //[Test]
        public void testrun()
        {
            for (int num=0; num<=10;num++)
            {
                if (num >= 4 && num<=6)
                {
                    //Console.WriteLine(num);
                    continue;
                }
                Console.WriteLine(num);

            }
        }
    }
}
