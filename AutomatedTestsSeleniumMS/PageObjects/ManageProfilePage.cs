using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestsSeleniumMS.PageObjects
{
    public class ManageProfilePage
    {

        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "Input_PhoneNumber")]
        private IWebElement userPhoneNumber;

        [FindsBy(How = How.Id, Using = "update-profile-button")]
        private IWebElement updateProfileButton;

        public ManageProfilePage(IWebDriver driver)
        {
            webDriver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Profile(string phoneNumber)
        {
            userPhoneNumber.Clear();
            userPhoneNumber.SendKeys(phoneNumber);
            updateProfileButton.Click();
        }
    }
}
