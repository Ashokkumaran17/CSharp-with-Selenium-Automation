using NUnit.Framework;
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
    internal class TC01_BrowserTest
    {
        //create the reference for the browser  
        IWebDriver driver = new ChromeDriver("C:\\Chromedriver\\chromedriver.exe");
        public void InvokeBrowser()
        {
            //navigate to URL  
            driver.Navigate().GoToUrl("https://wecare.inspirisys.com/");
            Thread.Sleep(2000);
        }
        public void LoginTest()
        {
            IWebElement userField =driver.FindElement(By.Name("Username"));
            userField.Click();
            userField.SendKeys("<Username>");
            IWebElement passwordField = driver.FindElement(By.Name("Password"));
            passwordField.Click();
            passwordField.SendKeys("<Password>");
            IWebElement submitBtn = driver.FindElement(By.XPath("//button[text()=\"Sign in\"]"));
            submitBtn.Click();


        }
        public void LogoutTest()
        {
            Thread.Sleep(4000);
            IWebElement imgTop = driver.FindElement(By.XPath("//li[@class=\"imgtop yellow1\"]"));
            imgTop.Click();
            IWebElement logoutBtn = driver.FindElement(By.XPath("//button[@class='log-location']"));
            logoutBtn.Click();

        }
        public void Cleanup()
        {
            driver.Close();
        }
        static void Main(string[] args)
        {
            TC01_BrowserTest driverobj= new TC01_BrowserTest();
            driverobj.InvokeBrowser();
            driverobj.LoginTest();
            driverobj.LogoutTest();
            driverobj.Cleanup();

        }

    }
}
