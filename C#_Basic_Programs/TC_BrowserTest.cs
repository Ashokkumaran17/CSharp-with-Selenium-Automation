using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Csharp_2023
{
    internal class TC_BrowserTest
    {   

        static void Main(string[] arg)
        {
            //create the reference for the browser  
            IWebDriver driver = new ChromeDriver("C:\\Chromedriver\\chromedriver.exe");
            //navigate to URL  
            driver.Navigate().GoToUrl("https://wecare.inspirisys.com/");
            //Maximize the browser window  
            //driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            //close the browser  
            driver.Close();

        }
        
    }
}
