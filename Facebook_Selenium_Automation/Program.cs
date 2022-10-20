using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Timers;

namespace Selenium_Automation
{
    class Program
    {

        // Create a reference for Chrome browser
        IWebDriver driver = new ChromeDriver();

        //static void Main(string[] args)
        //{
        //}

        [SetUp]
        public void Initialize()
        {
            // Go to Facebook page
            //driver.Navigate().GoToUrl("https://www.facebook.com");

            // Go to Facebook REGISTRATION page
            driver.Navigate().GoToUrl("https://www.facebook.com/reg/");
        }


        [Test]
        public void ExecuteTest()
        {
            // Make the browser full screen
            driver.Manage().Window.Maximize();


            // Web elements & their respective operations

            // Click create new account button
            // id="u_0_0_DC"
            // id="signup-button"
            // class --> class="_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy"
            // XPath --> //*[@id="u_0_0_DC"]
            //IWebElement CreateNewAccountButton = driver.FindElement(By.ClassName("_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy"));
            //CreateNewAccountButton.Click();
            //IWebElement CreateNewAccountButton = driver.FindElement(By.XPath("//*[@id=\"u_0_0_DC\"]"));
            //CreateNewAccountButton.Click();

            //IWebElement CreateNewAccountButton = driver.FindElement(By.Id("signup-button"));
            //CreateNewAccountButton.Click();

            // Input first name
            IWebElement FirstNameField = driver.FindElement(By.Id("u_0_b_4I"));
            FirstNameField.SendKeys("Maurice");

            // Input last name
            IWebElement LastNameField = driver.FindElement(By.Id("u_0_d_Iw"));
            LastNameField.SendKeys("Moss");

            // Input email
            IWebElement EmailField = driver.FindElement(By.Id("u_0_g_sm"));
            EmailField.SendKeys("mysweetstyle@it.moss");

            // Re-enter email
            IWebElement ReEnterEmailField = driver.FindElement(By.Id("u_0_j_ZN"));
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
            selectElementYear.SelectByValue("1987");

            // Select gender button
            IWebElement GenderButton = driver.FindElement(By.Id("u_0_5_Ph"));
            GenderButton.Click();

            // Click sign up button
            IWebElement SignUpButton = driver.FindElement(By.Id("u_0_s_h2"));
            SignUpButton.Click();

            Thread.Sleep(2000);

            // Error message --> XPath --> //*[@id="reg_error_inner"]
            IWebElement ErrorMessage = driver.FindElement(By.XPath("//*[@id=\"reg_error_inner\"]"));

            // Assertion
            Assert.That(ErrorMessage.Text.Contains("It looks like you may have entered an incorrect email address. Please correct it if necessary, then click to continue."));

        }


        [TearDown]
        public void CloseTest()
        {
            // Close the browswer
            driver.Quit();
        }

    }
}


