using NUnit.Framework;
using System;

namespace August06_Trupti_J
{
    public class Tests
    {
        string firstName = "John";

        int _age = 22;
        double @Height = 6.2;

        long contactNumber2 = 9876543210L;

        Boolean status = true;
      
       // [SetUp]
        public void Setup()
        {
            var unknown = 10;
            Console.WriteLine(firstName);
            Console.WriteLine(!status);

        }

       // [Test]
        public void Test1()
        {

        }
    }
}