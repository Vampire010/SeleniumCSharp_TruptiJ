using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Aug_10_truptiJ.Browser_SetUp
{
     public class browserLauncher
    {
        public static IWebDriver driver ;
        
        public static void openBrowser(string BrowserType, string url)
        {
            if (BrowserType.Equals("chrome"))
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
            }

            else if (BrowserType.Equals("edge"))
            {
                driver = new EdgeDriver(EdgeDriverService.CreateDefaultService(".","msedgedriver.exe"));
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
            }
            else 
            {
                Console.WriteLine("Invalid Browser Type");
            }
        
        }
    }
}
