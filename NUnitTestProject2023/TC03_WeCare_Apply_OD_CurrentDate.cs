using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
namespace NUnitTestProject2023
{
    internal class TC03_WeCare_Apply_OD_CurrentDate
    {
        //create the reference for the browser    
        IWebDriver driver;
        [SetUp]
        public void InvokeBrowser()
        {
            driver = new ChromeDriver();
            //navigate to URL
            driver.Navigate().GoToUrl("https://wecare.inspirisys.com/");
            //maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
        [Test]
        public void LoginTest()
        {
            EnterUsername();
            EnterPassWord();
            SubmitButton();
            LogoutButton();
            Cleanup();
        }
        [Test]
        public void TC_Apply_OD_CurrentDate()
        {
            InvokeBrowser();
            EnterUsername();
            EnterPassWord();
            SubmitButton();
            MenuBtn_click();
            LeaveBtn_click();
            On_Duty_Application();
            Proceed_Btn();
            SelectReason();
            ApplyBtn_click();
            AlertHandle();
            BackBtn_click();
            On_Duty_Application();
            MenuBtn_click();
            HomeBtn_click();
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
            //Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
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
        public void MenuBtn_click()
        {
            Thread.Sleep(4000);
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@id=\"gn-menu\"]")));

            IWebElement MenuIcon = driver.FindElement(By.XPath("//ul[@id=\"gn-menu\"]//a[@title=\"Click here for Menu\"]"));
            Actions mouseHover = new Actions(driver);
            mouseHover.MoveToElement(MenuIcon).Build().Perform();
            MenuIcon.Click();
            Thread.Sleep(2000);
        }
        public void LeaveBtn_click()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            IWebElement leave = driver.FindElement(By.XPath("//a[text()=\"Leave\"]"));
            leave.Click();
        }
        public void On_Duty_Application()
        {
            IWebElement onDuty = driver.FindElement(By.XPath("//a[text()=\"OnDuty Application\"]"));
            onDuty.Click();
        }
        public void Proceed_Btn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement currentDay = driver.FindElement(By.Id("btnProceed"));
            currentDay.Click();
            
        }
        public void SelectReason()
        {
            Thread.Sleep(3000);
            //option[text()="On Duty"]
            //DropDown Selection
            SelectElement reason_dropdown = new SelectElement(driver.FindElement(By.Id("OnDutyHD_laReasonDrop")));
            reason_dropdown.SelectByText("On Duty");
            //reason_dropdown.SelectByIndex(4);
            //Enter the mobile number
            IWebElement contactNumber = driver.FindElement(By.Id("OnDutyHD_laPhoneNo"));
            contactNumber.Click();
            contactNumber.SendKeys("<MobileNumber>");
        }
        public void ApplyBtn_click()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement applyBtn = driver.FindElement(By.Id("btnSubmit"));
            applyBtn.Click();

        }
        public void AlertHandle()
        {
            // Switch the control of 'driver' to the Alert from main Window
            IAlert alert = driver.SwitchTo().Alert();
            //capture alert message
            string alertMsg = driver.SwitchTo().Alert().Text;
            //display the Alert Message
            Console.WriteLine("Alert Message is:" + alertMsg);
            //Accept the Alert
            alert.Accept();
        }
        public void BackBtn_click()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            IWebElement backBtn = driver.FindElement(By.XPath("//input[@value=\"Back\"]"));
            backBtn.Click();

        }
        public void HomeBtn_click()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //Mouse Hover Mechanism
            IWebElement HomeIcon = driver.FindElement(By.XPath("//a[text()=\"Home\"]"));
            Actions mouseHover = new Actions(driver);
            mouseHover.MoveToElement(HomeIcon).Build().Perform();
            HomeIcon.Click();
        }
        public void DatePicker()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement datePicker = driver.FindElement(By.XPath("//input[@id=\"OnDutyHD_laLeaveFrom\"]"));
            datePicker.Click();
        }
        public void previousMonth()
        {
            //click previous Month on date Table
            IWebElement previous_month = driver.FindElement(By.XPath("//div[@class=\"datepicker-days\"]//th[@class=\"prev\"]"));
            previous_month.Click();
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
