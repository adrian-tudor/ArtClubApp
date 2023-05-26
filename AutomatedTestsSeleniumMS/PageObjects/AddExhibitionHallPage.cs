using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    class AddExhibitionHallPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement exhibitionHallName;

        [FindsBy(How = How.Id, Using = "Location")]
        private IWebElement exhibitionHallLocation;

        [FindsBy(How = How.Id, Using = "Rent")]
        private IWebElement exhibitionHallRent;

        [FindsBy(How = How.XPath, Using = "/html/body/div/main/div[1]/div/form/div[4]/input")]
        private IWebElement saveButton;
        public AddExhibitionHallPage(IWebDriver driver)
        {
            this.webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Save(string exhibitionHallName, string exhibitionHallLocation, string exhibitionHallRent)
        {
            this.exhibitionHallName.Clear();
            this.exhibitionHallName.SendKeys(exhibitionHallName);
            this.exhibitionHallLocation.Clear();
            this.exhibitionHallLocation.SendKeys(exhibitionHallLocation);
            this.exhibitionHallRent.Clear();
            this.exhibitionHallRent.SendKeys(exhibitionHallRent);
            saveButton.Click();
        }
    }
}
