using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnitTestProject2023
{
    internal class TC02_WeCare_LoginTest
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
            EnterUsername();
            EnterPassWord();
            SubmitButton();
            LogoutButton();
        }
        [TearDown]
        public void Cleanup()
        {
            //close the browser  
            driver.Close();
        }
        public void EnterUsername()
        {
            IWebElement userField = driver.FindElement(By.Name("Username"));
            userField.Click();
            userField.SendKeys("<Username>");
        }
        public void EnterPassWord()
        {
            IWebElement passwordField = driver.FindElement(By.Name("Password"));
            passwordField.Click();
            passwordField.SendKeys("<Password>");
        }
        public void SubmitButton()
        {
            IWebElement submitBtn = driver.FindElement(By.XPath("//button[text()=\"Sign in\"]"));
            submitBtn.Click();
        }
        public void LogoutButton()
        {
            Thread.Sleep(4000);
            IWebElement imgTop = driver.FindElement(By.XPath("//li[@class=\"imgtop yellow1\"]"));
            imgTop.Click();
            IWebElement logoutBtn = driver.FindElement(By.XPath("//button[@class='log-location']"));
            logoutBtn.Click();
        }
    }
}
