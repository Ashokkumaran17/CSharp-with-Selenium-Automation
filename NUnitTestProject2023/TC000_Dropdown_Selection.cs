using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject2023
{
    internal class TC000_Dropdown_Selection
    {
        //create the reference for the browser    
        IWebDriver driver;
        [SetUp]
        public void InvokeBrowser1()
        {
            driver = new ChromeDriver();
            //navigate to URL
            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/select-dropdown-demo");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void ValidateDropDownSelection()
        {
            Thread.Sleep(2000);
            string dayOfTheWeek = "Wednesday";
            //IWebElement element = driver.FindElement(By.Id("select-demo"));
            //SelectElement dropDown = new SelectElement(element);
            //Select[@id="select-demo"]
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Id("select-demo")));
            dropDown.SelectByValue(dayOfTheWeek);
            string actualText = driver.FindElement(By.CssSelector(".selected-value.text-size-14")).Text;
            Console.WriteLine("The Actual Text is:"+actualText);
            //Assert.True(actualText.Contains(dayOfTheWeek), $"The expected day of the week {dayOfTheWeek} was not selected. The actual text was: {actualText}.");
            //Assert.Equals(actualText, dayOfTheWeek);
            //Assert.Equals(actualText.Contains(dayOfTheWeek), $"The expected day of the week {dayOfTheWeek} was not selected. The actual text was: {actualText}.");
        }
        [TearDown]
        public void Cleanup()
        {
            //close the browser  
            driver.Close();
        }
    }
}
