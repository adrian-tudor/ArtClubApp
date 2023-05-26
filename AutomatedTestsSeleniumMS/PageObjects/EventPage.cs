using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class EventPage
    {
        private IWebDriver webDriver;


        [FindsBy(How = How.CssSelector, Using = "main")]
        private IWebElement eventLists;
        public void GoToPage()
        {
            webDriver.Navigate().GoToUrl("https://localhost:7292/Events");
        }
        public EventPage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/div/main/p/a")]
        private IWebElement addEventButton;

        [FindsBy(How = How.Id, Using = "logout")]
        private IWebElement logoutButton;

        public HomePage GoToHomePage()
        {
            logoutButton.Click();
            return new HomePage(webDriver);
        }
        public AddEventPage GotoAddEventPage()
        {
            addEventButton.Click();
            return new AddEventPage(webDriver);
        }
        public bool EventExists(string eventTitle)
        {
            var elements = eventLists.FindElements(By.TagName("div"));
            return elements.Where(element => element.Text.Equals(eventTitle)).Count() > 0;

        }
    }
}
