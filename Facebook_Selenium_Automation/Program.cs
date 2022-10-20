using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Selenium_Automation
{
    class Program
    {

        // Create a reference for Chrome browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            // Go to Facebook page
            driver.Navigate().GoToUrl("https://www.facebook.com");
        }


        [Test]
        public void ExecuteTest()
        {
            // Make the browser full screen
            driver.Manage().Window.Maximize();


            // Web elements & their respective operations

            // Click new account button
            IWebElement CreateNewAccountButton = driver.FindElement(By.Id("open-registration-form-button"));
            CreateNewAccountButton.Click();

            // Input first name
            IWebElement FirstNameField = driver.FindElement(By.Id("u_b_b_7/"));
            FirstNameField.SendKeys("Maurice");

            // Input last name
            IWebElement LastNameField = driver.FindElement(By.Id("u_b_d_Yk"));
            LastNameField.SendKeys("Moss");

            // Input email
            IWebElement EmailField = driver.FindElement(By.Id("u_b_g_ao"));
            EmailField.SendKeys("my@sweetstyle.com");

            // Re-enter email
            IWebElement ReEnterEmailField = driver.FindElement(By.Id("u_b_j_b/"));
            ReEnterEmailField.SendKeys("mysweetstyle103-98@gmail.com");

            // Input new password
            IWebElement NewPasswordField = driver.FindElement(By.Id("password_step_input"));
            NewPasswordField.SendKeys("Icamehere2drinkmilk&kick@$$");

            // Select birth month
            IWebElement BirthMonth = driver.FindElement(By.Id("month"));
            var selectElementMonth = new SelectElement(BirthMonth);
            selectElementMonth.SelectByValue("3");

            // Select birth day
            IWebElement BirthDay = driver.FindElement(By.Id("day"));
            var selectElementDay = new SelectElement(BirthDay);
            selectElementDay.SelectByValue("2");

            // Select birth year
            IWebElement BirthYear = driver.FindElement(By.Id("year"));
            var selectElementYear = new SelectElement(BirthYear);
            selectElementYear.SelectByValue("1973");

            // Select gender button
            IWebElement GenderButton = driver.FindElement(By.Id("u_b_5_Ri"));
            GenderButton.Click();

            // Click sign up button
            IWebElement SignUpButton = driver.FindElement(By.Id("u_b_s_Xr"));
            SignUpButton.Click();

            Thread.Sleep(2000);

            // Error message ::TODO generate proper XPath
            IWebElement ErrorMessage = driver.FindElement(By.XPath("a-alert-heading"));

            // Assertion
            Assert.That(ErrorMessage.Text.Contains("Sorry, we are not able to process your registration."));

        }


        [TearDown]
        public void CloseTest()
        {
            // Close the browswer
            driver.Quit();
        }

    }
}


