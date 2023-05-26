using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class AddEventPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement eventName;

        [FindsBy(How = How.Id, Using = "Location")]
        private IWebElement eventLocation;

        [FindsBy(How = How.Id, Using = "Time")]
        private IWebElement eventTime;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div[1]/div/form/div[4]/input")]
        private IWebElement saveButton;
        public AddEventPage(IWebDriver driver)
        {
            this.webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Save(string eventName, string eventLocation, string eventTime)
        {
            this.eventName.Clear();
            this.eventName.SendKeys(eventName);
            this.eventLocation.Clear();
            this.eventLocation.SendKeys(eventLocation);
            this.eventTime.Clear();
            this.eventTime.SendKeys(eventTime);
            saveButton.Click();
        }
    }
}
