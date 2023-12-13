using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitTestProject2023
{
    [TestClass]
   
    internal class TC01_BrowserTest
    {
        //create the reference for the browser    
        IWebDriver driver;
        [SetUp]
        public void InvokeBrowser()
        {
            driver = new ChromeDriver();
            //navigate to URL
            driver.Navigate().GoToUrl("https://wecare.inspirisys.com/");
            Thread.Sleep(2000);
        }
        [Test]
        public void LoginTest()
        {
            IWebElement userField = driver.FindElement(By.Name("Username"));
            userField.Click();
            userField.SendKeys("<Username>");
            IWebElement passwordField = driver.FindElement(By.Name("Password"));
            passwordField.Click();
            passwordField.SendKeys("<Password>");
            IWebElement submitBtn = driver.FindElement(By.XPath("//button[text()=\"Sign in\"]"));
            submitBtn.Click();
       
            Thread.Sleep(4000);
            IWebElement imgTop = driver.FindElement(By.XPath("//li[@class=\"imgtop yellow1\"]"));
            imgTop.Click();
            IWebElement logoutBtn = driver.FindElement(By.XPath("//button[@class='log-location']"));
            logoutBtn.Click();

        }
        [TearDown]
        public void Cleanup()
        {
            //close the browser  
            driver.Close();
        }
       
            
    }
}
