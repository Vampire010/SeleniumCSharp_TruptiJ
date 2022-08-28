using OpenQA.Selenium;
using Selenium_Aug_10_truptiJ.Browser_SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Aug_10_truptiJ.LoginPage_Objects
{
    public class LoginPage : browserLauncher
    {
        public IWebDriver driver;
        //Implicit wait
        WebDriverWait wait = new WebDriverWait(browserLauncher.driver, TimeSpan.FromSeconds(10));

        private By  username = By.XPath("//*[@id='loginPanel']/form/div[1]/input");

            private By password = By.XPath("//*[@id='loginPanel']/form/div[2]/input");

            private By LoginBtn =By.XPath("//*[@id='loginPanel']/form/div[3]/input");

        private By LogOut = By.XPath("//*[@id='leftPanel']/ul/li[8]/a");


        public LoginPage(IWebDriver driver)
        { 
           this.driver = driver;
        }

        public void EnterUsername(string entrUserName)
        {
           IWebElement un = 
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(""))); 

            browserLauncher.driver.FindElement(username).SendKeys(entrUserName);
        }
        public void EnterPassword(string entrPassword)
        {
            browserLauncher.driver.FindElement(password).SendKeys(entrPassword);
        }
        public void ClikLoginBtn()
        {
            browserLauncher.driver.FindElement(LoginBtn).Click();
        }
        public void VerifyUserLoggedIn()
        {
            IWebElement userLoggedIn = browserLauncher.driver.FindElement(LogOut);
            Boolean isLogOutDisplayed = userLoggedIn.Displayed;
            Assert.IsTrue(isLogOutDisplayed);

            Screenshot screenshot = (browserLauncher.driver as ITakesScreenshot).GetScreenshot();
           
            screenshot.SaveAsFile("screenshot.png", ScreenshotImageFormat.Png);
            screenshot.SaveAsFile(@"C:\Users\giris\source\repos\SeleniumCSharp\Selenium-Aug-10-truptiJ\Screenshots\Hello.jpeg");

        }


    }
}
