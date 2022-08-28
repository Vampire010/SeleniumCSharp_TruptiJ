using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August06_Trupti_J.Control_Statements
{
    /*  min=1 t ,max100
     * >= 90 ; A+
     * >=80<=89 ; A 
     * >=60<=79 ; B+
     * >=50<=59 ; B
     * >=35<=49 ;C
     * >=0<=34 ; Try Again
     */

    class Student
    {
        int maxMarks = 100;
        int minMarks = 0;

        int AchivedMarks = 901;

       // [Test]
        public void calculateRank()
        {
            if (AchivedMarks>=minMarks && AchivedMarks<= maxMarks)
            {
                if (AchivedMarks >= 90 && AchivedMarks <= maxMarks)
                {
                    Console.WriteLine("Grade A+");
                }
                else if (AchivedMarks >= 80 && AchivedMarks <= 89)
                {
                    Console.WriteLine("Grade A");
                }
                else if (AchivedMarks >= 60 && AchivedMarks <= 79)
                {
                    Console.WriteLine("Grade B+");
                }
                else if (AchivedMarks >= 50 && AchivedMarks <= 59)
                {
                    Console.WriteLine("Grade B");
                }
                else if (AchivedMarks >= 35 && AchivedMarks <= 49)
                {
                    Console.WriteLine("Grade c");
                }

                else if (AchivedMarks >= 0 && AchivedMarks <= 34)
                {
                    Console.WriteLine("Try Again");
                }

                else
                {
                    Console.WriteLine(" Enetr the Valid Input");
                }
            }
            else { Console.WriteLine("Better Luck Next time"); }

        }




    }
}
