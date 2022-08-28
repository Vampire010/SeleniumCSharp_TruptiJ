using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_Aug_10_truptiJ.Browser_SetUp;
using Selenium_Aug_10_truptiJ.LoginPage_Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_Aug_10_truptiJ.TestRunner
{
    public class Logintest
    {
        public static string testurl = "https://parabank.parasoft.com/";
        public static string browserType1 = "chrome";
        public static string browserType2 = "edge";


        public static string actual_url = "https://parabank.parasoft.com/parabank/overview.htm";

      // [Test ,Order(2)]
        public static void loginTestRun1()
        {
            LoginPage lp = new LoginPage(browserLauncher.driver);

            LoginPage.openBrowser(browserType1,testurl);
            lp.EnterUsername("JohnDee123");
            lp.EnterPassword("PswdJohnDee123");
            //Thread.Sleep(3000);
            lp.ClikLoginBtn();

            string LoggedInUrl = browserLauncher.driver.Url;
            Console.WriteLine(LoggedInUrl);
            // Raise an assert if the URL's do not match
            Assert.That(LoggedInUrl, Is.EqualTo(actual_url));

            browserLauncher.driver.Close();
        }

        [Test, Order(1)]
        public static void loginTestRun2()
        {
            LoginPage lp = new LoginPage(browserLauncher.driver);

            LoginPage.openBrowser(browserType2, testurl);
            lp.EnterUsername("JohnDee123");
            lp.EnterPassword("PswdJohnDee123");
            lp.ClikLoginBtn();
            lp.VerifyUserLoggedIn();
            browserLauncher.driver.Close();
        }
    }
}
