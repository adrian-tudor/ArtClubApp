using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class HomePage
    {
        private IWebDriver webDriver;

        public HomePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement loginButton;

        public LoginPage GoToLoginPage()
        {
            loginButton.Click();
            return new LoginPage(webDriver);
        }

        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:7292/");
        }
    }
}
